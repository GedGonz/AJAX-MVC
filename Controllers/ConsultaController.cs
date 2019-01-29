using MVCAJAXA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAJAXA.Controllers
{
    public class ConsultaController : Controller
    {
        //
        // GET: /Consulta/

        List<PersonaModel> Persona = new List<PersonaModel>() { new PersonaModel() { Codigo = 1, Nombre = "Gerald", Apellido = "Gonzalez" }, new PersonaModel() { Codigo = 2, Nombre = "Helen", Apellido = "Morales" } };
       
        

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult _Consulta(int codigo) 
        {
            return PartialView("_Consulta", Persona.Where(x=>x.Codigo==codigo).ToList());

        }
    }
}
