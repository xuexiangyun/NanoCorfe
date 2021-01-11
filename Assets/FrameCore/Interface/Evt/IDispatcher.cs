
using System.Collections.Generic;

namespace NanoCorfe 
{
    public interface IDispatcher
    {

        //控制器的注册事件方法
        public void RegisterEvt(IEvent evt);

        //调起事件
        public void OnInvokeEvt(EventType eventType, IArgs args);

        //全局广播事件：全体dispatcher
        public void OnbroadcastEvt(EventType eventType, IArgs args);

        //添加监听事件
        public void AddListener(EventType eventType, IHandler handler);

        //移除事件回调
        public void RemoveListener(EventType eventType, IHandler handler);

        //移除事件
        public void RemoveEvt(EventType eventType);

        //移除所有事件
        public void RemoveAllEvt();

    }

}

