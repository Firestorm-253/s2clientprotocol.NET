﻿using System.Diagnostics;
using System.Net.WebSockets;
using Google.Protobuf;

using SC2APIProtocol;

namespace s2clientprotocol.NET.Sc2;

public class Sc2Connection
{
    public const string SC2_PATH = "C:\\Program Files (x86)\\StarCraft II";

    private readonly CaseHandler<Response.ResponseOneofCase, Response> _handler;

    private ClientWebSocket _socket = null!;

    public Status Status { get; private set; }

    public Sc2Connection(bool startup = true, string ipAdress = "127.0.0.1", int port = 8268)
    {
        if (startup)
        {
            var sc2_process = Process.Start(new ProcessStartInfo(
            $"{SC2_PATH}\\Versions\\Base91115\\SC2.exe",
            $"-listen {ipAdress} -port {port} -displaymode 0 -windowwidth 1024 -windowheight 768 -windowx 0 -windowy 0")
            { WorkingDirectory = $"{SC2_PATH}\\Support" });
            sc2_process!.WaitForInputIdle();
        }

        if (!Connect(new Uri($"ws://{ipAdress}:{port}/sc2api")))
        {
            throw new Exception("connection failed");
        }

        _handler = new CaseHandler<Response.ResponseOneofCase, Response>();
    }

    public void RegisterHandler(Response.ResponseOneofCase action, Action<Response> handler)
    {
        _handler.RegisterHandler(action, handler);
    }

    public void DeregisterHandler(Action<Response> handler)
    {
        _handler.DeregisterHandler(handler);
    }

    private bool Connect(Uri uri, int maxAttempts = 25)
    {
        int num = 0;
        do
        {
            try
            {
                _socket = new ClientWebSocket();
                _socket.ConnectAsync(uri, CancellationToken.None).Wait();
            }
            catch (AggregateException)
            {
                Task.Delay(250).Wait();
                num++;
            }
            catch (Exception)
            {
                break;
            }
        }
        while (_socket.State != WebSocketState.Open && num < maxAttempts);
        if (_socket.State == WebSocketState.Open)
        {
            Task.Run(() => Receive());
            return true;
        }

        return false;
    }

    public void AsyncSend(Request req)
    {
        _socket.SendAsync(new ArraySegment<byte>(req.ToByteArray()), WebSocketMessageType.Binary, endOfMessage: true, CancellationToken.None);
    }

    public bool TryWaitResponse(Request req, out Response response, int wait = 1000)
    {
        Response result = null!;
        var marker = new Task(delegate { });
        void handler(Response r)
        {
            result = r;
            marker.RunSynchronously();
        }

        _handler.RegisterHandler((Response.ResponseOneofCase)req.RequestCase, handler);

        AsyncSend(req);
        marker.Wait(wait);

        _handler.DeregisterHandler(handler);
        response = result!;

        return response != null;
    }

    public async Task Receive()
    {
        ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[1024]);
        while (_socket.State == WebSocketState.Open)
        {
            using var ms = new MemoryStream();
            WebSocketReceiveResult webSocketReceiveResult;
            do
            {
                webSocketReceiveResult = await _socket.ReceiveAsync(buffer, CancellationToken.None);
                ms.Write(buffer.Array!, buffer.Offset, webSocketReceiveResult.Count);
            }
            while (!webSocketReceiveResult.EndOfMessage);
            Response response = Response.Parser.ParseFrom(ms.GetBuffer(), 0, (int)ms.Position);
            Status = response.Status;
            _handler.Handle(response.ResponseCase, response);
        }
    }
}
