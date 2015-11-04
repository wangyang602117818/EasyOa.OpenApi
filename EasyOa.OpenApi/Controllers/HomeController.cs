using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using EasyOa.Common;
using EasyOa.OpenApi.Models;
using System.Text;

namespace EasyOa.OpenApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Response.Write(SymmetricEncryptHelper.GenerateAESKey);
            Response.Write("<br>");
            string s1 = SymmetricEncryptHelper.AesEncode("aaaaaaaaaasdaddddaaaaaaaaaasdad", "R8pTD5PAmv34ApkeII4VmLd9hz4aCVqBZ/ZAYIVcGjo=");

            Response.Write(s1);
            Response.Write("<br>");
            Response.Write(SymmetricEncryptHelper.AesDecode(s1, "R8pTD5PAmv34ApkeII4VmLd9hz4aCVqBZ/ZAYIVcGjo="));
            //RSACryptoServiceProvider rsa1 = new RSACryptoServiceProvider();
            //string pub_rsa = Convert.ToBase64String(rsa1.ExportCspBlob(false));
            //string pri_rsa = Convert.ToBase64String(rsa1.ExportCspBlob(true));
            //Response.Write("<br>");
            //Response.Write("<br>");
            //string sa = "chacuo.net";
            //string pub =
            //    "BgIAAACkAABSU0ExAAQAAAEAAQDDFtvSX5OHcYDReoGZf2vtd9IsZbHZp+sh7qJAYZs2LsVghNa6aTRPVVj1zUYzxqVNcLjN0JWDfOeE9RuvjmyRR4xVDxqkNmucPdzbJc94kIKp9iiGNU1tXltnud5e6MpJMv1V/3VbBJbWJLDbNUOIX0UlwZuUqgT0FIAaoTqLhw==";
            //string pri = "BwIAAACkAABSU0EyAAQAAAEAAQDDFtvSX5OHcYDReoGZf2vtd9IsZbHZp+sh7qJAYZs2LsVghNa6aTRPVVj1zUYzxqVNcLjN0JWDfOeE9RuvjmyRR4xVDxqkNmucPdzbJc94kIKp9iiGNU1tXltnud5e6MpJMv1V/3VbBJbWJLDbNUOIX0UlwZuUqgT0FIAaoTqLh1Fkt3zF2P/Rbu7bNEYLJ1V02gTQaRCopFjulM9zvitpCvJ4n3CKduKAYradhNnz//eLa6kIotkqyouJxVMcjL/T6KoH/RaqRHQaIn7Ftvwf2OfDfLDaGHwknqWDJ8nlBYpwgFWRTSsJz+dT5oMjSRkU7ge3wlUmeaf+7g7/+ia14SoNWQ+/PK+4LeLQp4l7FPY8yk99LmAq3OdT5vqdK0fS5sGWnQvZoZ/gGXaoWSxzGoZSLqXMcBjdLIGmci8IkWdawdrxIWfFs6XVeVvSjxleux5/oM6hw43Ja6jLJPSkdTfRLmvYzGH2bbKwXrcpZaFYSVZhYE93wyW5yaakH1Ak7hYObAg5BtnFGmhWRvMUJt95lF3fWJHOMdthL9iwY/uCeQ0n8cYUTHgyzMbkPs5iaBJ4f4o9enSnEFZfkV6IQVztMdfjhuO6hufU8ueEMHEqNt41BvH+tkP11ErJ/75DN+3cjk4pH+jBNq1NMVFV0rDKSjk4waYsiHj3+taXACkMNVijy617cjAFuXSX1UsC5+Qy0bDQ8g6y8Kk3/eVRFDTH1xPiTCSvmFGtvGPSa+FVXxCZf6NqVN/gnRvBOBs=";
            //string sa_srecet = AsymmetricEncryptHelper.RSAEncode(sa, pub);
            //Response.Write(sa_srecet);
            //Response.Write("<br>");
            //Response.Write(AsymmetricEncryptHelper.RSADecode(sa_srecet, pri));
            return View();
        }

    }

}
