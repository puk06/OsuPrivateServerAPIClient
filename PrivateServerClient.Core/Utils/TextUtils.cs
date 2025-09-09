namespace PrivateServerClient.Core.Utils;

public static class TextUtils
{
    public static string CheckString(string text)
         => string.IsNullOrEmpty(text) ? "Unknown" : text;
}
