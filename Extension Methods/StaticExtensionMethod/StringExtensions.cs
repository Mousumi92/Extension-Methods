namespace StaticExtensionMethod
{
    static class StringExtensions
    {
        public static string Shorten(this string text, int length)
        {
            return text.Substring(0, length);
        }
    }
}
