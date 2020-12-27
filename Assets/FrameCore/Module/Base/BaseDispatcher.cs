using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDispatcher : MonoBehaviour, IDispatcher 
{
    private  List<BaseDispatcher> dispatchers = new List<BaseDispatcher>();
    protected Dictionary<EventType, List<IEvent>> EventDic = new Dictionary<EventType, List<IEvent>>();

    public BaseDispatcher()
    {
        dispatchers.Add(this);
    }

    public void AddListener(EventType eventType, IHandler handler)
    {
        if (EventDic.ContainsKey(eventType))
        {
            for (int i = 0; i < EventDic[eventType].Count; i++)
            {
                EventDic[eventType][i].AddCallBack(handler);
            }
        }
    }

    public void OnbroadcastEvt(EventType eventType, IArgs args)
    {
        for(int i = 0; i < dispatchers.Count; i++)
        {
            dispatchers[i].OnInvokeEvt(eventType, args);
        }
    }

    public void OnInvokeEvt(EventType eventType, IArgs args)
    {
        if (EventDic.ContainsKey(eventType))
        {
            for(int i=0; i < EventDic[eventType].Count; i++)
            {
                EventDic[eventType][i].OnInvoke(args);
            }
        }
    }

    public void RegisterEvt(IEvent evt)
    {
        if (!EventDic.ContainsKey(evt.eventType))
        {
            EventDic.Add(evt.eventType, Func<List<IEvent>>(()=> new List<IEvent>()));
        }
    }

    public void RemoveAllEvt()
    {
        throw new System.NotImplementedException();
    }

    public void RemoveEvt(EventType eventType)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveListener(EventType eventType, IHandler handler)
    {
        throw new System.NotImplementedException();
    }
}
