using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyOa.OpenApi
{
    public class ErrorCode
    {
        public enum General
        {
            /// <summary>
            /// 参数不合法错误
            /// </summary>
            invalid_params = 100,
            /// <summary>
            /// url不存在错误
            /// </summary>
            uri_not_found = 101,
        }
    }
}