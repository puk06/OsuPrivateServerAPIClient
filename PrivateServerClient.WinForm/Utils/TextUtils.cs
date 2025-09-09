namespace PrivateServerClient.WinForm.Utils;

internal static class TextUtils
{
    internal static string CheckString(string text)
         => string.IsNullOrEmpty(text) ? "Unknown" : text;
}
