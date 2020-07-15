using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modeller;

namespace Alisveris2.Sayfalar
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Modeller.Musteri musteri = new Musteri();
            string numara = TextBox1.Text;

            MusteriDondur musteridondurecek = new MusteriDondur(numara);
            musteri = musteridondurecek.musteriElemani();
            
            if (musteri!=null)
            {
                Session.Add("MusteriIsim", musteri.isim);
                Session.Add("MusteriID", musteri.id);
                Session.Add("MusteriSoyisim", musteri.soyisim);
                Session.Add("MusteriNumara", musteri.numara);
                Session.Add("MusteriMail", musteri.mail);
                Response.Redirect("Urunler.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Kullanıcı Bulunamadı!');</script>");
            }


        }
    }
}