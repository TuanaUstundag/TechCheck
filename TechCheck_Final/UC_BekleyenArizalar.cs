using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class UC_BekleyenArizalar : UserControl
    {
        // Veritabanı bağlantı yolu
        private readonly string baglantiYolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=False;";

        public UC_BekleyenArizalar()
        {
            InitializeComponent();

            // Windows %150 DPI ekranlarda nesnelerin sağa sola kaymasını ve büzüşmesini engeller
            this.AutoScaleMode = AutoScaleMode.None;
            this.AutoSize = false;
        }

        private void UC_BekleyenArizalar_Load(object sender, EventArgs e)
        {
            
            BekleyenleriListele();
        }

        public void BekleyenleriListele()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    baglanti.Open();

                    
                    string sorgu = @"
                SELECT 
                    Id,
                    MusteriAd AS [Müşteri],
                    CihazModel AS [Model],
                    SeriNo AS [Seri No],
                    Ariza AS [Arıza Tanımı],
                    Durum,
                    KayitTarihi AS [Geliş Tarihi]
                FROM Cihazlar
                WHERE LOWER(Durum) LIKE 'bek%' 
                   OR LOWER(Durum) = 'yeni'
                ORDER BY KayitTarihi DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Tabloyu tamamen tazeleyip verileri bağlıyoruz
                        dgvBekleyenler.DataSource = null;
                        dgvBekleyenler.AutoGenerateColumns = true;
                        dgvBekleyenler.DataSource = dt;
                    }

                    // Görsel ayarları tetikle
                    GridAyarla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bekleyen listesi yüklenirken hata oluştu:\n\n" + ex.Message,
                                "TechCheck Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridAyarla()
        {
            // Eğer tabloda SQL'den gelen sütunlar oluştuysa görsel ayarları uygula
            if (dgvBekleyenler.Columns.Count > 0)
            {
                if (dgvBekleyenler.Columns["Id"] != null)
                    dgvBekleyenler.Columns["Id"].Visible = false;

                dgvBekleyenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Uzun arıza tanımları hücreye sığmazsa alt satıra geçsin (Metni kaydır)
                dgvBekleyenler.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvBekleyenler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            // Yenile butonuna basıldığında listeyi tazele
            BekleyenleriListele();
        }
    }
}