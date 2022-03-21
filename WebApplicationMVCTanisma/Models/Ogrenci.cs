using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVCTanisma.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public static List<Ogrenci> OgrenciListesi { get; set; } = new List<Ogrenci>();



        public static List<Ogrenci> OgrencileriGetir()
        {
            if (OgrenciListesi.Count == 0)
            {
                OgrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(){Id=1, Ad="Betül",Soyad="Akşan",DogumTarihi=new DateTime(1992,11,14) },
                 new Ogrenci(){Id=2, Ad="Lale",Soyad="Laleoğlu",DogumTarihi=new DateTime(1990,11,14) },
                  new Ogrenci(){Id=3, Ad="Deniz",Soyad="Denizoğlu",DogumTarihi=new DateTime(1991,11,14) },
                   new Ogrenci(){Id=4, Ad="Sümbül",Soyad="Sümbüloğlu",DogumTarihi=new DateTime(1980,11,14) }
            };
            }

            return OgrenciListesi;
        }

        //public static bool OgrenciEkle(Ogrenci yeniOgr)
        //{
        //    OgrenciListesi.Add(yeniOgr);

        //    return true;
        //}

    }
}