using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EasyOa.Common;
using EasyOa.Common.Properties;

namespace EasyOa.OpenApi.Models
{
    public class Person
    {
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources))]
        [StringLength(5, MinimumLength = 5, ErrorMessageResourceName = "StringLength", ErrorMessageResourceType = typeof(Resources))]
        public string Name { get; set; }

        //[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources))]
        [Range(10, 100, ErrorMessageResourceName = "Range", ErrorMessageResourceType = typeof(Resources))]
        public int? Age { get; set; }
    }
    public class Person1
    {
        public string N { get; set; }
        public int A { get; set; }
    }


}