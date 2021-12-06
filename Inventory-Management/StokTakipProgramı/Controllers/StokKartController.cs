using Microsoft.AspNetCore.Mvc;
using StokTakipProgramı.Entity;
using StokTakipProgramı.Models;
using StokTakipProgramı.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Controllers
{
    public class StokKartController : Controller
    {
        private IStokKartRepository repository;
        public StokKartController(IStokKartRepository _repository)
        {
            repository = _repository;
        }

       
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StokKart entity)
        {
            if (ModelState.IsValid)
            {
                repository.AddStokKart(entity);
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
        public IActionResult Update(StokKart stokKart)
        {
            if (ModelState.IsValid)
            {
                repository.UpdateStokKart(stokKart);
                return RedirectToAction("Islemler");
            }

            return View(stokKart);
        }

        public IActionResult Delete(int id)
        {
            repository.DeleteStokKart(id);
            return RedirectToAction("Islemler");
        }

    }
}
