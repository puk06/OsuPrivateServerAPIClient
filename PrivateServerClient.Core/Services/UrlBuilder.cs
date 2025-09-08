using PrivateServerClient.Core.Interfaces;
using System.Reflection;

namespace PrivateServerClient.Core.Services;

public class UrlBuilder : IUrlBuilder
{
    private string? _base;
    private string _path = "";
    private readonly Dictionary<string, object?> _pathParams = new();
    private readonly List<(string Key, object? Value)> _queries = new();
    private ArrayFormat _arrayFormat = ArrayFormat.Repeat;

    public IUrlBuilder WithBase(string baseUrl)
    {
        _base = baseUrl?.TrimEnd('/');
        return this;
    }

    public IUrlBuilder WithPath(string pathTemplate)
    {
        _path = pathTemplate ?? "";
        return this;
    }

    public IUrlBuilder AddPathParam(string name, object? value)
    {
        _pathParams[name] = value;
        return this;
    }

    public IUrlBuilder AddQuery(string name, object? value)
    {
        if (value is null) return this; // nullは付けない
        _queries.Add((name, value));
        return this;
    }

    public IUrlBuilder AddQuery(object anonymousObject)
    {
        if (anonymousObject is null) return this;
        foreach (var p in anonymousObject.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
        {
            var val = p.GetValue(anonymousObject);
            AddQuery(p.Name, val);
        }
        return this;
    }

    public IUrlBuilder SetArrayFormat(ArrayFormat format)
    {
        _arrayFormat = format;
        return this;
    }

    public string Build()
    {
        // パス置換
        string resolvedPath = _path;
        foreach (var kv in _pathParams)
        {
            string token = "{" + kv.Key + "}";
            string encoded = kv.Value is null ? "" : Uri.EscapeDataString(ConvertToString(kv.Value));
            resolvedPath = resolvedPath.Replace(token, encoded);
        }

        // 先頭/末尾のスラッシュ整理
        string fullPath = resolvedPath.StartsWith('/') ? resolvedPath : "/" + resolvedPath;

        // クエリ組み立て
        var query = BuildQueryString(_queries, _arrayFormat);

        // ベース + パス + クエリ
        if (string.IsNullOrWhiteSpace(_base))
        {
            return query.Length > 0 ? $"{fullPath}?{query}" : fullPath;
        }

        return query.Length > 0 ? $"{_base}{fullPath}?{query}" : $"{_base}{fullPath}";
    }

    private static string BuildQueryString(List<(string Key, object? Value)> items, ArrayFormat arrayFormat)
    {
        var parts = new List<string>();

        foreach (var (key, value) in items)
        {
            if (value is null) continue;

            // IEnumerable かつ string ではない場合は配列扱い
            if (value is System.Collections.IEnumerable enumerable && value is not string)
            {
                var vals = new List<string>();
                foreach (var v in enumerable)
                {
                    if (v is null) continue;
                    vals.Add(Uri.EscapeDataString(ConvertToString(v)));
                }

                switch (arrayFormat)
                {
                    case ArrayFormat.Repeat:
                        parts.AddRange(vals.Select(v => $"{Uri.EscapeDataString(key)}={v}"));
                        break;
                    case ArrayFormat.Comma:
                        parts.Add($"{Uri.EscapeDataString(key)}={string.Join(",", vals)}");
                        break;
                    case ArrayFormat.Brackets:
                        parts.AddRange(vals.Select(v => $"{Uri.EscapeDataString(key)}[]={v}"));
                        break;
                }
            }
            else
            {
                parts.Add($"{Uri.EscapeDataString(key)}={Uri.EscapeDataString(ConvertToString(value))}");
            }
        }

        return string.Join("&", parts);
    }

    private static string ConvertToString(object value)
    {
        return value switch
        {
            DateTime dt => dt.ToString("o"), // ISO8601
            DateTimeOffset dto => dto.ToString("o"),
            bool b => b ? "true" : "false",
            _ => Convert.ToString(value, System.Globalization.CultureInfo.InvariantCulture) ?? ""
        };
    }
}
