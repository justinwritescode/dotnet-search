using System.Globalization;

namespace DotNet.Search.Extensions
{
    /// <summary>
    /// Formats an integer in an abbreviated form with a comma separator.
    /// </summary>
    public static class IntegerFormatExtensions
    {
        /// <summary>
        /// Formats an integer in an abbreviated form with a comma separator.
        /// </summary>
        /// <example>
        /// 1000 => 1K
        /// 1000000 => 1M
        /// </example>
        /// <param name="value">The integer to be formatted</param>
        /// <returns>The formatted string</returns>
        public static string ToAbbrString(this int value)
        {
            switch(value)
            {
                case var exp when (value > 999999):
                    return exp.ToString("0,,.#0M", CultureInfo.InvariantCulture);
                case var exp when (value > 999):
                    return exp.ToString("0,.#0K", CultureInfo.InvariantCulture);
                default:
                    return value.ToString();
            }
        }
    }
}
