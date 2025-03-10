using Microsoft.AspNetCore.Mvc;

using CRUDCORE.Datos;
using CRUDCORE.Models;

namespace CRUDCORE.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _ContactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
            // La vista mostrara una lista de contactos
            var OLista = _ContactoDatos.Listar();

            return View(OLista);
        }
        public IActionResult Guardar()
        {
            // Metodo solo devuelve la vista
            return View();
        }
        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {
            // Metodo recibe el objeto para guardarlo en BD
            var respuesta = _ContactoDatos.Guardar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else 
                return View();
        }
    }
}
