
using System;
using System.Threading.Tasks;
namespace NanoCorfe 
{
    public interface IHandlerAsync : IHandler
    {
        //�Ƽ�ʹ����I/O
        public new Task<IAsyncResult> CallBack(IArgs args);
    }
}

