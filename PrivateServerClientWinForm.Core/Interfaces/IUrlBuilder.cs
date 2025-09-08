namespace PrivateServerClient.Core.Interfaces;

public enum ArrayFormat
{
    Repeat,     // ?tag=a&tag=b
    Comma,      // ?tag=a,b
    Brackets    // ?tag[]=a&tag[]=b
}

public interface IUrlBuilder
{
    IUrlBuilder WithBase(string baseUrl);
    IUrlBuilder WithPath(string pathTemplate);               // 例: "/users/{id}/orders/{orderId}"
    IUrlBuilder AddPathParam(string name, object? value);    // {name} を置換
    IUrlBuilder AddQuery(string name, object? value);        // null は無視
    IUrlBuilder AddQuery(object anonymousObject);            // プロパティを列挙して追加
    IUrlBuilder SetArrayFormat(ArrayFormat format);
    string Build();                                          // 完成URL
}
