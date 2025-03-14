namespace MHRSSistemi.UI
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            txtHastaAdiSoyadi = new TextBox();
            lblHastaAdiSoyadi = new Label();
            lstRandevular = new ListBox();
            btnOlustur = new Button();
            btnZRaporuOlustur = new Button();
            lblMuayeneTarihi = new Label();
            lblDoktorAdiSoyadi = new Label();
            dtpMuayeneTarihi = new DateTimePicker();
            cmbDoktorAdiSoyadi = new ComboBox();
            txtHastaSikayeti = new TextBox();
            lblHastaSikayeti = new Label();
            pictureBoxLogo = new PictureBox();
            pictureBoxLogo2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo2).BeginInit();
            SuspendLayout();
            // 
            // txtHastaAdiSoyadi
            // 
            txtHastaAdiSoyadi.BackColor = Color.LightGray;
            txtHastaAdiSoyadi.Font = new Font("Segoe UI", 12F);
            txtHastaAdiSoyadi.Location = new Point(235, 128);
            txtHastaAdiSoyadi.Name = "txtHastaAdiSoyadi";
            txtHastaAdiSoyadi.Size = new Size(477, 29);
            txtHastaAdiSoyadi.TabIndex = 1;
            // 
            // lblHastaAdiSoyadi
            // 
            lblHastaAdiSoyadi.AutoSize = true;
            lblHastaAdiSoyadi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHastaAdiSoyadi.ForeColor = Color.DarkRed;
            lblHastaAdiSoyadi.Location = new Point(12, 136);
            lblHastaAdiSoyadi.Name = "lblHastaAdiSoyadi";
            lblHastaAdiSoyadi.Size = new Size(139, 21);
            lblHastaAdiSoyadi.TabIndex = 0;
            lblHastaAdiSoyadi.Text = "Hasta Adı Soyadı";
            // 
            // lstRandevular
            // 
            lstRandevular.BackColor = Color.WhiteSmoke;
            lstRandevular.Font = new Font("Segoe UI", 12F);
            lstRandevular.ItemHeight = 21;
            lstRandevular.Location = new Point(233, 479);
            lstRandevular.Name = "lstRandevular";
            lstRandevular.Size = new Size(479, 214);
            lstRandevular.TabIndex = 8;
            // 
            // btnOlustur
            // 
            btnOlustur.BackColor = Color.MediumSeaGreen;
            btnOlustur.FlatStyle = FlatStyle.Flat;
            btnOlustur.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOlustur.ForeColor = Color.White;
            btnOlustur.Location = new Point(233, 699);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(151, 55);
            btnOlustur.TabIndex = 9;
            btnOlustur.Text = "Randevu Oluştur";
            btnOlustur.UseVisualStyleBackColor = false;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // btnZRaporuOlustur
            // 
            btnZRaporuOlustur.BackColor = Color.RoyalBlue;
            btnZRaporuOlustur.FlatStyle = FlatStyle.Flat;
            btnZRaporuOlustur.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnZRaporuOlustur.ForeColor = Color.White;
            btnZRaporuOlustur.Location = new Point(527, 699);
            btnZRaporuOlustur.Name = "btnZRaporuOlustur";
            btnZRaporuOlustur.Size = new Size(185, 55);
            btnZRaporuOlustur.TabIndex = 10;
            btnZRaporuOlustur.Text = "Z Raporu Oluştur";
            btnZRaporuOlustur.UseVisualStyleBackColor = false;
            btnZRaporuOlustur.Click += btnZRaporu_Click;
            // 
            // lblMuayeneTarihi
            // 
            lblMuayeneTarihi.AutoSize = true;
            lblMuayeneTarihi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMuayeneTarihi.ForeColor = Color.DarkRed;
            lblMuayeneTarihi.Location = new Point(12, 176);
            lblMuayeneTarihi.Name = "lblMuayeneTarihi";
            lblMuayeneTarihi.Size = new Size(175, 21);
            lblMuayeneTarihi.TabIndex = 2;
            lblMuayeneTarihi.Text = "Hasta Muayene Tarihi";
            // 
            // lblDoktorAdiSoyadi
            // 
            lblDoktorAdiSoyadi.AutoSize = true;
            lblDoktorAdiSoyadi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDoktorAdiSoyadi.ForeColor = Color.DarkRed;
            lblDoktorAdiSoyadi.Location = new Point(12, 218);
            lblDoktorAdiSoyadi.Name = "lblDoktorAdiSoyadi";
            lblDoktorAdiSoyadi.Size = new Size(149, 21);
            lblDoktorAdiSoyadi.TabIndex = 4;
            lblDoktorAdiSoyadi.Text = "Doktor Adı Soyadı";
            // 
            // dtpMuayeneTarihi
            // 
            dtpMuayeneTarihi.BackColor = Color.LightGray;
            dtpMuayeneTarihi.Font = new Font("Segoe UI", 12F);
            dtpMuayeneTarihi.Location = new Point(235, 170);
            dtpMuayeneTarihi.Name = "dtpMuayeneTarihi";
            dtpMuayeneTarihi.Size = new Size(477, 29);
            dtpMuayeneTarihi.TabIndex = 3;
            // 
            // cmbDoktorAdiSoyadi
            // 
            cmbDoktorAdiSoyadi.BackColor = Color.LightGray;
            cmbDoktorAdiSoyadi.Font = new Font("Segoe UI", 12F);
            cmbDoktorAdiSoyadi.Location = new Point(234, 210);
            cmbDoktorAdiSoyadi.Name = "cmbDoktorAdiSoyadi";
            cmbDoktorAdiSoyadi.Size = new Size(478, 29);
            cmbDoktorAdiSoyadi.TabIndex = 5;
            // 
            // txtHastaSikayeti
            // 
            txtHastaSikayeti.BackColor = Color.LightGray;
            txtHastaSikayeti.Font = new Font("Segoe UI", 12F);
            txtHastaSikayeti.Location = new Point(234, 252);
            txtHastaSikayeti.Multiline = true;
            txtHastaSikayeti.Name = "txtHastaSikayeti";
            txtHastaSikayeti.Size = new Size(478, 221);
            txtHastaSikayeti.TabIndex = 7;
            // 
            // lblHastaSikayeti
            // 
            lblHastaSikayeti.AutoSize = true;
            lblHastaSikayeti.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHastaSikayeti.ForeColor = Color.DarkRed;
            lblHastaSikayeti.Location = new Point(12, 252);
            lblHastaSikayeti.Name = "lblHastaSikayeti";
            lblHastaSikayeti.Size = new Size(118, 21);
            lblHastaSikayeti.TabIndex = 6;
            lblHastaSikayeti.Text = "Hasta Şikayeti";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.images;
            pictureBoxLogo.Location = new Point(12, 27);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 11;
            pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxLogo2
            // 
            pictureBoxLogo2.Image = Properties.Resources.MHRS_Logo_1;
            pictureBoxLogo2.Location = new Point(237, 27);
            pictureBoxLogo2.Name = "pictureBoxLogo2";
            pictureBoxLogo2.Size = new Size(200, 100);
            pictureBoxLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo2.TabIndex = 12;
            pictureBoxLogo2.TabStop = false;
            // 
            // Form3
            // 
            BackColor = Color.White;
            ClientSize = new Size(724, 758);
            Controls.Add(lblHastaAdiSoyadi);
            Controls.Add(txtHastaAdiSoyadi);
            Controls.Add(lblMuayeneTarihi);
            Controls.Add(dtpMuayeneTarihi);
            Controls.Add(lblDoktorAdiSoyadi);
            Controls.Add(cmbDoktorAdiSoyadi);
            Controls.Add(lblHastaSikayeti);
            Controls.Add(txtHastaSikayeti);
            Controls.Add(lstRandevular);
            Controls.Add(btnOlustur);
            Controls.Add(btnZRaporuOlustur);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pictureBoxLogo2);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "MHRS - Randevu Yönetimi";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHastaAdiSoyadi;
        private Label lblHastaAdiSoyadi;
        private ListBox lstRandevular;
        private Button btnOlustur;
        private Button btnZRaporuOlustur;
        private Label lblMuayeneTarihi;
        private Label lblDoktorAdiSoyadi;
        private DateTimePicker dtpMuayeneTarihi;
        private ComboBox cmbDoktorAdiSoyadi;
        private TextBox txtHastaSikayeti;
        private Label lblHastaSikayeti;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxLogo2;
    }
}

