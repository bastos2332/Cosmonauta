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

            ViewBag.Titulo = apodModel.APDOtitulo ;
            ViewBag.Url = apodModel.APDOurl ;
            ViewBag.Data = apodModel.APDOdata.ToLongDateString();
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