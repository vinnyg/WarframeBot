using System;

namespace DiscordSharpTest.Events.Extensions
{
    public static class ExtensionMethods
    {
        public static string Reverse(this string str)
        {
            var s = str.ToCharArray();
            Array.Reverse(s);
            return new string(s);
        }
    }
}
