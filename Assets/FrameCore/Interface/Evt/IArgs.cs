
namespace NanoCorfe 
{
    public interface IArgs
    {
        EventType eventType { get; }
        IToken token { get; }
        object[] datas { get; }
        public void InitArgs(EventType type, IToken token, object[] datas);
    }

}
