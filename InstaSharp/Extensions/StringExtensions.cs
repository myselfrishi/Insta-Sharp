using System;
using System.Text.RegularExpressions;

namespace InstaSharp.Extensions
{
    public static class StringExtensions
    {
        public static String IncludeHashtags(this String str)
        {
            var replaced = Regex.Replace(str, @"(?:(?<=\s)|^)#(\w*[A-Za-z_]+\w*)$", "<a href=\"#\">#$1</a>");
            return replaced;
        }
    }
}