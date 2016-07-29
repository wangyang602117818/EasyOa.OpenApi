using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Http;
using EasyOa.Common;
using EasyOa.Model;
using EasyOa.OpenApi.Models;
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
        public ResponseModel<WebFile> Md5(string code)
        {
            WebFile file = WebFile.Instance().GetByMd5(code);  //查询出file
            if (file == null) return new ResponseModel<WebFile>() { code = ErrorCode.General.record_not_exist };
            return new ResponseModel<WebFile>() { code = ErrorCode.General.success, result = file };
        }
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="file"></param>
        /// <param name="md5"></param>
        /// <returns></returns>
        [HttpPost]
        public ResponseModel<WebFile> UploadFile(HttpPostedFileBase file, string md5)
        {
            file.SaveAs(ConstData.UploadFilePath + file.FileName);
            Uri uri = HttpContext.Current.Request.Url;
            WebFile webFile = new WebFile()
                {
                    Scheme = uri.Scheme,
                    Host = uri.Host,
                    Port = uri.Port,
                    LocalPath = uri.LocalPath,
                    FileName = file.FileName,
                    FileSize = Math.Round(file.InputStream.Length / 1024 / 1024.0, 2) + "M",
                    MD5 = md5,
                    LogDate = DateTime.Now
                };
            webFile.Id = webFile.Insert();
            return new ResponseModel<WebFile>() { code = ErrorCode.General.success, result = webFile };
        }
        
    }
}
