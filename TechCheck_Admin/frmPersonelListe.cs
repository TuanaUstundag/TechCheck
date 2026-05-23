using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechCheck_Admin
{
    public partial class frmPersonelListe : Form
    {
        string baglantiYolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=False;";

        public frmPersonelListe()
        {
            InitializeComponent();
        }

        private void frmPersonelListe_Load(object sender, EventArgs e)
        {
            PersonelleriYukle();
        }

        private void PersonelleriYukle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                baglanti.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, KullaniciAdi, KullaniciRolu, Email, Maas, Telefon FROM Kullanicilar", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPersonel.DataSource = dt;

                // Görsel iyileştirmeler
                dgvPersonel.RowTemplate.Height = 40;
                dgvPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvPersonel.Columns["Id"] != null) dgvPersonel.Columns["Id"].Visible = false;
                if (dgvPersonel.Columns["KullaniciAdi"] != null) dgvPersonel.Columns["KullaniciAdi"].HeaderText = "Kullanıcı Adı";
                if (dgvPersonel.Columns["KullaniciRolu"] != null) dgvPersonel.Columns["KullaniciRolu"].HeaderText = "Rol";
                if (dgvPersonel.Columns["Maas"] != null) dgvPersonel.Columns["Maas"].HeaderText = "Maaş";
            }
        }


        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir kişi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvPersonel.SelectedRows[0].Cells["Id"].Value);

            frmPersonelDuzenle frm = new frmPersonelDuzenle();
            frm.PersonelId = id;
            frm.ShowDialog();

            PersonelleriYukle(); // Liste yenilensin
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir kişi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvPersonel.SelectedRows[0].Cells["Id"].Value);

            if (MessageBox.Show("Bu kişi silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM Kullanicilar WHERE Id=@id", baglanti);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.ExecuteNonQuery();
                }
                PersonelleriYukle();
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmKayitOl frm = new frmKayitOl();
            frm.ShowDialog();
            PersonelleriYukle(); // Liste yenilensin
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT Id, KullaniciAdi, KullaniciRolu, Email, Maas, Telefon FROM Kullanicilar WHERE KullaniciAdi LIKE @ara OR Email LIKE @ara", baglanti);
                da.SelectCommand.Parameters.AddWithValue("@ara", "%" + txtArama.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPersonel.DataSource = dt;
            }
        }
    }
}