using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPlantilla.Utilerias;


using System.Data;
using System.Data.SqlClient;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {

            //consultar datos
            ViewData["DataVideo"] = BaseHelper.ejecutarConsulta(
                                                          "select* from Video",
                                                          CommandType.Text);

            return View();
        }


        public ActionResult AgregarVideo()
        {     

            return View();
        }

        [HttpPost]
        public ActionResult Agregar(int idVideo, string Titulo, int NumRepro,string url)
        {

            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo",idVideo));
            Parametros.Add(new SqlParameter("@Titulo",Titulo));
            Parametros.Add(new SqlParameter("@numRepro", NumRepro));
            Parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("INSERT INTO Video VALUES(@idVideo,@Titulo,@numRepro,@url)",CommandType.Text,Parametros);

            return View();
        }
        [HttpPost]
        public ActionResult EliminarVideo()
        {
            return View();
        }
         [HttpPost]
        public ActionResult ModificarVideo()
        {
            return View();
        }
          [HttpPost]
        public ActionResult EliminarXReproduccion()
        {
            return View();
        }
    }
}
