namespace MHRSSistemi.UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEkle = new Button();
            txtBolumAdi = new TextBox();
            lblBolumAdi = new Label();
            lstBolumler = new ListBox();
            txtBolumAciklamasi = new TextBox();
            lblBolumAciklamasi = new Label();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnDigerSayfayaGec = new Button();
            pictureBoxLogo = new PictureBox();
            pictureBoxLogo2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo2).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.MediumSeaGreen;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(199, 309);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(110, 50);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtBolumAdi
            // 
            txtBolumAdi.BackColor = Color.LightGray;
            txtBolumAdi.Font = new Font("Segoe UI", 12F);
            txtBolumAdi.Location = new Point(199, 118);
            txtBolumAdi.Name = "txtBolumAdi";
            txtBolumAdi.Size = new Size(644, 29);
            txtBolumAdi.TabIndex = 1;
            // 
            // lblBolumAdi
            // 
            lblBolumAdi.AutoSize = true;
            lblBolumAdi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBolumAdi.ForeColor = Color.DarkRed;
            lblBolumAdi.Location = new Point(12, 126);
            lblBolumAdi.Name = "lblBolumAdi";
            lblBolumAdi.Size = new Size(90, 21);
            lblBolumAdi.TabIndex = 0;
            lblBolumAdi.Text = "Bölüm Adı";
            // 
            // lstBolumler
            // 
            lstBolumler.BackColor = Color.WhiteSmoke;
            lstBolumler.Font = new Font("Segoe UI", 12F);
            lstBolumler.ItemHeight = 21;
            lstBolumler.Location = new Point(199, 365);
            lstBolumler.Name = "lstBolumler";
            lstBolumler.Size = new Size(657, 172);
            lstBolumler.TabIndex = 4;
            // 
            // txtBolumAciklamasi
            // 
            txtBolumAciklamasi.BackColor = Color.LightGray;
            txtBolumAciklamasi.Font = new Font("Segoe UI", 12F);
            txtBolumAciklamasi.Location = new Point(199, 158);
            txtBolumAciklamasi.Multiline = true;
            txtBolumAciklamasi.Name = "txtBolumAciklamasi";
            txtBolumAciklamasi.Size = new Size(644, 145);
            txtBolumAciklamasi.TabIndex = 3;
            // 
            // lblBolumAciklamasi
            // 
            lblBolumAciklamasi.AutoSize = true;
            lblBolumAciklamasi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBolumAciklamasi.ForeColor = Color.DarkRed;
            lblBolumAciklamasi.Location = new Point(12, 158);
            lblBolumAciklamasi.Name = "lblBolumAciklamasi";
            lblBolumAciklamasi.Size = new Size(147, 21);
            lblBolumAciklamasi.TabIndex = 2;
            lblBolumAciklamasi.Text = "Bölüm Açıklaması";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(315, 309);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 50);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.RoyalBlue;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(431, 309);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 50);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnDigerSayfayaGec
            // 
            btnDigerSayfayaGec.BackColor = Color.DarkRed;
            btnDigerSayfayaGec.FlatStyle = FlatStyle.Flat;
            btnDigerSayfayaGec.ForeColor = Color.White;
            btnDigerSayfayaGec.Location = new Point(199, 543);
            btnDigerSayfayaGec.Name = "btnDigerSayfayaGec";
            btnDigerSayfayaGec.Size = new Size(657, 43);
            btnDigerSayfayaGec.TabIndex = 8;
            btnDigerSayfayaGec.Text = "Diğer Sayfaya Geç";
            btnDigerSayfayaGec.UseVisualStyleBackColor = false;
            btnDigerSayfayaGec.Click += btnGec_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.images;
            pictureBoxLogo.Location = new Point(12, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 9;
            pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxLogo2
            // 
            pictureBoxLogo2.Image = Properties.Resources.MHRS_Logo_1;
            pictureBoxLogo2.Location = new Point(199, 12);
            pictureBoxLogo2.Name = "pictureBoxLogo2";
            pictureBoxLogo2.Size = new Size(200, 100);
            pictureBoxLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo2.TabIndex = 10;
            pictureBoxLogo2.TabStop = false;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(864, 591);
            Controls.Add(lblBolumAdi);
            Controls.Add(txtBolumAdi);
            Controls.Add(lblBolumAciklamasi);
            Controls.Add(txtBolumAciklamasi);
            Controls.Add(lstBolumler);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnDigerSayfayaGec);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pictureBoxLogo2);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "MHRS - Bölüm Yönetimi";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtBolumAdi;
        private Label lblBolumAdi;
        private ListBox lstBolumler;
        private TextBox txtBolumAciklamasi;
        private Label lblBolumAciklamasi;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnDigerSayfayaGec;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxLogo2;
    }
}
