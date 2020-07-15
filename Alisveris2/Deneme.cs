using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modeller;

namespace Alisveris2
{
    public class Deneme
    {
        Modeller.UrunleriYerlestir urunListesiGelicek = new UrunleriYerlestir();
        Modeller.UrunListesi listeTipi = new UrunListesi();
        void deneme()
        {
            var liste = listeTipi.UrunListe;
            liste = urunListesiGelicek.UrunleriListeyeEkle().UrunListe;
            
        }
    }
    
}