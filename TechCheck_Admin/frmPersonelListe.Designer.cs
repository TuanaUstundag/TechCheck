namespace TechCheck_Admin
{
    partial class frmPersonelListe
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvPersonel = new DataGridView();
            pnlUst = new Panel();
            btnSil = new Guna.UI2.WinForms.Guna2Button();
            btnDuzenle = new Guna.UI2.WinForms.Guna2Button();
            btnPersonelEkle = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            pnlAramaBarı = new Guna.UI2.WinForms.Guna2Panel();
            txtArama = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            pnlUst.SuspendLayout();
            pnlAramaBarı.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPersonel
            // 
            dgvPersonel.AllowUserToAddRows = false;
            dgvPersonel.BackgroundColor = Color.White;
            dgvPersonel.BorderStyle = BorderStyle.None;
            dgvPersonel.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 237, 254);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(83, 74, 183);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPersonel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersonel.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(10, 5, 5, 5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(206, 203, 246);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(60, 52, 137);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPersonel.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonel.Dock = DockStyle.Bottom;
            dgvPersonel.EnableHeadersVisualStyles = false;
            dgvPersonel.GridColor = Color.FromArgb(230, 235, 240);
            dgvPersonel.Location = new Point(0, 144);
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.ReadOnly = true;
            dgvPersonel.RowHeadersVisible = false;
            dgvPersonel.RowHeadersWidth = 62;
            dgvPersonel.RowTemplate.Height = 45;
            dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonel.Size = new Size(878, 400);
            dgvPersonel.TabIndex = 3;
            // 
            // pnlUst
            // 
            pnlUst.BackColor = Color.FromArgb(60, 52, 137);
            pnlUst.Controls.Add(btnSil);
            pnlUst.Controls.Add(btnDuzenle);
            pnlUst.Controls.Add(btnPersonelEkle);
            pnlUst.Controls.Add(label1);
            pnlUst.Dock = DockStyle.Top;
            pnlUst.Location = new Point(0, 0);
            pnlUst.Name = "pnlUst";
            pnlUst.Size = new Size(878, 70);
            pnlUst.TabIndex = 7;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Transparent;
            btnSil.BorderColor = Color.White;
            btnSil.BorderRadius = 10;
            btnSil.BorderThickness = 1;
            btnSil.CustomBorderColor = Color.Transparent;
            btnSil.CustomizableEdges = customizableEdges1;
            btnSil.DisabledState.BorderColor = Color.DarkGray;
            btnSil.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSil.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSil.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSil.FillColor = Color.Transparent;
            btnSil.Font = new Font("Segoe UI", 9F);
            btnSil.ForeColor = Color.White;
            btnSil.Image = Properties.Resources.trash_empty;
            btnSil.Location = new Point(750, 20);
            btnSil.Name = "btnSil";
            btnSil.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSil.Size = new Size(116, 38);
            btnSil.TabIndex = 11;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.Transparent;
            btnDuzenle.BorderColor = Color.White;
            btnDuzenle.BorderRadius = 10;
            btnDuzenle.BorderThickness = 1;
            btnDuzenle.CustomBorderColor = Color.Transparent;
            btnDuzenle.CustomizableEdges = customizableEdges3;
            btnDuzenle.DisabledState.BorderColor = Color.DarkGray;
            btnDuzenle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDuzenle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDuzenle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDuzenle.FillColor = Color.Transparent;
            btnDuzenle.Font = new Font("Segoe UI", 9F);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Image = Properties.Resources.pencil;
            btnDuzenle.Location = new Point(592, 20);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDuzenle.Size = new Size(140, 38);
            btnDuzenle.TabIndex = 10;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnPersonelEkle
            // 
            btnPersonelEkle.BackColor = Color.Transparent;
            btnPersonelEkle.BorderColor = Color.White;
            btnPersonelEkle.BorderRadius = 10;
            btnPersonelEkle.BorderThickness = 1;
            btnPersonelEkle.CustomBorderColor = Color.Transparent;
            btnPersonelEkle.CustomizableEdges = customizableEdges5;
            btnPersonelEkle.DisabledState.BorderColor = Color.DarkGray;
            btnPersonelEkle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPersonelEkle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPersonelEkle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPersonelEkle.FillColor = Color.Transparent;
            btnPersonelEkle.Font = new Font("Segoe UI", 9F);
            btnPersonelEkle.ForeColor = Color.White;
            btnPersonelEkle.Image = Properties.Resources.user__1_;
            btnPersonelEkle.Location = new Point(379, 20);
            btnPersonelEkle.Name = "btnPersonelEkle";
            btnPersonelEkle.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPersonelEkle.Size = new Size(197, 38);
            btnPersonelEkle.TabIndex = 9;
            btnPersonelEkle.Text = "Personel Ekle";
            btnPersonelEkle.Click += btnPersonelEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(60, 52, 137);
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(223, 29);
            label1.TabIndex = 8;
            label1.Text = "👥  Personel Listesi";
            // 
            // pnlAramaBarı
            // 
            pnlAramaBarı.Controls.Add(txtArama);
            pnlAramaBarı.CustomizableEdges = customizableEdges9;
            pnlAramaBarı.Location = new Point(0, 70);
            pnlAramaBarı.Name = "pnlAramaBarı";
            pnlAramaBarı.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlAramaBarı.Size = new Size(878, 68);
            pnlAramaBarı.TabIndex = 8;
            // 
            // txtArama
            // 
            txtArama.BorderRadius = 10;
            txtArama.CustomizableEdges = customizableEdges7;
            txtArama.DefaultText = "";
            txtArama.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtArama.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtArama.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtArama.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtArama.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtArama.Font = new Font("Segoe UI", 9F);
            txtArama.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtArama.IconLeft = Properties.Resources.search;
            txtArama.Location = new Point(12, 8);
            txtArama.Margin = new Padding(4, 5, 4, 5);
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "Personel ara...";
            txtArama.SelectedText = "";
            txtArama.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtArama.Size = new Size(827, 46);
            txtArama.TabIndex = 9;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // frmPersonelListe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 544);
            Controls.Add(pnlAramaBarı);
            Controls.Add(pnlUst);
            Controls.Add(dgvPersonel);
            Name = "frmPersonelListe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Listesi";
            Load += frmPersonelListe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            pnlUst.ResumeLayout(false);
            pnlUst.PerformLayout();
            pnlAramaBarı.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvPersonel;
        private Panel pnlUst;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnlAramaBarı;
        private Guna.UI2.WinForms.Guna2TextBox txtArama;
        private Guna.UI2.WinForms.Guna2Button btnPersonelEkle;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button btnDuzenle;
    }
}