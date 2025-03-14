using MHRSSistemi.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHRSSistemi.UI
{
    public partial class Form3 : Form
    {
        public Form3(Doktor[] doktorlarDizisi) : this()
        {
            foreach (Doktor item in doktorlarDizisi)
            {
                cmbDoktorAdiSoyadi.Items.Add(item);
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHastaAdiSoyadi.Text) || cmbDoktorAdiSoyadi == null || string.IsNullOrWhiteSpace(txtHastaSikayeti.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            if (dtpMuayeneTarihi.Value < DateTime.Today)
            {
                MessageBox.Show("Geçmiş tarihe randevu alamazsınız.");
                return;
            }

            Hasta hasta = new Hasta()
            {
                AdSoyad = txtHastaAdiSoyadi.Text,
                Sikayet = txtHastaSikayeti.Text,
                Doktor = cmbDoktorAdiSoyadi.SelectedItem as Doktor

            };

            Randevu randevu = new Randevu()
            {
                Hasta = hasta,
                Tarih = dtpMuayeneTarihi.Value.Date

            };
            lstRandevular.Items.Add(randevu);

            Temizle();

            MessageBox.Show("Randevu başarıyla oluşturuldu.");
        }

        private void Temizle()
        {
            txtHastaAdiSoyadi.Text = txtHastaSikayeti.Text = string.Empty;
        }

        private void btnZRaporu_Click(object sender, EventArgs e)
        {
            Randevu[] randevular = new Randevu[lstRandevular.Items.Count];
            lstRandevular.Items.CopyTo(randevular, 0);

            Form4 form4 = new Form4(randevular);
            form4.Show();
        }
    }
}
