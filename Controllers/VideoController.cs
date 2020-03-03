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
        public ActionResult Agregar(int idVideo, string Titulo, int numRepro,string urll)
        {

            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo",idVideo));
            Parametros.Add(new SqlParameter("@Titulo",Titulo));
            Parametros.Add(new SqlParameter("@numRepro", numRepro));
            Parametros.Add(new SqlParameter("@urll", urll));
            BaseHelper.ejecutarSentencia("INSERT INTO Video VALUES(@idVideo,@Titulo,@numRepro,@urll)",CommandType.Text,Parametros);

            return View();
        }
        public ActionResult EliminarVideo()
        {

            return View();
        }
        [HttpPost]
        public ActionResult EliminarVideo(int idVideo)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo",idVideo));
            //preg delete
            BaseHelper.ejecutarSentencia("DELETE from Video where @idVideo=idVideo",CommandType.Text,Parametros);
            return View();
        }
        public ActionResult ModificarVideo()
        {

            return View();
        }
         [HttpPost]
        public ActionResult ModificarVideo(int idVideo,string Titulo,int numRepro,string urll)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));
            Parametros.Add(new SqlParameter("@Titulo", Titulo));
            Parametros.Add(new SqlParameter("@numRepro", numRepro));
            Parametros.Add(new SqlParameter("@urll", urll));
            //preguntar lo del where
            BaseHelper.ejecutarSentencia("UPDATE Video (@idVideo,@Titulo,@numRepro,@urll)", CommandType.Text, Parametros);
            return View();
        }
         
    }
}
