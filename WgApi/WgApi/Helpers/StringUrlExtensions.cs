using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WgApi.Helpers
{
    public static class StringUrlExtensions
    {
        public static string AddParamIfNotExist(this string url, string paramName, string paramValue)
        {
            if (string.IsNullOrEmpty(url) || url.Contains(paramName))
                return url;

            return url + $"&{paramName}={paramValue}";
        }

    }
}
