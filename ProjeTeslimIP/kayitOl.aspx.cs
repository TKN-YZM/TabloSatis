using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
namespace ProjeTeslimIP
{
    public partial class kayitOl : System.Web.UI.Page
    {
        Database database = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kayitButton_Click(object sender, EventArgs e)
        {
           
             
        }

        protected void kayitButton_Click1(object sender, EventArgs e)
        {
            String isim = isimKayit.Text;
            String soyisim = soyisimKayit.Text;
            String eposta = epostaKayit.Text;
            String sifre = sifreKayit.Text;
            bool sifreKontrolu = database.sifreKontrol(sifre);
            bool epostaKontrol = database.epostaKontrol(eposta);

            if (isim == String.Empty || soyisim == String.Empty || eposta == String.Empty || sifre == String.Empty)
            {
                Label2.Text = "Eksik girilen alan bulunmaktadır";
            }
            else if (!sifreKontrolu)
            {
                Label2.Text = "Girilen Sifre Kurallara Uymamaktadır.(En az 8 karakter uzunlukta, en az 1 rakam ve 1 karakter içermeli)";
            }
            else if (!epostaKontrol)
            {
                Label2.Text = "Lütfen gerçek bir e posta adresi giriniz";
            }
            else
            {
                String gelenData = database.kullaniciKayit(isim, soyisim, eposta, sifre);
                if (gelenData == "tamam")
                {
                    Thread.Sleep(1000);
                    Response.Redirect("girisEkrani.aspx");
                }
                else
                {
                    Label2.Text = "E posta adresiniz sistemde kayıtlıdır";
                }
            }
        }
    }
 }
