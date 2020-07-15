using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Alisveris2.Sayfalar
{
    public partial class Sepet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl body = new System.Web.UI.HtmlControls.HtmlGenericControl("ul");
            body.Attributes.Add("class", "list - group");
            int i = 0;
            while (Session[i.ToString() + "_isim"] != null)
            {
                System.Web.UI.HtmlControls.HtmlGenericControl eleman = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                eleman.Attributes.Add("class", "list-group-item d-flex justify-content-between align-items-center");
                eleman.InnerText = Session[i.ToString() + "_Urun"].ToString();
                System.Web.UI.HtmlControls.HtmlGenericControl para = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
                para.Attributes.Add("class", "badge badge-primary badge-pill");
                //para.InnerText = Session[i.ToString() + "Ucret"].ToString();
                eleman.Style.Add(HtmlTextWriterStyle.Width, "1000px");
                eleman.Style.Add(HtmlTextWriterStyle.Margin, "auto");
                eleman.Controls.Add(para);
                body.Controls.Add(eleman);
                i++;
            }
            this.Controls.Add(body);
        }
    }
}