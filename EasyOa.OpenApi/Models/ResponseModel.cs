﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EasyOa.OpenApi.Models
{
    /// <summary>
    /// api响应类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseModel<T>
    {
        [JsonIgnore]
        public string url { get; set; }
        public Enum code { get; set; }
        public string msg { get; set; }
        public T result { get; set; }
    }

}
