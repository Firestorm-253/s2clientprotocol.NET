namespace s2clientprotocol.NET;

public class CaseHandler<T1, T2>
{
    private IDictionary<T1, ICollection<Action<T2>>> _events;

    public CaseHandler()
    {
        this._events = new Dictionary<T1, ICollection<Action<T2>>>();
    }

    public void Handle(T1 action, T2 type)
    {
        lock (this._events)
        {
            if (!this._events.TryGetValue(action, out var value))
            {
                return;
            }

            foreach (Action<T2> item in value)
            {
                item(type);
            }
        }
    }

    public void RegisterHandler(T1 action, Action<T2> handler)
    {
        lock (this._events)
        {
            if (this._events.ContainsKey(action))
            {
                this._events[action].Add(handler);
                return;
            }

            this._events.Add(action, new List<Action<T2>> { handler });
        }
    }

    public void DeregisterHandler(Action<T2> handler)
    {
        lock (this._events)
        {
            using IEnumerator<KeyValuePair<T1, ICollection<Action<T2>>>> enumerator = this._events.GetEnumerator();
            while (enumerator.MoveNext() && !enumerator.Current.Value.Remove(handler))
            {
            }
        }
    }
}