using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechCheck_Final
{
    public partial class Dashboard : Form
    {
        // Bağlantı yolunu buraya sabitleyelim, her yerden rahatça kullanırız
        public string baglantiYolu = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mnjrosan;Integrated Security=True;Encrypt=True");

        public Dashboard()
        {
            InitializeComponent();
        }

        // Sayfaları panelin içine yerleştiren yardımcı metod
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_Anasayfa());
        }

        private void btnCihazlistesi_Click(object sender, EventArgs e)
        {
            addUserControl(new UC_CihazListesi());
        }

        

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            // Personel listesi veya personel ekleme sayfası
            addUserControl(new UC_Personeller());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Form açıldığında varsayılan olarak Anasayfa gelsin
            addUserControl(new UC_Anasayfa());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmKayitOl frm = new frmKayitOl();
            frm.ShowDialog();
        }

        private void btnBekleyenArizalar_Click(object sender, EventArgs e)
        {
            // Kendi panelinin adını yazıyorsun (Örn: panel1)
            pnlContainer.Controls.Clear();

            UC_BekleyenArizalar bekleyenSayfasi = new UC_BekleyenArizalar();
            bekleyenSayfasi.Dock = DockStyle.Fill;

            // Yine kendi panelinin adını yazıyorsun
            pnlContainer.Controls.Add(bekleyenSayfasi);
        }

        private void btnArizakyt_Click(object sender, EventArgs e)
        {
            
            pnlContainer.Controls.Clear();

         
            UC_YeniKayit yeniKayitSayfasi = new UC_YeniKayit();

        
            yeniKayitSayfasi.Dock = DockStyle.Fill;

            
            pnlContainer.Controls.Add(yeniKayitSayfasi);
        }
    }
}