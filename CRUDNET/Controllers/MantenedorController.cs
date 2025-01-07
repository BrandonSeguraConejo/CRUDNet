using Microsoft.AspNetCore.Mvc;
using test.Models.Datos;
using test.Models;

namespace test.Controllers
{
    public class MantenedorController : Controller
    {

        ContactoDatos _ContactoDatos =new ContactoDatos();

        public IActionResult Listar()
        {
            var oLista = _ContactoDatos.Listar();
            return View(oLista);
           
        }
        public IActionResult Guardar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {
            if(!ModelState.IsValid)
                return View();

            var rpt= _ContactoDatos.Guardar(oContacto);

            if(rpt)
                return RedirectToAction("Listar");
            return View();
        }

    }
}
