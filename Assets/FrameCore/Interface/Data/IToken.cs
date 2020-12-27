
public struct TokenTag
{
    //是否是包 如果不是将不会判断tag
    bool pack;
    //-1为报头 0为报段 1为报尾
    int tag;
    //是否来自服务器
    bool server;
    //Token类型
    TokenType type;
    //Token命名*Delog
    string tokenName;
}
public interface IToken 
{
    public TokenTag tokenTag { get; }
    public object sender { get; }
    public object receiver { get; }
    public IData data { get; }
}
