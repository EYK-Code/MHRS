namespace MHRSSistemi.UI
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            dtpBaslangicTarihi = new DateTimePicker();
            dtpBitisTarihi = new DateTimePicker();
            btnDokumanOlustur = new Button();
            lvZRaporu = new ListView();
            pictureBoxLogo = new PictureBox();
            pictureBoxLogo2 = new PictureBox();
            lblBaslangicTarihi = new Label();
            lblBitisTarihi = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo2).BeginInit();
            SuspendLayout();
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.BackColor = Color.LightGray;
            dtpBaslangicTarihi.Font = new Font("Segoe UI", 12F);
            dtpBaslangicTarihi.Location = new Point(179, 131);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(268, 29);
            dtpBaslangicTarihi.TabIndex = 0;
            dtpBaslangicTarihi.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.BackColor = Color.LightGray;
            dtpBitisTarihi.Font = new Font("Segoe UI", 12F);
            dtpBitisTarihi.Location = new Point(179, 171);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(268, 29);
            dtpBitisTarihi.TabIndex = 1;
            dtpBitisTarihi.ValueChanged += dtpBitis_ValueChanged;
            // 
            // btnDokumanOlustur
            // 
            btnDokumanOlustur.BackColor = Color.DarkRed;
            btnDokumanOlustur.FlatStyle = FlatStyle.Flat;
            btnDokumanOlustur.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDokumanOlustur.ForeColor = Color.White;
            btnDokumanOlustur.Location = new Point(661, 470);
            btnDokumanOlustur.Name = "btnDokumanOlustur";
            btnDokumanOlustur.Size = new Size(186, 47);
            btnDokumanOlustur.TabIndex = 3;
            btnDokumanOlustur.Text = "Döküman Oluştur";
            btnDokumanOlustur.UseVisualStyleBackColor = false;
            btnDokumanOlustur.Click += btnDokumanOlustur_Click;
            // 
            // lvZRaporu
            // 
            lvZRaporu.BackColor = Color.WhiteSmoke;
            lvZRaporu.Font = new Font("Segoe UI", 12F);
            lvZRaporu.GridLines = true;
            lvZRaporu.Location = new Point(12, 211);
            lvZRaporu.Name = "lvZRaporu";
            lvZRaporu.Size = new Size(835, 253);
            lvZRaporu.TabIndex = 2;
            lvZRaporu.UseCompatibleStateImageBehavior = false;
            lvZRaporu.View = View.Details;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.images;
            pictureBoxLogo.Location = new Point(12, 20);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxLogo2
            // 
            pictureBoxLogo2.Image = Properties.Resources.MHRS_Logo_1;
            pictureBoxLogo2.Location = new Point(179, 20);
            pictureBoxLogo2.Name = "pictureBoxLogo2";
            pictureBoxLogo2.Size = new Size(200, 100);
            pictureBoxLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo2.TabIndex = 5;
            pictureBoxLogo2.TabStop = false;
            // 
            // lblBaslangicTarihi
            // 
            lblBaslangicTarihi.AutoSize = true;
            lblBaslangicTarihi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBaslangicTarihi.ForeColor = Color.DarkRed;
            lblBaslangicTarihi.Location = new Point(12, 131);
            lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            lblBaslangicTarihi.Size = new Size(130, 21);
            lblBaslangicTarihi.TabIndex = 6;
            lblBaslangicTarihi.Text = "Başlangıç Tarihi";
            // 
            // lblBitisTarihi
            // 
            lblBitisTarihi.AutoSize = true;
            lblBitisTarihi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBitisTarihi.ForeColor = Color.DarkRed;
            lblBitisTarihi.Location = new Point(12, 176);
            lblBitisTarihi.Name = "lblBitisTarihi";
            lblBitisTarihi.Size = new Size(90, 21);
            lblBitisTarihi.TabIndex = 7;
            lblBitisTarihi.Text = "Bitiş Tarihi";
            // 
            // Form4
            // 
            BackColor = Color.White;
            ClientSize = new Size(851, 519);
            Controls.Add(lblBitisTarihi);
            Controls.Add(lblBaslangicTarihi);
            Controls.Add(dtpBaslangicTarihi);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(lvZRaporu);
            Controls.Add(btnDokumanOlustur);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pictureBoxLogo2);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "MHRS - Z Raporu Yönetimi";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpBaslangicTarihi;
        private DateTimePicker dtpBitisTarihi;
        private Button btnDokumanOlustur;
        private ListView lvZRaporu;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxLogo2;
        private Label lblBaslangicTarihi;
        private Label lblBitisTarihi;
    }
}


