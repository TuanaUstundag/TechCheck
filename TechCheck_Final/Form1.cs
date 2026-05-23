using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TechCheck_Final
{
    public partial class Form1 : Form
    {
        
        string baglantiYolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=False;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                try
                {
                    baglanti.Open();
                    // Yeni Users tablosuna göre sorgu
                    string sorgu = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@p1 AND Sifre=@p2";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                    SqlDataReader dr = komut.ExecuteReader();

                    if (dr.Read())
                    {
                        string rol = dr["KullaniciRolu"].ToString();
                        MessageBox.Show("Giriş Başarılı! Rolünüz: " + rol, "TechCheck",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Dashboard dsh = new Dashboard();
                        dsh.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                }
            }
        }

       
        private void lblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayitOl kayitFormu = new frmKayitOl();
            kayitFormu.Owner = this; 
            kayitFormu.Show();       
            this.Hide();             
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            string baglantiYolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=False";

            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                baglanti.Open();
                string sql = "SELECT COUNT(*) FROM Admins WHERE KullaniciAdi=@k1 AND Sifre=@s1";
                using (SqlCommand komut = new SqlCommand(sql, baglanti))
                {
                    komut.Parameters.AddWithValue("@k1", kullanici);
                    komut.Parameters.AddWithValue("@s1", sifre);
                    int sonuc = Convert.ToInt32(komut.ExecuteScalar());

                    if (sonuc > 0)
                    {
                        string adminExePath = @"C:\Users\MSI\source\repos\TuanaUstundag\TechCheck_Final\TechCheck_Admin\bin\Release\net8.0-windows7.0\TechCheck_Admin.exe";
                        System.Diagnostics.Process.Start(adminExePath);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı admin bilgileri!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}