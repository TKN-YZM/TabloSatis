using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeTeslimIP
{
    public partial class odemeSayfasi : System.Web.UI.Page
    {
       String kullaniciID;
       double fiyat; //ilk gelen
       double yeniFiyat; 

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["kullaniciID"] == null)
            {
                Response.Redirect("girisEkrani.aspx");
            }
            else
            {
                kullaniciID = Session["kullaniciID"].ToString();
                fiyat = Convert.ToDouble(Session["fiyat"]);
                yeniFiyat = fiyat;
                sepetTutar.Text = fiyat.ToString();
                evetRadio.Checked = true;
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["kullaniciID"] = kullaniciID;

            Response.Redirect("anaSayfa.aspx");
        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Session["kullaniciID"] = kullaniciID;

            Response.Redirect("profil.aspx");
        }
        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Session["kullaniciID"] = kullaniciID;

            Response.Redirect("Sepetim.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            if (DropDownList1.SelectedValue == "Şirket") // %13 kdv
            {
                yeniFiyat = yeniFiyat + (yeniFiyat * 13 / 100);
               
            }
            else if(DropDownList1.SelectedValue == "Bireysel")//%17 kdv
            {
                yeniFiyat = yeniFiyat + (yeniFiyat * 17 / 100);
            
            }

             if (DropDownList2.SelectedValue == "UPS")
            {
                yeniFiyat += 9.90D;
              
            }
            else if(DropDownList2.SelectedValue == "FEDEX")
            {
                yeniFiyat += 8.90D;
               
            }
             else if (DropDownList2.SelectedValue == "MNG")
            {
                yeniFiyat += 7.90D;
               
            }
            if (evetRadio.Checked)
            {
                yeniFiyat = yeniFiyat + (fiyat * 2 / 100);
            }
   
            toplamTutar.Text= yeniFiyat.ToString();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void evetRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}