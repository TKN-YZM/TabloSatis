using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ProjeTeslimIP
{

    public class Database //9 fonksiyon oluşturuldu 7 si veri tabanı 2 si kontrol (şifre,eposta)
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VJ0O2QUL\\SQLEXPRESS;Initial Catalog=webProje;Integrated Security=True");
        SqlDataReader dr;

        public List<dynamic> UrunBilgileriListesi = new List<dynamic>();
        public List<dynamic> SepetListesi = new List<dynamic>();

        public String kullaniciSorgulama(String isim, String sifre)
        {
            try
            {
                con.Open();
                String sorgu = "select * from KullaniciBilgileriYeni where Eposta=@eposta and sifre=@sifre";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@eposta", isim);
                komut.Parameters.AddWithValue("@sifre", sifre);
                dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    return dr["ID"].ToString();
                }
                else
                {
                    return "kisi bulunamadi";
                }
            }
            catch (Exception e)
            {

                return "veritabanı hatası";
            }
            finally
            {
                con.Close();
            }
        }
        public String kullaniciKayit(String isim, String soyisim, String eposta, String sifre)
        {
            try
            {
                con.Open();
                String sorgu = "insert into KullaniciBilgileriYeni(Isim,Soyisim,Eposta,sifre) values (@isim,@soyisim,@eposta,@sifre)";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@isim", isim);
                komut.Parameters.AddWithValue("@soyisim", soyisim);
                komut.Parameters.AddWithValue("@eposta", eposta);
                komut.Parameters.AddWithValue("@sifre", sifre);
                komut.ExecuteNonQuery();
                return "tamam";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        public String urunGetir()
        {
            try
            {

                con.Open();
                String sorgu = "select * from UrunBilgileri";
                SqlCommand komut = new SqlCommand(sorgu, con);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    UrunBilgileriListesi.Add(dr["UrunBaslik"]);
                    UrunBilgileriListesi.Add(dr["UrunAciklama"]);
                    UrunBilgileriListesi.Add(dr["UrunFiyat"]);

                }
                return "tamam";
            }
            catch (Exception)
            {
                return "hata";
            }
            finally
            {
                con.Close();
            }
        }

        public String SepetVerileri(int ID)
        {
            try
            {
                con.Open();
                String sorgu = "select * from Sepet where ID=@id";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", ID);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    SepetListesi.Add(dr["UrunBaslik"]);
                    SepetListesi.Add(dr["UrunAciklama"]);
                    SepetListesi.Add(dr["UrunFiyat"]);
                }
                return "basarili";

            }
            catch (Exception e)
            {
                return "veritabanı hatası";
            }
            finally
            {
                con.Close();
            }
        }

        public String SepeteEkle(int ID, String baslik, String aciklama, int fiyat)
        {
            try
            {
                con.Open();
                String sorgu = "insert into Sepet(ID,UrunBaslik,UrunAciklama,UrunFiyat) values (@id,@baslik,@aciklama,@fiyat)";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", ID);
                komut.Parameters.AddWithValue("@baslik", baslik);
                komut.Parameters.AddWithValue("@aciklama", aciklama);
                komut.Parameters.AddWithValue("@fiyat", fiyat);
                komut.ExecuteNonQuery();
                return "basarili";
            }
            catch (Exception e)
            {
                return "veritabanı hatası";
            }
            finally
            {
                con.Close();
            }
        }
        public String SepetSilmei(int ID, String urunBaslik)
        {
            try
            {
                con.Open();
                String sorgu = "delete Sepet where ID=@id and UrunBaslik=@baslik";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", ID);
                komut.Parameters.AddWithValue("@baslik", urunBaslik);
                dr = komut.ExecuteReader();

                return "tamam";
            }
            catch (Exception e)
            {

                return "veritabanı hatası";
            }
            finally
            {
                con.Close();
            }
        }
        public String SifreGuncelleme(String eposta,String yeniSifre)
        {
            try
            {
                con.Open();
                String sorgu = "update KullaniciBilgileriYeni set sifre=@sifre where Eposta=@id";
                SqlCommand komut = new SqlCommand(sorgu, con);
                komut.Parameters.AddWithValue("@id", eposta);
                komut.Parameters.AddWithValue("@sifre", yeniSifre);
                dr = komut.ExecuteReader();
                return "tamam";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        public bool sifreKontrol(String sifre)
        {
            int flag1 = 0;
            int flag2 = 0;
            int flag3 = 0;
            if (sifre.Length > 7)
            {
                flag1 = 1;
            }
            foreach (char x in sifre) //sifre kontrol sayı ve karakter içermesi
            {
                if (!char.IsNumber(x))
                {
                    flag2 = 1;
                }
                else if (char.IsNumber(x))
                {
                    flag3 = 1;
                }
            }
            if (flag1 == 1 && flag2 == 1 && flag3 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool epostaKontrol(String eposta)
        {
            bool kontrol = false;
            if (eposta.Contains("@") && eposta.Contains(".com") && eposta.Length > 10) //a@gmail.com=11.karakter
            {
                kontrol = true;
            }
            return kontrol;
        }
    }
}