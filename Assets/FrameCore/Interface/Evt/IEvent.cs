
using System.Collections.Generic;
namespace NanoCorfe 
{
    public interface IEvent
    {
        object evtSource { get; }

        EventType eventType { get; }

        delegate void evt(IArgs args);

        delegate void evtAsync(IArgs args);

        List<IHandler> handlers { get; }

        //注册到对应调度者
        public void InitEvt(object evtSource, EventType eventType);

        public void OnInvoke(IArgs args);

        public void AddCallBack(IHandler handler);

        public void RemoveCallBack(IHandler handler);
    }
}

