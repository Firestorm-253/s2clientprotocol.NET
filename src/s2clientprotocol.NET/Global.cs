global using static s2clientprotocol.NET.Global;

namespace s2clientprotocol.NET;

public static class Global
{
    public static void Log(object message)
    {
        Console.WriteLine(">" + message);
    }
}
