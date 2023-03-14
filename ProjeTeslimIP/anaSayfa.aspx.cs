using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeTeslimIP
{
    public partial class anaSayfa : System.Web.UI.Page
    {
        Database database = new Database();
        String kullaniciID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullaniciID"] == null)
            {
                Response.Redirect("girisEkrani.aspx");
            }
            else
            {
                String deger = database.urunGetir(); //urunler listeye aktarılıyor
                kullaniciID = Session["kullaniciID"].ToString(); // ID Değeri

                String baslik = database.UrunBilgileriListesi[0];
                String ozellik = database.UrunBilgileriListesi[1];
                String fiyat = Convert.ToString(database.UrunBilgileriListesi[2]);

                String baslikIki = database.UrunBilgileriListesi[3];
                String ozellikIki = database.UrunBilgileriListesi[4];
                String fiyatIki = Convert.ToString(database.UrunBilgileriListesi[5]);

                String baslikUc = database.UrunBilgileriListesi[6];
                String ozellikUc = database.UrunBilgileriListesi[7];
                String fiyatUc = Convert.ToString(database.UrunBilgileriListesi[8]);


                String baslikDort = database.UrunBilgileriListesi[9];
                String ozellikDort = database.UrunBilgileriListesi[10];
                String fiyatDort = Convert.ToString(database.UrunBilgileriListesi[11]);

                String baslikbes = database.UrunBilgileriListesi[12];
                String ozellikbes = database.UrunBilgileriListesi[13];
                String fiyatbes = Convert.ToString(database.UrunBilgileriListesi[14]);

                String baslikalti = database.UrunBilgileriListesi[15];
                String ozellialti = database.UrunBilgileriListesi[16];
                String fiyatalti = Convert.ToString(database.UrunBilgileriListesi[17]);

                String baslikyedi = database.UrunBilgileriListesi[18];
                String ozellikyedi = database.UrunBilgileriListesi[19];
                String fiyatayedi = Convert.ToString(database.UrunBilgileriListesi[20]);

                baslik1.Text = baslik;
                aciklama1.Text = ozellik;
                fiyat1.Text = fiyat;

                baslik2.Text = baslikIki;
                aciklama2.Text = ozellikIki;
                fiyat2.Text = fiyatIki;

                baslik3.Text = baslikUc;
                aciklama3.Text = ozellikUc;
                fiyat3.Text = fiyatUc;


                baslik4.Text = baslikDort;
                aciklama4.Text = ozellikDort;
                fiyat4.Text = fiyatDort;


                baslik5.Text = baslikbes;
                aciklama5.Text = ozellikbes;
                fiyat5.Text = fiyatbes;


                baslik6.Text = baslikalti;
                aciklama6.Text = ozellialti;
                fiyat6.Text = fiyatalti;


                baslik7.Text = baslikyedi;
                aciklama7.Text = ozellikyedi;
                fiyat7.Text = fiyatayedi;

            }

        }
        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Session["kullaniciID"] = kullaniciID;
            Response.Redirect("Sepetim.aspx");
        }
     

        protected void Button9_Click(object sender, EventArgs e)
        {
            String data = database.SepeteEkle(
                Convert.ToInt32(Session["kullaniciID"]),
                baslik3.Text,
                aciklama3.Text,
                Convert.ToInt32(fiyat3.Text)
               );
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            String data = database.SepeteEkle(
                Convert.ToInt32(Session["kullaniciID"]),
                baslik2.Text,
                aciklama2.Text,
                Convert.ToInt32(fiyat2.Text)
               );
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            String data = database.SepeteEkle(
                Convert.ToInt32(Session["kullaniciID"]),
                baslik4.Text,
                aciklama4.Text,
                Convert.ToInt32(fiyat4.Text)
               );
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            String data = database.SepeteEkle(
                Convert.ToInt32(Session["kullaniciID"]),
                baslik5.Text,
                aciklama5.Text,
                Convert.ToInt32(fiyat5.Text)
               );
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            String data = database.SepeteEkle(
                Convert.ToInt32(Session["kullaniciID"]),
                baslik6.Text,
                aciklama6.Text,
                Convert.ToInt32(fiyat6.Text)
               );
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            String data = database.SepeteEkle(
                Convert.ToInt32(Session["kullaniciID"]),
                baslik7.Text,
                aciklama7.Text,
                Convert.ToInt32(fiyat7.Text)
               );
        }

        protected void urunButton10_Click(object sender, EventArgs e)
        {

            String data = database.SepeteEkle(
                 Convert.ToInt32(Session["kullaniciID"]),
                 baslik1.Text,
                 aciklama1.Text,
                 Convert.ToInt32(fiyat1.Text)
                );
        }

        protected void Button120_Click(object sender, EventArgs e)
        {
            database.SepeteEkle(
                 Convert.ToInt32(Session["kullaniciID"]),
                 baslik1.Text,
                 aciklama1.Text,
                 Convert.ToInt32(fiyat1.Text)
                );
        }


        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["kullaniciID"] = kullaniciID;
            Response.Redirect("profil.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["kullaniciID"] = kullaniciID;
            Response.Redirect("anaSayfa.aspx");
        }
    }

}
