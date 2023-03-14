using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeTeslimIP
{
    public partial class Sepetim : System.Web.UI.Page
    {
        Database database = new Database();
        int ID;
        double toplamFiyat = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullaniciID"] != null)
            {
                ID = Convert.ToInt32(Session["kullaniciID"]);
                sayfaVerileriniGizle();
                database.SepetVerileri(ID);


                if (database.SepetListesi.Count == 0)
                {
                    sayfaVerileriniGizle();
                }
                else if (database.SepetListesi.Count == 3)
                {
                    ilkPanel();
                    toplamFiyat = Convert.ToInt32(fiyat1.Text);
                }
                else if (database.SepetListesi.Count == 6)
                {
                    ilkPanel();
                    ikinciPanel();
                    toplamFiyat = Convert.ToInt32(fiyat1.Text) + Convert.ToInt32(fiyat2.Text); baslik4.Text = "";
                }
                else if (database.SepetListesi.Count == 9)
                {
                    ilkPanel();
                    ikinciPanel();
                    ucuncuPanel();
                    toplamFiyat = Convert.ToInt32(fiyat1.Text) + Convert.ToInt32(fiyat2.Text) + Convert.ToInt32(fiyat3.Text);
                }
                else if (database.SepetListesi.Count == 12)
                {
                    ilkPanel();
                    ikinciPanel();
                    ucuncuPanel();
                    dorduncuPanel();
                    toplamFiyat = Convert.ToInt32(fiyat1.Text) + Convert.ToInt32(fiyat2.Text) + Convert.ToInt32(fiyat3.Text) + Convert.ToInt32(fiyat4.Text);
                }
                else if (database.SepetListesi.Count == 15)
                {
                    ilkPanel();
                    ikinciPanel();
                    ucuncuPanel();
                    dorduncuPanel();
                    besinciPanel();
                    toplamFiyat = Convert.ToInt32(fiyat1.Text) + Convert.ToInt32(fiyat2.Text) + Convert.ToInt32(fiyat3.Text) + Convert.ToInt32(fiyat4.Text) + Convert.ToInt32(fiyat5.Text);
                }
                else
                {
                    ilkPanel();
                    ikinciPanel();
                    ucuncuPanel();
                    dorduncuPanel();
                    besinciPanel();
                    altinciPanel();
                    toplamFiyat = Convert.ToInt32(fiyat1.Text) + Convert.ToInt32(fiyat2.Text) + Convert.ToInt32(fiyat3.Text) + Convert.ToInt32(fiyat4.Text) + Convert.ToInt32(fiyat5.Text) + Convert.ToInt32(fiyat6.Text);
                }
                fiyat.Text = toplamFiyat.ToString();
            }
            else
            {
                Response.Redirect("girisEkrani.aspx");
            }
      
        }

        private void sayfaVerileriniGizle()
        {
            baslik1.Text = "";
            aciklama1.Text = "";
            Button9.Visible = false;
            fiyat1.Text = "";
            d1.Text = "";

            odemeButton.Visible = false;

            baslik2.Text = "";
            aciklama2.Text = "";
            urunButton2.Visible = false;
            fiyat2.Text = "";
            d2.Text = "";

            denemeee.Text = "";
            aciklama3.Text = "";
            urunButton3.Visible = false;
            fiyat3.Text = "";
            d3.Text = "";

            baslik4.Text = "";
            aciklama4.Text = "";
            urunButton4.Visible = false;
            fiyat4.Text = "";
            d4.Text = "";

            baslik5.Text = "";
            aciklama5.Text = "";
            urunButton5.Visible = false;
            fiyat5.Text = "";
            d5.Text = "";

            baslik6.Text = "";
            aciklama6.Text = "";
            urunButton6.Visible = false;
            fiyat6.Text = "";
            d6.Text = "";
        }

        private void ilkPanel()
        {

            baslik1.Text = database.SepetListesi[0];
            aciklama1.Text = database.SepetListesi[1];
            fiyat1.Text = Convert.ToString(database.SepetListesi[2]);
            d1.Text = "$";
            Button9.Visible = true;
            odemeButton.Visible = true;
        }

        private void ikinciPanel()
        {
            baslik2.Text = database.SepetListesi[3];
            aciklama2.Text = database.SepetListesi[4];
            fiyat2.Text = Convert.ToString(database.SepetListesi[5]);
            d2.Text = "$";
            urunButton2.Visible = true;

        }

        private void ucuncuPanel()
        {
            denemeee.Text = database.SepetListesi[6];
            aciklama3.Text = database.SepetListesi[7];
            fiyat3.Text = Convert.ToString(database.SepetListesi[8]);
            d3.Text = "$";
            urunButton3.Visible = true;
        }
        private void dorduncuPanel()
        {
            baslik4.Text = database.SepetListesi[9];
            aciklama4.Text = database.SepetListesi[10];
            fiyat4.Text = Convert.ToString(database.SepetListesi[11]);
            d4.Text = "$";
            urunButton4.Visible = true;
        }

        private void besinciPanel()
        {
            baslik5.Text = database.SepetListesi[12];
            aciklama5.Text = database.SepetListesi[13];
            fiyat5.Text = Convert.ToString(database.SepetListesi[14]);
            d5.Text = "$";
            urunButton5.Visible = true;
        }

        private void altinciPanel()
        {
            baslik6.Text = database.SepetListesi[15];
            aciklama6.Text = database.SepetListesi[16];
            fiyat6.Text = Convert.ToString(database.SepetListesi[17]);
            d6.Text = "$";
            urunButton6.Visible = true;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Session["fiyat"] = fiyat.Text;
            Session["kullaniciID"] = ID;
            Response.Redirect("odemeSayfasi.aspx");
        }


        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session["kullaniciID"] = ID;
            Response.Redirect("anaSayfa.aspx");
        }


        protected void urunButton1(object sender, EventArgs e)
        {

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            database.SepetSilmei(ID, baslik2.Text);
        }

        protected void Button10_Click1(object sender, EventArgs e)
        {
            database.SepetSilmei(ID, baslik4.Text);
        }


        protected void Button14_Click(object sender, EventArgs e)
        {
            database.SepetSilmei(ID, denemeee.Text);
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            database.SepetSilmei(ID, baslik5.Text);
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            database.SepetSilmei(ID, baslik6.Text);
        }

        protected void Button9_Click2(object sender, EventArgs e)
        {
            database.SepetSilmei(ID, baslik1.Text);
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["kullaniciID"] = ID;
            Response.Redirect("anaSayfa.aspx");
        }
        protected void Button13_Click(object sender, EventArgs e)
        {

        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }


        protected void Button10_Click(object sender, EventArgs e)
        {

        }
        protected void Button9_Click1(object sender, EventArgs e)
        {

        }

        protected void ilkurun_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Session["kullaniciID"] = ID;
            Response.Redirect("profil.aspx");
        }

    }


}
