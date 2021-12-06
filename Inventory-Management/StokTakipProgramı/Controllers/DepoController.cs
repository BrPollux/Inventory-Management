using Microsoft.AspNetCore.Mvc;
using StokTakipProgramı.Entity;
using StokTakipProgramı.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Controllers
{
    public class DepoController : Controller
    {
        private IDepoRepository repository;
        public DepoController(IDepoRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Depo entity)
        {
            if (ModelState.IsValid)
            {
                repository.AddDepo(entity);
                return RedirectToAction("Islemler");
            }

            return View(entity);
        }

        public IActionResult Islemler()
        {
            return View(repository.GetAll());
        }

        public IActionResult Rapor()
        {
            return View(repository.GetAll());
        }
        public IActionResult Update(int id)
        {

            return View(repository.GetById(id));
        }
        [HttpPost]
        public IActionResult Update(Depo entity)
        {
            if (ModelState.IsValid)
            {
                repository.UpdateDepo(entity);
                return RedirectToAction("Islemler");
            }

            return View(entity);
        }

        public IActionResult Delete(int id)
        {
            repository.DeleteDepo(id);
            return RedirectToAction("Islemler");
        }
    }
}
