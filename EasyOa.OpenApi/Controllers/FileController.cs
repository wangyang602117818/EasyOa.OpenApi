using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using EasyOa.Model;
using EasyOa.OpenApi.Models;
using EasyOa.OpenApi.Properties;
using Newtonsoft.Json;

namespace EasyOa.OpenApi.Controllers
{
    public class FileController : ApiController
    {
        /// <summary>
        /// 根据MD5查文件是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [HttpGet]
        public ApiResponse<WebFile> Md5(string code)
        {
            WebFile file = WebFile.Instance().GetByMd5(code);  //查询出file
            if (file == null) return new ApiResponse<WebFile>() { code = ResponseCode.record_not_exist };
            return new ApiResponse<WebFile>() { code = ResponseCode.success, result = file };
        }
        [HttpPost]
        public ApiResponse<WebFile> UploadFile(HttpPostedFileBase file)
        {

            return null;
        }
    }
}
