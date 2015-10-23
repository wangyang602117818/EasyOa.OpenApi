using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOa.OpenApi.Models
{
    /// <summary>
    /// api响应类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseModel<T>
    {
        public Enum code { get; set; }
        public string msg { get { return code.ToString(); } }
        public T result { get; set; }
    }
   
}
