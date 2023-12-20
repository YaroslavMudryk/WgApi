namespace WgApi.Helpers.Extensions
{
    public static class StringUrlExtensions
    {
        public static string AddParamIfNotExist(this string url, string paramName, string paramValue)
        {
            if (string.IsNullOrEmpty(url) || url.Contains(paramName) || string.IsNullOrEmpty(paramValue))
                return url;

            return url + $"&{paramName}={paramValue}";
        }

        public static string AddParamIfNotExist(this  string url, string paramName, int? paramValue)
        {
            if (string.IsNullOrEmpty(url) || url.Contains(paramName) || !paramValue.HasValue)
                return url;

            return url + $"&{paramName}={paramValue}";
        }
    }
}
