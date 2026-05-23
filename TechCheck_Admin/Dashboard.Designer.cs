namespace TechCheck_Admin
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnMenuDashboard = new Button();
            btnMenuPersoneller = new Button();
            btnMenuCihazlar = new Button();
            pnlSidebar = new Panel();
            label5 = new Label();
            label1 = new Label();
            pnlMain = new Panel();
            btnBeklemede = new Guna.UI2.WinForms.Guna2Button();
            btnTamirde = new Guna.UI2.WinForms.Guna2Button();
            btnTeslim = new Guna.UI2.WinForms.Guna2Button();
            btnTumu = new Guna.UI2.WinForms.Guna2Button();
            tabMain = new TabControl();
            Personeller = new TabPage();
            dgvPersoneller = new DataGridView();
            Cihazlar = new TabPage();
            dgvCihazlar = new DataGridView();
            pnlStats = new Panel();
            pnlStatKullanici = new Panel();
            lblKullaniciSayi = new Label();
            label2 = new Label();
            pnlStatCihaz = new Panel();
            lblCihazSayi = new Label();
            label3 = new Label();
            pnlTopBar = new Panel();
            btnCikis = new Button();
            lblBaslik = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            tabMain.SuspendLayout();
            Personeller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).BeginInit();
            Cihazlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCihazlar).BeginInit();
            pnlStats.SuspendLayout();
            pnlStatKullanici.SuspendLayout();
            pnlStatCihaz.SuspendLayout();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.BackColor = Color.FromArgb(60, 52, 137);
            btnMenuDashboard.FlatAppearance.BorderSize = 0;
            btnMenuDashboard.FlatStyle = FlatStyle.Flat;
            btnMenuDashboard.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnMenuDashboard.ForeColor = Color.White;
            btnMenuDashboard.Location = new Point(0, 106);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Size = new Size(198, 61);
            btnMenuDashboard.TabIndex = 4;
            btnMenuDashboard.Text = "📊  Dashboard";
            btnMenuDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuDashboard.UseVisualStyleBackColor = false;
            // 
            // btnMenuPersoneller
            // 
            btnMenuPersoneller.BackColor = Color.FromArgb(60, 52, 137);
            btnMenuPersoneller.FlatAppearance.BorderSize = 0;
            btnMenuPersoneller.FlatStyle = FlatStyle.Flat;
            btnMenuPersoneller.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnMenuPersoneller.ForeColor = Color.White;
            btnMenuPersoneller.Location = new Point(0, 173);
            btnMenuPersoneller.Name = "btnMenuPersoneller";
            btnMenuPersoneller.Size = new Size(198, 61);
            btnMenuPersoneller.TabIndex = 6;
            btnMenuPersoneller.Text = "\U0001faaa  Personeller";
            btnMenuPersoneller.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuPersoneller.UseVisualStyleBackColor = false;
            btnMenuPersoneller.Click += btnMenuPersoneller_Click;
            // 
            // btnMenuCihazlar
            // 
            btnMenuCihazlar.BackColor = Color.FromArgb(60, 52, 137);
            btnMenuCihazlar.FlatAppearance.BorderSize = 0;
            btnMenuCihazlar.FlatStyle = FlatStyle.Flat;
            btnMenuCihazlar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnMenuCihazlar.ForeColor = Color.White;
            btnMenuCihazlar.Location = new Point(0, 237);
            btnMenuCihazlar.Name = "btnMenuCihazlar";
            btnMenuCihazlar.Size = new Size(198, 61);
            btnMenuCihazlar.TabIndex = 7;
            btnMenuCihazlar.Text = "💻  Cihazlar";
            btnMenuCihazlar.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuCihazlar.UseVisualStyleBackColor = false;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(label5);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Controls.Add(btnMenuCihazlar);
            pnlSidebar.Controls.Add(btnMenuDashboard);
            pnlSidebar.Controls.Add(btnMenuPersoneller);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 804);
            pnlSidebar.TabIndex = 8;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(127, 119, 221);
            label5.Location = new Point(21, 95);
            label5.Name = "label5";
            label5.Size = new Size(160, 1);
            label5.TabIndex = 10;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(189, 74);
            label1.TabIndex = 9;
            label1.Text = "⚙ TechCheck Admin";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(btnBeklemede);
            pnlMain.Controls.Add(btnTamirde);
            pnlMain.Controls.Add(btnTeslim);
            pnlMain.Controls.Add(btnTumu);
            pnlMain.Controls.Add(tabMain);
            pnlMain.Controls.Add(pnlStats);
            pnlMain.Controls.Add(pnlTopBar);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(200, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1416, 804);
            pnlMain.TabIndex = 9;
            // 
            // btnBeklemede
            // 
            btnBeklemede.BorderRadius = 8;
            btnBeklemede.BorderThickness = 1;
            btnBeklemede.CustomizableEdges = customizableEdges1;
            btnBeklemede.DisabledState.BorderColor = Color.DarkGray;
            btnBeklemede.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBeklemede.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBeklemede.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBeklemede.FillColor = Color.FromArgb(60, 52, 137);
            btnBeklemede.Font = new Font("Segoe UI", 9F);
            btnBeklemede.ForeColor = Color.White;
            btnBeklemede.Location = new Point(289, 204);
            btnBeklemede.Name = "btnBeklemede";
            btnBeklemede.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnBeklemede.Size = new Size(100, 30);
            btnBeklemede.TabIndex = 9;
            btnBeklemede.Text = "Beklemede";
            btnBeklemede.Click += btnBeklemede_Click;
            // 
            // btnTamirde
            // 
            btnTamirde.BorderRadius = 8;
            btnTamirde.BorderThickness = 1;
            btnTamirde.CustomizableEdges = customizableEdges3;
            btnTamirde.DisabledState.BorderColor = Color.DarkGray;
            btnTamirde.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTamirde.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTamirde.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTamirde.FillColor = Color.FromArgb(60, 52, 137);
            btnTamirde.Font = new Font("Segoe UI", 9F);
            btnTamirde.ForeColor = Color.White;
            btnTamirde.Location = new Point(472, 204);
            btnTamirde.Name = "btnTamirde";
            btnTamirde.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnTamirde.Size = new Size(100, 30);
            btnTamirde.TabIndex = 8;
            btnTamirde.Text = "Tamirde";
            btnTamirde.Click += btnTamirde_Click;
            // 
            // btnTeslim
            // 
            btnTeslim.BorderRadius = 8;
            btnTeslim.BorderThickness = 1;
            btnTeslim.CustomizableEdges = customizableEdges5;
            btnTeslim.DisabledState.BorderColor = Color.DarkGray;
            btnTeslim.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTeslim.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTeslim.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTeslim.FillColor = Color.FromArgb(60, 52, 137);
            btnTeslim.Font = new Font("Segoe UI", 9F);
            btnTeslim.ForeColor = Color.White;
            btnTeslim.Location = new Point(656, 204);
            btnTeslim.Name = "btnTeslim";
            btnTeslim.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnTeslim.Size = new Size(100, 30);
            btnTeslim.TabIndex = 7;
            btnTeslim.Text = "Teslim Edildi";
            btnTeslim.Click += btnTeslim_Click;
            // 
            // btnTumu
            // 
            btnTumu.BorderRadius = 8;
            btnTumu.BorderThickness = 1;
            btnTumu.CustomizableEdges = customizableEdges7;
            btnTumu.DisabledState.BorderColor = Color.DarkGray;
            btnTumu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTumu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTumu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTumu.FillColor = Color.FromArgb(60, 52, 137);
            btnTumu.Font = new Font("Segoe UI", 9F);
            btnTumu.ForeColor = Color.White;
            btnTumu.Location = new Point(104, 204);
            btnTumu.Name = "btnTumu";
            btnTumu.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnTumu.Size = new Size(100, 30);
            btnTumu.TabIndex = 6;
            btnTumu.Text = "Tümü";
            btnTumu.Click += btnTumu_Click;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(Personeller);
            tabMain.Controls.Add(Cihazlar);
            tabMain.Dock = DockStyle.Bottom;
            tabMain.Location = new Point(0, 253);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1416, 551);
            tabMain.TabIndex = 4;
            tabMain.Tag = "";
            // 
            // Personeller
            // 
            Personeller.Controls.Add(dgvPersoneller);
            Personeller.Location = new Point(4, 34);
            Personeller.Name = "Personeller";
            Personeller.Padding = new Padding(3);
            Personeller.Size = new Size(1408, 513);
            Personeller.TabIndex = 1;
            Personeller.Text = "Personeller";
            Personeller.UseVisualStyleBackColor = true;
            // 
            // dgvPersoneller
            // 
            dgvPersoneller.BackgroundColor = Color.White;
            dgvPersoneller.BorderStyle = BorderStyle.None;
            dgvPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersoneller.Dock = DockStyle.Fill;
            dgvPersoneller.Location = new Point(3, 3);
            dgvPersoneller.Name = "dgvPersoneller";
            dgvPersoneller.ReadOnly = true;
            dgvPersoneller.RowHeadersWidth = 62;
            dgvPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersoneller.Size = new Size(1402, 507);
            dgvPersoneller.TabIndex = 1;
            // 
            // Cihazlar
            // 
            Cihazlar.Controls.Add(dgvCihazlar);
            Cihazlar.Location = new Point(4, 34);
            Cihazlar.Name = "Cihazlar";
            Cihazlar.Padding = new Padding(3);
            Cihazlar.Size = new Size(1224, 513);
            Cihazlar.TabIndex = 2;
            Cihazlar.Text = "Cihazlar";
            Cihazlar.UseVisualStyleBackColor = true;
            // 
            // dgvCihazlar
            // 
            dgvCihazlar.AllowUserToAddRows = false;
            dgvCihazlar.BackgroundColor = Color.White;
            dgvCihazlar.BorderStyle = BorderStyle.None;
            dgvCihazlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCihazlar.Dock = DockStyle.Fill;
            dgvCihazlar.Location = new Point(3, 3);
            dgvCihazlar.Name = "dgvCihazlar";
            dgvCihazlar.ReadOnly = true;
            dgvCihazlar.RowHeadersWidth = 62;
            dgvCihazlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCihazlar.Size = new Size(1218, 507);
            dgvCihazlar.TabIndex = 2;
            dgvCihazlar.CellClick += dgvCihazlar_CellClick;
            // 
            // pnlStats
            // 
            pnlStats.Controls.Add(pnlStatKullanici);
            pnlStats.Controls.Add(pnlStatCihaz);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Location = new Point(0, 55);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(1416, 127);
            pnlStats.TabIndex = 5;
            // 
            // pnlStatKullanici
            // 
            pnlStatKullanici.BackColor = Color.FromArgb(238, 237, 254);
            pnlStatKullanici.Controls.Add(lblKullaniciSayi);
            pnlStatKullanici.Controls.Add(label2);
            pnlStatKullanici.Location = new Point(163, 24);
            pnlStatKullanici.Name = "pnlStatKullanici";
            pnlStatKullanici.Size = new Size(188, 88);
            pnlStatKullanici.TabIndex = 2;
            // 
            // lblKullaniciSayi
            // 
            lblKullaniciSayi.AutoSize = true;
            lblKullaniciSayi.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullaniciSayi.ForeColor = Color.FromArgb(60, 52, 137);
            lblKullaniciSayi.Location = new Point(68, 28);
            lblKullaniciSayi.Name = "lblKullaniciSayi";
            lblKullaniciSayi.Size = new Size(0, 46);
            lblKullaniciSayi.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(83, 74, 183);
            label2.Location = new Point(44, 3);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 4;
            label2.Text = "Personeller";
            // 
            // pnlStatCihaz
            // 
            pnlStatCihaz.BackColor = Color.FromArgb(238, 237, 254);
            pnlStatCihaz.Controls.Add(lblCihazSayi);
            pnlStatCihaz.Controls.Add(label3);
            pnlStatCihaz.Location = new Point(500, 24);
            pnlStatCihaz.Name = "pnlStatCihaz";
            pnlStatCihaz.Size = new Size(188, 88);
            pnlStatCihaz.TabIndex = 3;
            // 
            // lblCihazSayi
            // 
            lblCihazSayi.AutoSize = true;
            lblCihazSayi.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCihazSayi.ForeColor = Color.FromArgb(60, 52, 137);
            lblCihazSayi.Location = new Point(72, 28);
            lblCihazSayi.Name = "lblCihazSayi";
            lblCihazSayi.Size = new Size(0, 46);
            lblCihazSayi.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(83, 74, 183);
            label3.Location = new Point(59, 3);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 5;
            label3.Text = "Cihazlar";
            // 
            // pnlTopBar
            // 
            pnlTopBar.Controls.Add(btnCikis);
            pnlTopBar.Controls.Add(lblBaslik);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1416, 55);
            pnlTopBar.TabIndex = 0;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(238, 237, 254);
            btnCikis.FlatAppearance.BorderColor = Color.FromArgb(127, 119, 221);
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ForeColor = Color.FromArgb(60, 52, 137);
            btnCikis.Location = new Point(1313, 12);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(100, 32);
            btnCikis.TabIndex = 1;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(60, 52, 137);
            lblBaslik.Location = new Point(7, 19);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(141, 26);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Genel Bakış";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 52, 137);
            ClientSize = new Size(1616, 804);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCheck Admin";
            Load += Dashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            Personeller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersoneller).EndInit();
            Cihazlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCihazlar).EndInit();
            pnlStats.ResumeLayout(false);
            pnlStatKullanici.ResumeLayout(false);
            pnlStatKullanici.PerformLayout();
            pnlStatCihaz.ResumeLayout(false);
            pnlStatCihaz.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnMenuDashboard;
        private Button btnMenuPersoneller;
        private Button btnMenuCihazlar;
        private Panel pnlSidebar;
        private Label label1;
        private Panel pnlMain;
        private Button btnCikis;
        private Panel pnlTopBar;
        private Label lblBaslik;
        private Panel pnlStatCihaz;
        private Label label3;
        private Panel pnlStatKullanici;
        private Label label2;
        private Label lblKullaniciSayi;
        private TabControl tabMain;
        private TabPage Personeller;
        private Label lblCihazSayi;
        private TabPage Cihazlar;
        private DataGridView dgvPersoneller;
        private DataGridView dgvCihazlar;
        private Panel pnlStats;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button btnBeklemede;
        private Guna.UI2.WinForms.Guna2Button btnTamirde;
        private Guna.UI2.WinForms.Guna2Button btnTeslim;
        private Guna.UI2.WinForms.Guna2Button btnTumu;
    }
}