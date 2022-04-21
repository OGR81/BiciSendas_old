using BiciSendas.Areas.Monitorizacion.Models.Incidencias;
using BiciSendas.Areas.Monitorizacion.Models.Sensores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BiciSendas.Areas.Monitorizacion.Controllers.Sensores
{
    [Area("Monitorizacion")]
    public class SensorController : Controller
    {
        // GET: SensorController
        public ActionResult Index()
        {
            SensorIndexVM model = new();
            model.Categorias = new();
            model.Categorias.Add(new SelectListItem { Value = "0", Text = "Todos" });
            model.Id = 0;

            model.Paginas = new();
            model.Paginas.Add(new SelectListItem { Value = "10", Text = "10" });
            model.Paginas.Add(new SelectListItem { Value = "20", Text = "20" });
            model.Paginas.Add(new SelectListItem { Value = "30", Text = "30" });
            model.NumPagina = 10;

            return View(model);
        }

        // GET: SensorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SensorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SensorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SensorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SensorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SensorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SensorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
