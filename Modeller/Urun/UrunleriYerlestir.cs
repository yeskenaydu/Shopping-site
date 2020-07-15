using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baglanti;

namespace Modeller
{
     public class UrunleriYerlestir
    {
        UrunListesi liste = new UrunListesi();
        Baglanti.UrunleriDondur urunleriDondur;
        public UrunListesi UrunleriListeyeEkle()
        {
            urunleriDondur = new UrunleriDondur();
            DataTable UrunlerTablosu = new DataTable();
            UrunlerTablosu = urunleriDondur.ButunUrunleriDondur();
            for (int i = 0; i < UrunlerTablosu.Rows.Count; i++)
            {
                Urun urun = new Urun();
                urun.isim = UrunlerTablosu.Rows[i]["Isim"].ToString();
                urun.kategori = UrunlerTablosu.Rows[i]["Kategori"].ToString();
                urun.marka = UrunlerTablosu.Rows[i]["Marka"].ToString();
                urun.ucret = UrunlerTablosu.Rows[i]["Ucret"].ToString();
                urun.resimYolu = UrunlerTablosu.Rows[i]["Resim"].ToString();
                urun.aciklama = UrunlerTablosu.Rows[i]["Aciklama"].ToString();
                urun.urunID = Convert.ToInt32(UrunlerTablosu.Rows[i]["UrunId"].ToString());
                liste.UrunListe.Add(urun);
            }
            return liste;
        }

        public UrunListesi TeknolojiUrunleriListeyeEkle()
        {
            urunleriDondur = new UrunleriDondur();
            DataTable UrunlerTablosu = new DataTable();
            UrunlerTablosu = urunleriDondur.TeknolojiUtunleriDondur();
            for (int i = 0; i < UrunlerTablosu.Rows.Count; i++)
            {
                Urun urun = new Urun();
                urun.isim = UrunlerTablosu.Rows[i]["Isim"].ToString();
                urun.kategori = UrunlerTablosu.Rows[i]["Kategori"].ToString();
                urun.marka = UrunlerTablosu.Rows[i]["Marka"].ToString();
                urun.ucret = UrunlerTablosu.Rows[i]["Ucret"].ToString();
                urun.resimYolu = UrunlerTablosu.Rows[i]["Resim"].ToString();
                urun.aciklama = UrunlerTablosu.Rows[i]["Aciklama"].ToString();
                urun.urunID = Convert.ToInt32(UrunlerTablosu.Rows[i]["UrunId"].ToString());
                liste.UrunListe.Add(urun);
            }
            return liste;
        }

        public UrunListesi KitaplariListele()
        {
            urunleriDondur = new UrunleriDondur();
            DataTable UrunlerTablosu = new DataTable();
            UrunlerTablosu = urunleriDondur.KitapUrunleriDondur();
            for (int i = 0; i < UrunlerTablosu.Rows.Count; i++)
            {
                Urun urun = new Urun();
                urun.isim = UrunlerTablosu.Rows[i]["Isim"].ToString();
                urun.kategori = UrunlerTablosu.Rows[i]["Kategori"].ToString();
                urun.marka = UrunlerTablosu.Rows[i]["Marka"].ToString();
                urun.ucret = UrunlerTablosu.Rows[i]["Ucret"].ToString();
                urun.resimYolu = UrunlerTablosu.Rows[i]["Resim"].ToString();
                urun.aciklama = UrunlerTablosu.Rows[i]["Aciklama"].ToString();
                urun.urunID = Convert.ToInt32(UrunlerTablosu.Rows[i]["UrunId"].ToString());
                liste.UrunListe.Add(urun);
            }
            return liste;
        }

        public UrunListesi GiyimUrunleriListele()
        {
            urunleriDondur = new UrunleriDondur();
            DataTable UrunlerTablosu = new DataTable();
            UrunlerTablosu = urunleriDondur.GiyimUrunleriDondur();
            for (int i = 0; i < UrunlerTablosu.Rows.Count; i++)
            {
                Urun urun = new Urun();
                urun.isim = UrunlerTablosu.Rows[i]["Isim"].ToString();
                urun.kategori = UrunlerTablosu.Rows[i]["Kategori"].ToString();
                urun.marka = UrunlerTablosu.Rows[i]["Marka"].ToString();
                urun.ucret = UrunlerTablosu.Rows[i]["Ucret"].ToString();
                urun.resimYolu = UrunlerTablosu.Rows[i]["Resim"].ToString();
                urun.aciklama = UrunlerTablosu.Rows[i]["Aciklama"].ToString();
                urun.urunID = Convert.ToInt32(UrunlerTablosu.Rows[i]["UrunId"].ToString());
                liste.UrunListe.Add(urun);
            }
            return liste;
        }
    }
}
