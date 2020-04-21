using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace COSMONAUTA.WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DAL.Cad001ApodModel apodModel = new NASA.APDO().GetImagemDia();

            ViewBag.Titulo = apodModel.APDOtitulo;
            ViewBag.Url = apodModel.APDOurl;
            ViewBag.Data = apodModel.APDOdata.ToLongDateString();

            Models.Banner Banner = new Models.Banner();
            Banner.Titulo = apodModel.APDOtitulo;
            Banner.Categoria = "Ciência";
            Banner.Categoria = apodModel.APDOdata.ToLongDateString();
            Banner.URL = apodModel.APDOurl;

            ViewBag.Banner = Banner;
            return View();
        }


        public ActionResult ExibirNoticia()
        {
            string teste = ViewBag.Titulo;
            return View();
        }


        public void Teste()
        {
            Task.Delay(500).ContinueWith((task) =>
            {
                task.Start();
                Console.WriteLine("teste");
            });
        }

    }
}