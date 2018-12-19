using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio1_Unidad_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return "<html><body>" +
                "<h1> UNIVERSIDAD AUTONOMA DE SANTO DOMINGO (UASD) </h1>" +
                "<p> DIPLOMADO, DESARROLLO WEB.. MVC. </p>" +
                 "</body></html>";
        }
        public string DiplomadoWeB()
        {
            return "<html><body>" +
                "<h1> ESTUDIANTES </h1>" +
                "<p>RONALD PEÑA NUÑEZ<br>" +
                "HENRY PICHARDO" +
                "EDUARD TORRES<br>" +
                "MARBEL BATISTA < br > " +
                  "YORDY DE LA CRUZ < br > " +
                    "EZEQUIAS GOMEZ < br > " +
                      "VICENTE MONTERO< br > " +
                        "MIGUEL REYES < br > " +
                          "URIEL MATOS < br > " +
                            "YERISON PEREZ < br > " +
                            "</body></html>" ;
        }
    }
}

        

    
