namespace MHRSSistemi.UI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lstDoktorlar = new ListBox();
            lblDoktorTelefon = new Label();
            lblDoktorAdiSoyadi = new Label();
            txtDoktorAdiSoyadi = new TextBox();
            btnDigerSayfayaGec = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            mtxtDoktorTelefon = new MaskedTextBox();
            cmbBolum = new ComboBox();
            lblBolum = new Label();
            pictureBoxLogo = new PictureBox();
            pictureBoxLogo2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo2).BeginInit();
            SuspendLayout();
            // 
            // lstDoktorlar
            // 
            lstDoktorlar.BackColor = Color.WhiteSmoke;
            lstDoktorlar.Font = new Font("Segoe UI", 12F);
            lstDoktorlar.ItemHeight = 21;
            lstDoktorlar.Location = new Point(222, 293);
            lstDoktorlar.Name = "lstDoktorlar";
            lstDoktorlar.Size = new Size(802, 172);
            lstDoktorlar.TabIndex = 6;
            // 
            // lblDoktorTelefon
            // 
            lblDoktorTelefon.AutoSize = true;
            lblDoktorTelefon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDoktorTelefon.ForeColor = Color.DarkRed;
            lblDoktorTelefon.Location = new Point(34, 158);
            lblDoktorTelefon.Name = "lblDoktorTelefon";
            lblDoktorTelefon.Size = new Size(124, 21);
            lblDoktorTelefon.TabIndex = 2;
            lblDoktorTelefon.Text = "Doktor Telefon";
            // 
            // lblDoktorAdiSoyadi
            // 
            lblDoktorAdiSoyadi.AutoSize = true;
            lblDoktorAdiSoyadi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDoktorAdiSoyadi.ForeColor = Color.DarkRed;
            lblDoktorAdiSoyadi.Location = new Point(34, 121);
            lblDoktorAdiSoyadi.Name = "lblDoktorAdiSoyadi";
            lblDoktorAdiSoyadi.Size = new Size(149, 21);
            lblDoktorAdiSoyadi.TabIndex = 0;
            lblDoktorAdiSoyadi.Text = "Doktor Adı Soyadı";
            // 
            // txtDoktorAdiSoyadi
            // 
            txtDoktorAdiSoyadi.BackColor = Color.LightGray;
            txtDoktorAdiSoyadi.Font = new Font("Segoe UI", 12F);
            txtDoktorAdiSoyadi.Location = new Point(222, 118);
            txtDoktorAdiSoyadi.Name = "txtDoktorAdiSoyadi";
            txtDoktorAdiSoyadi.Size = new Size(644, 29);
            txtDoktorAdiSoyadi.TabIndex = 1;
            // 
            // btnDigerSayfayaGec
            // 
            btnDigerSayfayaGec.BackColor = Color.DarkRed;
            btnDigerSayfayaGec.FlatStyle = FlatStyle.Flat;
            btnDigerSayfayaGec.ForeColor = Color.White;
            btnDigerSayfayaGec.Location = new Point(222, 471);
            btnDigerSayfayaGec.Name = "btnDigerSayfayaGec";
            btnDigerSayfayaGec.Size = new Size(802, 43);
            btnDigerSayfayaGec.TabIndex = 10;
            btnDigerSayfayaGec.Text = "Diğer Sayfaya Geç";
            btnDigerSayfayaGec.UseVisualStyleBackColor = false;
            btnDigerSayfayaGec.Click += btnGec_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.RoyalBlue;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(454, 237);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 50);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Crimson;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(338, 237);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 50);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.MediumSeaGreen;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(222, 237);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(110, 50);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // mtxtDoktorTelefon
            // 
            mtxtDoktorTelefon.BackColor = Color.LightGray;
            mtxtDoktorTelefon.Font = new Font("Segoe UI", 12F);
            mtxtDoktorTelefon.Location = new Point(222, 155);
            mtxtDoktorTelefon.Mask = "(999) 000-0000";
            mtxtDoktorTelefon.Name = "mtxtDoktorTelefon";
            mtxtDoktorTelefon.Size = new Size(644, 29);
            mtxtDoktorTelefon.TabIndex = 3;
            // 
            // cmbBolum
            // 
            cmbBolum.BackColor = Color.LightGray;
            cmbBolum.Font = new Font("Segoe UI", 12F);
            cmbBolum.Location = new Point(222, 195);
            cmbBolum.Name = "cmbBolum";
            cmbBolum.Size = new Size(644, 29);
            cmbBolum.TabIndex = 5;
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBolum.ForeColor = Color.DarkRed;
            lblBolum.Location = new Point(34, 198);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(60, 21);
            lblBolum.TabIndex = 4;
            lblBolum.Text = "Bölüm";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.images;
            pictureBoxLogo.Location = new Point(34, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 11;
            pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxLogo2
            // 
            pictureBoxLogo2.Image = Properties.Resources.MHRS_Logo_1;
            pictureBoxLogo2.Location = new Point(222, 12);
            pictureBoxLogo2.Name = "pictureBoxLogo2";
            pictureBoxLogo2.Size = new Size(200, 100);
            pictureBoxLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo2.TabIndex = 12;
            pictureBoxLogo2.TabStop = false;
            // 
            // Form2
            // 
            BackColor = Color.White;
            ClientSize = new Size(1036, 519);
            Controls.Add(lblDoktorAdiSoyadi);
            Controls.Add(txtDoktorAdiSoyadi);
            Controls.Add(lblDoktorTelefon);
            Controls.Add(mtxtDoktorTelefon);
            Controls.Add(lblBolum);
            Controls.Add(cmbBolum);
            Controls.Add(lstDoktorlar);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnDigerSayfayaGec);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pictureBoxLogo2);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "MHRS - Doktor Yönetimi";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDoktorlar;
        private Label lblDoktorTelefon;
        private Label lblDoktorAdiSoyadi;
        private TextBox txtDoktorAdiSoyadi;
        private Button btnDigerSayfayaGec;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private MaskedTextBox mtxtDoktorTelefon;
        private ComboBox cmbBolum;
        private Label lblBolum;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxLogo2;
    }
}

