using System;

namespace Notez.Shared.Extensions
{
    public static class DateTimeOffsetExtensions
    {
        public static string ToNaString(this DateTimeOffset? date, string format)
        {
            return date?.ToString(format) ?? "n/a";
        }
    }
}