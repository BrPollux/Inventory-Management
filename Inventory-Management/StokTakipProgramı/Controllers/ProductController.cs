using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StokTakipProgramı.Entity;
using StokTakipProgramı.Models;
using StokTakipProgramı.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository ProductRepo;
        private IStokKartRepository StokKartRepo;
        private IDepoRepository DepoRepo;
        public ProductController(IProductRepository _productrepo, IStokKartRepository _stokkartrepo, IDepoRepository _deporepo)
        {
            ProductRepo = _productrepo;
            StokKartRepo = _stokkartrepo;
            DepoRepo = _deporepo;
        }
        public IActionResult Ekle()
        {
            return View(StokKartRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create(int id)
        {           
            ViewBag.Depolar = new SelectList(DepoRepo.GetAll(), "DepoId", "DepoAdi");
            ViewBag.StokKart = StokKartRepo.GetById(id);
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product entity,int id)
        {
          
            ViewBag.Depolar = new SelectList(DepoRepo.GetAll(), "DepoId", "DepoAdi");
            ViewBag.StokKart = StokKartRepo.GetById(id);
            if (ModelState.IsValid)
            {
                entity.StokKartId = id;
                ProductRepo.AddProduct(entity);
                return RedirectToAction("Islemler");
            }

            return View(entity);
        }

        public IActionResult Islemler(int? id)
        {
            ViewBag.Depo = new SelectList(DepoRepo.GetAll(), "DepoId", "DepoAdi");
            ViewBag.Depolar = DepoRepo.GetAll();
            ViewBag.StokKart = StokKartRepo.GetAll();

            if (id!=null)
            {
                int depoId = Convert.ToInt32(id);
                return View(ProductRepo.GetByDepoId(depoId));
            }
            else
            {
                return View(ProductRepo.GetAll());
            }
            
            
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var pd = ProductRepo.GetById(id);
            ViewBag.Depolar = new SelectList(DepoRepo.GetAll(), "DepoId", "DepoAdi");
            ViewBag.StokKart = StokKartRepo.GetById(Convert.ToInt32(pd.StokKartId));
            return View(ProductRepo.GetById(id));
        }
        [HttpPost]
        public IActionResult Update(Product product, int ad)
        {
            

            if (ModelState.IsValid)
            {             
                ProductRepo.UpdateProduct(product);
                return RedirectToAction("Islemler");
            }

            return View(product);
        }

        public IActionResult Delete(int id)
        {
            ProductRepo.DeleteProduct(id);
            return RedirectToAction("Islemler");
        }

        public IActionResult Rapor(int? id)
        {
            ViewBag.Depo = new SelectList(DepoRepo.GetAll(), "DepoId", "DepoAdi");
            ViewBag.Depolar = DepoRepo.GetAll();
            ViewBag.StokKart = StokKartRepo.GetAll();

            if (id != null)
            {
                int depoId = Convert.ToInt32(id);
                return View(ProductRepo.GetByDepoId(depoId));
            }
            else
            {
                return View(ProductRepo.GetAll());
            }
        }


    }
}
