using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class UC_YeniKayit : UserControl
    {
        // Veritabanı bağlantı yolu
        private readonly string baglantiYolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=False;";

        public UC_YeniKayit()
        {
            InitializeComponent();

            // DPI kaymalarını önlemek için yapıcı metoda ekledim
            this.AutoScaleMode = AutoScaleMode.None;
            this.AutoSize = false;
        }

        private void UC_YeniKayit_Load(object sender, EventArgs e)
        {
            
            TeknisyenleriYukle();
        }

        public void TeknisyenleriYukle()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    baglanti.Open();

                    // Sırf rol isminden dolayı takılmasın diye hem 'Teknisyen' hem 'teknisyen' durumunu kapsayacak sorgu koydum:
                    string sorgu = "SELECT Id, KullaniciAdi FROM Kullanicilar WHERE LOWER(KullaniciRolu) = 'teknisyen'";

                    using (SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null && dt.Rows.Count > 0)
                        {
                            // WinForms için en kararlı ComboBox veri bağlama sırası:
                            cmbPersoneller.DataSource = null;
                            cmbPersoneller.DisplayMember = "KullaniciAdi";
                            cmbPersoneller.ValueMember = "KullaniciAdi";
                            cmbPersoneller.DataSource = dt;

                            cmbPersoneller.SelectedIndex = -1; // İlk açılışta boş seçili gelsin
                        }
                        else
                        {
                            // Eğer bu uyarı gelirse veritabanındaki Kullanicilar tablosuna girip elle Rolü 'Teknisyen' olan bir kullanıcı eklemelisin kanka.
                            MessageBox.Show("Sistemde 'Teknisyen' rolüne sahip hiçbir kullanıcı bulunamadı!\nLütfen önce personel listesinden teknisyen ekleyin.", "Kullanıcı Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teknisyenler yüklenirken BAĞLANTI HATASI oluştu:\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Eksik alan kontrolü
            if (string.IsNullOrWhiteSpace(txtMusteriAd.Text) || cmbPersoneller.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Müşteri Adını yazın ve cihazı tamir edecek Teknisyeni seçin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    baglanti.Open();

                    string sorgu = @"INSERT INTO Cihazlar (MusteriAd, CihazModel, SeriNo, Ariza, Durum, KayitTarihi, AtananPersonel) 
                                     VALUES (@musteri, @model, @seri, @ariza, @durum, @tarih, @personel)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@musteri", txtMusteriAd.Text.Trim());
                        komut.Parameters.AddWithValue("@model", string.IsNullOrWhiteSpace(txtCihazModel.Text) ? "Belirtilmedi" : txtCihazModel.Text.Trim());
                        komut.Parameters.AddWithValue("@seri", string.IsNullOrWhiteSpace(txtSeriNo.Text) ? "Yok/Belirtilmedi" : txtSeriNo.Text.Trim());
                        komut.Parameters.AddWithValue("@ariza", string.IsNullOrWhiteSpace(txtAriza.Text) ? "Arıza belirtilmedi." : txtAriza.Text.Trim());

                        // Durum combobox'ı boşsa varsayılan olarak 'Yeni' atıyoruz
                        komut.Parameters.AddWithValue("@durum", (cmbDurum.Text != null && cmbDurum.Text != "") ? cmbDurum.Text : "Yeni");
                        komut.Parameters.AddWithValue("@tarih", DateTime.Now);

                        // ComboBox'tan seçilen personel adını alıyoruz
                        komut.Parameters.AddWithValue("@personel", cmbPersoneller.SelectedValue.ToString());

                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cihaz kaydı başarıyla sisteme işlendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cihaz kaydedilirken bir hata oluştu:\n\n" + ex.Message, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            // TextBox'ları temizle
            txtMusteriAd.Clear();
            txtCihazModel.Clear();
            txtSeriNo.Clear();
            txtAriza.Clear();

            // Seçimleri sıfırla
            if (cmbPersoneller.Items.Count > 0) cmbPersoneller.SelectedIndex = -1;
            if (cmbDurum.Items.Count > 0) cmbDurum.SelectedIndex = -1;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}