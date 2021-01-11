
using System;
using System.Threading.Tasks;
namespace NanoCorfe 
{
    public interface IHandlerAsync : IHandler
    {
        //推荐使用于I/O
        public new Task<IAsyncResult> CallBack(IArgs args);
    }
}

