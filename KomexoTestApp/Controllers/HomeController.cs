using KomexoTestApp.Models;
using MvcRazorToPdf;
using System.Web.Mvc;
using System.IO;
using System.Drawing;
using System;
using System.Drawing.Imaging;

namespace KomexoTestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult GeneratePDF(KomexoOrder model)
        {
            var img = Base64ToImage(model.Signature);
            img.Save(Server.MapPath("~") + "/Resources/Signature.png", ImageFormat.Png);
            return new PdfActionResult(model);
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

    }
}
