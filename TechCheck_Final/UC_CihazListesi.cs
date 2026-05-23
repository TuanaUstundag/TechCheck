using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TechCheck_Final
{
    public partial class UC_CihazListesi : UserControl
    {
        string baglantiYolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=False";

        private int secilenId = -1;

        public UC_CihazListesi()
        {
            InitializeComponent();
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void UC_CihazListesi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        public void VerileriGetir(string aramaMetni = "")
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    string sorgu = @"SELECT Id, MusteriAd, CihazModel, SeriNo, Ariza, Durum, KayitTarihi, AtananPersonel FROM Cihazlar";

                    if (!string.IsNullOrEmpty(aramaMetni))
                    {
                        sorgu += " WHERE MusteriAd LIKE @p1 OR CihazModel LIKE @p1 OR SeriNo LIKE @p1";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    if (!string.IsNullOrEmpty(aramaMetni))
                        da.SelectCommand.Parameters.AddWithValue("@p1", "%" + aramaMetni + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCihazListesi.DataSource = null;
                    dgvCihazListesi.Columns.Clear();

                  
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn
                    {
                        Name = "colSec",
                        HeaderText = "Seç",
                        Width = 40
                    };
                    dgvCihazListesi.Columns.Add(chk);

                    
                    dgvCihazListesi.DataSource = dt;

                    GridFormatla();

                    secilenId = -1;
                    ButonlariGuncelle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri getirme hatası: " + ex.Message);
            }
        }

        private void GridFormatla()
        {
            if (dgvCihazListesi.Columns["Id"] != null) dgvCihazListesi.Columns["Id"].Visible = false;
            if (dgvCihazListesi.Columns["MusteriAd"] != null) dgvCihazListesi.Columns["MusteriAd"].HeaderText = "Müşteri Adı";
            if (dgvCihazListesi.Columns["CihazModel"] != null) dgvCihazListesi.Columns["CihazModel"].HeaderText = "Cihaz Modeli";
            if (dgvCihazListesi.Columns["SeriNo"] != null) dgvCihazListesi.Columns["SeriNo"].HeaderText = "Seri No";
            if (dgvCihazListesi.Columns["Ariza"] != null) dgvCihazListesi.Columns["Ariza"].HeaderText = "Arıza";
            if (dgvCihazListesi.Columns["Durum"] != null) dgvCihazListesi.Columns["Durum"].HeaderText = "Durum";
            if (dgvCihazListesi.Columns["KayitTarihi"] != null) dgvCihazListesi.Columns["KayitTarihi"].HeaderText = "Kayıt Tarihi";
            if (dgvCihazListesi.Columns["AtananPersonel"] != null) dgvCihazListesi.Columns["AtananPersonel"].HeaderText = "Atanan Personel";

            dgvCihazListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvCihazListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvCihazListesi.Columns[e.ColumnIndex].Name == "colSec")
            {
                dgvCihazListesi.CommitEdit(DataGridViewDataErrorContexts.Commit);
                bool tikliMi = Convert.ToBoolean(dgvCihazListesi.Rows[e.RowIndex].Cells["colSec"].Value);

                // Tekil seçim mantığı
                foreach (DataGridViewRow row in dgvCihazListesi.Rows)
                    row.Cells["colSec"].Value = false;

                if (tikliMi)
                {
                    dgvCihazListesi.Rows[e.RowIndex].Cells["colSec"].Value = true;
                    secilenId = Convert.ToInt32(dgvCihazListesi.Rows[e.RowIndex].Cells["Id"].Value);
                }
                else
                {
                    secilenId = -1;
                }
                ButonlariGuncelle();
            }
        }

        private void ButonlariGuncelle()
        {
            btnDuzenle.Enabled = secilenId > 0;
            btnSil.Enabled = secilenId > 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenId < 0) return;

            if (MessageBox.Show("Bu cihaz kaydını silmek istediğinize emin misiniz?", "TechCheck",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    try
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("DELETE FROM Cihazlar WHERE Id=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", secilenId);
                        komut.ExecuteNonQuery();
                        VerileriGetir();
                    }
                    catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            VerileriGetir(txtSearch.Text);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (secilenId < 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir cihaz seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            DataGridViewRow secilenSatir = null;
            foreach (DataGridViewRow row in dgvCihazListesi.Rows)
            {
                if (row.Cells["Id"].Value != null && Convert.ToInt32(row.Cells["Id"].Value) == secilenId)
                {
                    secilenSatir = row;
                    break;
                }
            }

            if (secilenSatir == null) return;

            string ad = secilenSatir.Cells["MusteriAd"].Value?.ToString() ?? "";
            string model = secilenSatir.Cells["CihazModel"].Value?.ToString() ?? "";
            string seri = secilenSatir.Cells["SeriNo"].Value?.ToString() ?? "";
            string ariza = secilenSatir.Cells["Ariza"].Value?.ToString() ?? "";
            string durum = secilenSatir.Cells["Durum"].Value?.ToString() ?? "";

            frmDuzenle frm = new frmDuzenle(secilenId, ad, model, seri, ariza, durum);
            frm.ShowDialog();

            VerileriGetir(); 
        }
    }
}