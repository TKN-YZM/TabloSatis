using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeTeslimIP
{
    public partial class profil : System.Web.UI.Page
    {
        String kullaniciID;
        Database database = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["kullaniciID"] == null)
            {
                Response.Redirect("girisEkrani.aspx");
            }
            else
            {
                kullaniciID = Session["kullaniciID"].ToString();
            }
        }
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["kullaniciID"] = kullaniciID;

            Response.Redirect("anaSayfa.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e) //Güncelle Butonu
        {
            String e_posta = epostaTextBox.Text;
            String sifre = sifreTextBox.Text;
            bool sifreKontrol = database.sifreKontrol(sifre);
            bool epostaKontrol = database.epostaKontrol(e_posta);

            if(e_posta==String.Empty || sifre==String.Empty)
            {
                Label2.Text = "Girilmemiş alan bulunmaktadır";
            }
            else
            {
                if (!epostaKontrol)
                {
                    Label2.Text = "Lütfen geçerli bir eposta adresi giriniz";
                }
                else if (!sifreKontrol)
                {
                    Label2.Text = "Girilen Sifre Kurallara Uymamaktadır.(En az 8 karakter uzunlukta, en az 1 rakam ve 1 karakter içermeli)";
                }
                else
                {
                   String data=database.SifreGuncelleme(e_posta,sifre);
                    if (data != "tamam"){
                        Label2.Text = data.ToString();
                    }
                    else
                    {
                        Label2.Text = "Şifreniz başarıyla güncellenmiştir";
                        epostaTextBox.Text = "";
                        sifreTextBox.Text = "";
                    }
                }
            }

        }


        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Session["kullaniciID"] = kullaniciID;

            Response.Redirect("Sepetim.aspx");
        }

        protected void epostaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void sifreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}