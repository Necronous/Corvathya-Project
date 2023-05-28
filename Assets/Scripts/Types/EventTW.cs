using System;
using System.Collections.Generic;

public struct Event<T, W>
{
    public delegate void EventCallback(T arg, W arg2);

    private List<EventCallback> _callbacks;

    public Event(int size)
    {
        _callbacks = new List<EventCallback>(size);
    }

    public void Add(EventCallback listener)
    {
        if (_callbacks == null) _callbacks = new List<EventCallback>();
        _callbacks.Add(listener);
    }
    public void Remove(EventCallback listener)
    {
        if (_callbacks == null) return;

        int i = _callbacks.IndexOf(listener);
        if (i < 0) return;

        _callbacks[i] = _callbacks[_callbacks.Count - 1];
        _callbacks.RemoveAt(_callbacks.Count - 1);
    }
    public void Invoke(T arg, W arg2)
    {
        if (_callbacks == null) return;

        for (int i = 0; i < _callbacks.Count; i++)
            _callbacks[i](arg, arg2);
    }
    public static Event<T, W> operator +(Event<T, W> e, EventCallback c)
    {
        e.Add(c);
        return e;
    }
    public static Event<T, W> operator -(Event<T, W> e, EventCallback c)
    {
        e.Remove(c);
        return e;
    }
}
