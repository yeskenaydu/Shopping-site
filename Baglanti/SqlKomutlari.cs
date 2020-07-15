using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baglanti
{
    class SqlKomutlari
    {
        public string ButunElemanlar = "Select * from urun";
        public string ElektronikElemanlar = "Select * from urun where kategori='Elektronik'";
        public string GiyimElemanlar = "Select * from urun where kategori='Giyim'";
        public string KitapElemanlar = "Select * from urun where kategori='Kitap'";
        public string ButunMusteriler = "Select * from musteri";
        public string Kategoriler = "select Kategori,Count(Isim) as Sayi from Urun group by Kategori";

        public SqlCommand Musteri(string numara)
        {
            string musteriDondur = "Select * from Musteri where Numara=@numara";
            SqlCommand komut = new SqlCommand(musteriDondur);
            komut.Parameters.AddWithValue("@numara", numara);
            return komut;
        }
    }
}
