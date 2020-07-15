using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modeller;
using System.Web.Services;

namespace Alisveris2
{
    public partial class Urunler : System.Web.UI.Page
    {
        Modeller.UrunleriYerlestir urunListesiGelicek = new UrunleriYerlestir();
        Modeller.UrunListesi listeTipi = new UrunListesi();
        Modeller.Sepet sepet = new Sepet();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var urunListe = listeTipi.UrunListe;
            urunListe = urunListesiGelicek.UrunleriListeyeEkle().UrunListe;
            int a = 0;
            for (int j = 0; j < urunListe.Count; j++)
            {
                System.Web.UI.HtmlControls.HtmlGenericControl container = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                container.Attributes.Add("class", "row");
                container.Style.Add(HtmlTextWriterStyle.Margin, "15px 0px 15px 0px");
                
                container.Attributes.Add("justify-content", "space-around");
                for (int i = 0; i < 3; i++)
                {
                    if (a<urunListe.Count)
                    {
                        System.Web.UI.HtmlControls.HtmlGenericControl disDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                        disDiv.Style.Add(HtmlTextWriterStyle.Width, "18rem");
                        disDiv.Attributes.Add("class", "card");
                        System.Web.UI.HtmlControls.HtmlGenericControl img = new System.Web.UI.HtmlControls.HtmlGenericControl("img");
                        img.Style.Add(HtmlTextWriterStyle.Height, "300px");
                        img.Attributes.Add("src", urunListe[a].resimYolu);
                        img.Attributes.Add("class", "card-img-top");
                        img.Attributes.Add("alt", urunListe[a].isim);
                        disDiv.Controls.Add(img);

                        System.Web.UI.HtmlControls.HtmlGenericControl icDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                        icDiv.Attributes.Add("class", "card-body");

                        System.Web.UI.HtmlControls.HtmlGenericControl baslik = new System.Web.UI.HtmlControls.HtmlGenericControl("h5");
                        baslik.Attributes.Add("class", "card-title");
                        baslik.InnerText = urunListe[a].isim;

                        System.Web.UI.HtmlControls.HtmlGenericControl yazi = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
                        yazi.Attributes.Add("class", "card-text");
                        yazi.InnerText = urunListe[a].aciklama;

                        System.Web.UI.HtmlControls.HtmlGenericControl buton = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
                        buton.Attributes.Add("href", "#");
                        buton.Attributes.Add("class", "btn btn-primary addBasket");
                        buton.Attributes.Add("numara", a.ToString());
                        buton.InnerText = "Sepete Ekle!";

                        icDiv.Controls.Add(baslik);
                        icDiv.Controls.Add(yazi);
                        icDiv.Controls.Add(buton);
                        disDiv.Controls.Add(icDiv);
                        disDiv.Style.Add(HtmlTextWriterStyle.Margin,"auto");
                        container.Controls.Add(disDiv);
                        a++;
                        
                    }
                }
                this.Controls.Add(container);
            }
            
        }

        public void SepeteEkle(int id)
        {
            var urunListe = listeTipi.UrunListe;
            urunListe = urunListesiGelicek.UrunleriListeyeEkle().UrunListe;
            Session.Add(id.ToString() + "_id", urunListe[id].urunID);
            Session.Add(id.ToString() + "_isim", urunListe[id].isim);
            Session.Add(id.ToString() + "_ucret", urunListe[id].ucret);
        }

        [WebMethod]
        public static string IdGetir(string id)
        {
            Urunler urn = new Urunler();
            urn.SepeteEkle(Convert.ToInt32(id));
            return id;
        }
        
    }
}