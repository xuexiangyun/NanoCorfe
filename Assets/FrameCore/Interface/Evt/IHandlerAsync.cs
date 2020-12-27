
using System.Threading.Tasks;

public interface IHandlerAsync: IHandler
{
    public new Task CallBack(IArgs args);
}
