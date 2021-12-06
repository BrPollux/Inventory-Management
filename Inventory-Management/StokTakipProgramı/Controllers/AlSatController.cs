using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StokTakipProgramı.Entity;
using StokTakipProgramı.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakipProgramı.Controllers
{  
    public class AlSatController : Controller
    {
        private IProductRepository ProductRepo;
        private IStokKartRepository StokKartRepo;
        private IDepoRepository DepoRepo;
        private IAlisRepository AlisRepo;
        private ISatisRepository SatisRepo;
        private ITransferRepository TransferRepo;
        
        public AlSatController(IProductRepository _productrepo, IStokKartRepository _stokkartrepo, IDepoRepository _deporepo, 
            IAlisRepository _alisrepo, ISatisRepository _satisrepo, ITransferRepository _transferrepo)
        {
            ProductRepo = _productrepo;
            StokKartRepo = _stokkartrepo;
            DepoRepo = _deporepo;
            AlisRepo = _alisrepo;
            SatisRepo = _satisrepo;
            TransferRepo = _transferrepo;
        }
        public IActionResult StokAl()
        {
            return View(StokKartRepo.GetAll());
        }

        public IActionResult StokSat()
        {
            ViewBag.Depo = new SelectList(DepoRepo.GetAll(), "DepoId", "DepoAdi");
            ViewBag.Depolar = DepoRepo.GetAll();
            ViewBag.StokKart = StokKartRepo.GetAll();
            return View(ProductRepo.GetAll());
        }

        public IActionResult StokTransfer()
        {
            ViewBag.Depo = new SelectList(DepoRepo.GetAll(), "DepoId", "DepoAdi");
            ViewBag.Depolar = DepoRepo.GetAll();
            ViewBag.StokKart = StokKartRepo.GetAll();
            return View(ProductRepo.GetAll());
        }

        [HttpGet]
        public IActionResult TransferYap(int id, int value, int depo)
        {
            var prd = ProductRepo.GetById(id);

            ViewBag.StokKart = StokKartRepo.GetById(prd.StokKartId);
            ViewBag.Depo = DepoRepo.GetById(Convert.ToInt32(prd.DepoId));
            ViewBag.Depolar = new SelectList(DepoRepo.GetAll(), "DepoId", "DepoAdi");
            return View(ProductRepo.GetById(id));
        }

        [HttpPost]
        public IActionResult TransferYap(Product entity, int id, int value, int depo)
        {

            ViewBag.Depo = DepoRepo.GetById(Convert.ToInt32(entity.DepoId));
            ViewBag.StokKart = StokKartRepo.GetById(entity.StokKartId);
            ViewBag.Depolar = new SelectList(DepoRepo.GetAll(), "DepoId", "DepoAdi");
            var dpo = DepoRepo.GetById(depo);
            if (ModelState.IsValid)
            {
                var stokKart = StokKartRepo.GetById(entity.StokKartId);
                var ndpo = DepoRepo.GetById(Convert.ToInt32(entity.DepoId));
                Transfer transfer = new Transfer();
                transfer.TStokKodu = Convert.ToString(stokKart.StokKodu);
                transfer.TStokAdı = stokKart.StokAdi;
                transfer.TransferMiktarı = entity.ProductAdet;
                transfer.EskiDepo = dpo.DepoAdi;
                transfer.YeniDepo = ndpo.DepoAdi;
                transfer.TransferTarihi = DateTime.Now;   
                               
                ProductRepo.UpdateProduct(entity);               
                TransferRepo.AddTransfer(transfer);
                return RedirectToAction("Rapor");
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult SatisYap(int id, int value)
        {
            var prd = ProductRepo.GetById(id);
            
            ViewBag.StokKart = StokKartRepo.GetById(prd.StokKartId);
            ViewBag.Depo = DepoRepo.GetById(Convert.ToInt32(prd.DepoId));
            return View(ProductRepo.GetById(id));
        }

        [HttpPost]
        public IActionResult SatisYap(Product entity,int id ,int value)
        {
                 
            ViewBag.Depo = DepoRepo.GetById(Convert.ToInt32(entity.DepoId));
            ViewBag.StokKart = StokKartRepo.GetById(entity.StokKartId);
            if (ModelState.IsValid)
            {
                var stokKart = StokKartRepo.GetById(entity.StokKartId);
                
                Satis satis = new Satis();
                satis.SStokKodu = Convert.ToString(stokKart.StokKodu);
                satis.SStokAdı = stokKart.StokAdi;
                satis.SatisMiktarı = entity.ProductAdet;
                satis.SBirimFiyat = stokKart.StokAlis;
                satis.SToplamFiyat = stokKart.StokAlis * entity.ProductAdet;
                satis.SatisTarihi = DateTime.Now;
                if (value == entity.ProductAdet)
                {
                    ProductRepo.DeleteProduct(entity.ProductId);
                }
                else
                {
                    entity.ProductAdet = value - entity.ProductAdet;
                    ProductRepo.UpdateProduct(entity);
                }
                
                SatisRepo.AddSatis(satis);
                return RedirectToAction("Rapor");
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult SatinAl(int id)
        {
            ViewBag.Depolar = new SelectList(DepoRepo.GetAll(), "DepoId", "DepoAdi");
            ViewBag.StokKart = StokKartRepo.GetById(id);
            return View();
        }

        [HttpPost]
        public IActionResult SatinAl(Product entity, int id)
        {

            ViewBag.Depolar = new SelectList(DepoRepo.GetAll(), "DepoId", "DepoAdi");
            ViewBag.StokKart = StokKartRepo.GetById(id);
            if (ModelState.IsValid)
            {
                var stokKart = StokKartRepo.GetById(id);
                Alis alis = new Alis();
                alis.AStokKodu = Convert.ToString(stokKart.StokKodu);
                alis.AStokAdı = stokKart.StokAdi;
                alis.AlisMiktarı = entity.ProductAdet;
                alis.ABirimFiyat = stokKart.StokAlis;
                alis.AToplamFiyat = stokKart.StokAlis * entity.ProductAdet;
                alis.AlisTarihi = DateTime.Now;
                entity.StokKartId = id;
                ProductRepo.AddProduct(entity);
                AlisRepo.AddAlis(alis);
                return RedirectToAction("Rapor");
            }

            return View(entity);
        }

        public IActionResult Rapor()
        {
            ViewBag.Alis = AlisRepo.GetAll();
            ViewBag.Satis = SatisRepo.GetAll();
            ViewBag.Transfer = TransferRepo.GetAll();

            return View();
        }
    }
}
