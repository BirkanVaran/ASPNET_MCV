using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVCTanisma.Models;

namespace WebApplicationMVCTanisma.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Listele()
        {
            List<Ogrenci> ogreList = Ogrenci.OgrencileriGetir();


            return View(ogreList);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Ogrenci ogr)
        {
            var tumOgrler = Ogrenci.OgrencileriGetir(); // Veritabanımız olmadığı için ID'yi kendimiz atıyoruz. Aşağıdaki satır bunun için.
            ogr.Id = tumOgrler.Count + 1;

            // Öğrenciyi ekleyelim.
            Ogrenci.OgrenciListesi.Add(ogr);

            // Ekleme yapıldıktan sonra Listele Action'ına yeniden yönlendirme yapalım ---> (RedirectToAction("Listele")
            return RedirectToAction("Listele");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            // Gelen Id>0 ise benim listemde onu bul ve View'e gönder.
            if (id > 0)
            {
                Ogrenci bulunanOgr = Ogrenci.OgrenciListesi.FirstOrDefault(x => x.Id == id);
                return View(bulunanOgr);
            }
            return View();
        }
        [HttpPost]
        public ActionResult Guncelle(Ogrenci ogr)
        {
            Ogrenci guncellenecekEskiOgr = Ogrenci.OgrenciListesi.FirstOrDefault(x => x.Id == ogr.Id);
            if (guncellenecekEskiOgr!=null)
            {
                // ÖĞrenciyi buldun. Bulduğun bu öğreniye yeni bilgilerini ata.
                // = işaretinin sağında Güncelle sayfasına girdiğimiz bilgiyi aldık ve bizdeki mevcut öğrenciye atadık.
                guncellenecekEskiOgr.Ad = ogr.Ad;
                guncellenecekEskiOgr.Soyad = ogr.Soyad;
                guncellenecekEskiOgr.DogumTarihi = ogr.DogumTarihi;
            }

            return RedirectToAction("Listele");
        }
    }
}