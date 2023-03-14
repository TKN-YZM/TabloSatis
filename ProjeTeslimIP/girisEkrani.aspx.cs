using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace ProjeTeslimIP
{
    public partial class girisEkrani : System.Web.UI.Page
    {

        Database database = new Database();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String e_posta = epostaTextBox.Text;
            String sifre = sifreTextBox.Text;
            String gelenData = database.kullaniciSorgulama(e_posta, sifre);
            bool eposta_kontrol = database.epostaKontrol(e_posta);
            bool sifre_kontrol = database.sifreKontrol(sifre);

            if (e_posta == String.Empty || sifre == String.Empty)
            {
                Label2.Text = "İçeriği girilmemiş alan bulunmaktadır";
            }
            else if (!eposta_kontrol)
            {
                Label2.Text = "Lütfen geçerli bir E posta adresi giriniz";
            }
            else if (!sifre_kontrol)
            {
                Label2.Text = "Lütfen geçerli sifre giriniz";
            }
            else
            {
                if (gelenData == "veritabanı hatası" || gelenData == "kisi bulunamadi")
                {
                    Label2.Text = "Girilen bilgilere ait birisi bulunamadi";
                }
                else
                {
                    Session["kullaniciID"] = gelenData;
                    Response.Redirect("anaSayfa.aspx");
                }
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("kayitOl.aspx");
        }
    }
}