
using System.Collections.Generic;

namespace NanoCorfe 
{
    public interface IDispatcher
    {

        //��������ע���¼�����
        public void RegisterEvt(IEvent evt);

        //�����¼�
        public void OnInvokeEvt(EventType eventType, IArgs args);

        //ȫ�ֹ㲥�¼���ȫ��dispatcher
        public void OnbroadcastEvt(EventType eventType, IArgs args);

        //��Ӽ����¼�
        public void AddListener(EventType eventType, IHandler handler);

        //�Ƴ��¼��ص�
        public void RemoveListener(EventType eventType, IHandler handler);

        //�Ƴ��¼�
        public void RemoveEvt(EventType eventType);

        //�Ƴ������¼�
        public void RemoveAllEvt();

    }

}

