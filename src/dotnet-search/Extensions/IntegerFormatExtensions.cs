using System.Globalization;

namespace DotNet.Search.Extensions
{
    public static class IntegerFormatExtensions
    {
        public static string ToAbbrString(this long value)
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
