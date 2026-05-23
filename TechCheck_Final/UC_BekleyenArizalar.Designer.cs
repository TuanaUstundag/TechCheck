namespace TechCheck_Final
{
    partial class UC_BekleyenArizalar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUst = new Guna.UI2.WinForms.Guna2Panel();
            this.btnYenile = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlKart1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblToplam = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlKart2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHaftalik = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvBekleyenler = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlUst.SuspendLayout();
            this.pnlKart1.SuspendLayout();
            this.pnlKart2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenler)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.btnYenile);
            this.pnlUst.Controls.Add(this.guna2HtmlLabel1);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1249, 70);
            this.pnlUst.TabIndex = 0;
            // 
            // btnYenile
            // 
            this.btnYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYenile.BackColor = System.Drawing.Color.Transparent;
            this.btnYenile.BorderRadius = 18;
            this.btnYenile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYenile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYenile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYenile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYenile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(74)))), ((int)(((byte)(183)))));
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(1101, 15);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(125, 40);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(134, 22);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Bekleyen Arızalar";
            // 
            // pnlKart1
            // 
            this.pnlKart1.BorderRadius = 10;
            this.pnlKart1.Controls.Add(this.lblToplam);
            this.pnlKart1.Controls.Add(this.guna2HtmlLabel3);
            this.pnlKart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.pnlKart1.Location = new System.Drawing.Point(440, 3);
            this.pnlKart1.Name = "pnlKart1";
            this.pnlKart1.Size = new System.Drawing.Size(410, 95);
            this.pnlKart1.TabIndex = 1;
            // 
            // lblToplam
            // 
            this.lblToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.lblToplam.Location = new System.Drawing.Point(8, 25);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(24, 42);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "0";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(74)))), ((int)(((byte)(183)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(133, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(124, 22);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Toplam Bekleyen";
            // 
            // pnlKart2
            // 
            this.pnlKart2.BorderRadius = 10;
            this.pnlKart2.Controls.Add(this.lblHaftalik);
            this.pnlKart2.Controls.Add(this.guna2HtmlLabel2);
            this.pnlKart2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.pnlKart2.Location = new System.Drawing.Point(3, 3);
            this.pnlKart2.Name = "pnlKart2";
            this.pnlKart2.Size = new System.Drawing.Size(431, 95);
            this.pnlKart2.TabIndex = 2;
            // 
            // lblHaftalik
            // 
            this.lblHaftalik.BackColor = System.Drawing.Color.Transparent;
            this.lblHaftalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHaftalik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(52)))), ((int)(((byte)(137)))));
            this.lblHaftalik.Location = new System.Drawing.Point(12, 25);
            this.lblHaftalik.Name = "lblHaftalik";
            this.lblHaftalik.Size = new System.Drawing.Size(24, 42);
            this.lblHaftalik.TabIndex = 2;
            this.lblHaftalik.Text = "0";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(74)))), ((int)(((byte)(183)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(147, 3);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(114, 22);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Bu Hafta Gelen";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlKart2);
            this.flowLayoutPanel1.Controls.Add(this.pnlKart1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1249, 118);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // dgvBekleyenler
            // 
            this.dgvBekleyenler.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBekleyenler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBekleyenler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBekleyenler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBekleyenler.ColumnHeadersHeight = 40;
            this.dgvBekleyenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBekleyenler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBekleyenler.GridColor = System.Drawing.Color.Gray;
            this.dgvBekleyenler.Location = new System.Drawing.Point(0, 194);
            this.dgvBekleyenler.Name = "dgvBekleyenler";
            this.dgvBekleyenler.ReadOnly = true;
            this.dgvBekleyenler.RowHeadersVisible = false;
            this.dgvBekleyenler.RowHeadersWidth = 62;
            this.dgvBekleyenler.RowTemplate.Height = 40;
            this.dgvBekleyenler.Size = new System.Drawing.Size(1249, 804);
            this.dgvBekleyenler.TabIndex = 5;
            this.dgvBekleyenler.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBekleyenler.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBekleyenler.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBekleyenler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBekleyenler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBekleyenler.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBekleyenler.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvBekleyenler.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBekleyenler.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBekleyenler.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvBekleyenler.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBekleyenler.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBekleyenler.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvBekleyenler.ThemeStyle.ReadOnly = true;
            this.dgvBekleyenler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBekleyenler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBekleyenler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvBekleyenler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBekleyenler.ThemeStyle.RowsStyle.Height = 40;
            this.dgvBekleyenler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBekleyenler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_BekleyenArizalar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvBekleyenler);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_BekleyenArizalar";
            this.Size = new System.Drawing.Size(1249, 1001);
            this.Load += new System.EventHandler(this.UC_BekleyenArizalar_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.pnlKart1.ResumeLayout(false);
            this.pnlKart1.PerformLayout();
            this.pnlKart2.ResumeLayout(false);
            this.pnlKart2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBekleyenler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlUst;
        private Guna.UI2.WinForms.Guna2Button btnYenile;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel pnlKart1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblToplam;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel pnlKart2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHaftalik;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBekleyenler;
    }
}