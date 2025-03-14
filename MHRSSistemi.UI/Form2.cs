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
    public partial class Form2 : Form
    {
        public List<Bolum> Bolumler = new List<Bolum>();
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Bolum item in Bolumler)
            {
                cmbBolum.Items.Add(item);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoktorAdiSoyadi.Text) || cmbBolum.SelectedItem == null)
            {
                MessageBox.Show("Gerekli alanlar boş bırakılamaz.");
                return;
            }
            try
            {
                Doktor doktor = new Doktor()
                {
                    AdSoyad = txtDoktorAdiSoyadi.Text,
                    Bolum = (Bolum)cmbBolum.SelectedItem,
                    Telefon = mtxtDoktorTelefon.Text
                };
                lstDoktorlar.Items.Add(doktor);

                Temizle();
                MessageBox.Show("Doktor başarıyla eklendi.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Temizle()
        {
            txtDoktorAdiSoyadi.Text = string.Empty;
            mtxtDoktorTelefon.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbBolum.SelectedItem == null || string.IsNullOrWhiteSpace(txtDoktorAdiSoyadi.Text))
            {
                MessageBox.Show("Boş girilemez.");
                return;

            }

            int index = cmbBolum.SelectedIndex;

            Doktor secilenDoktor = lstDoktorlar.SelectedItem as Doktor;

            secilenDoktor.AdSoyad = txtDoktorAdiSoyadi.Text;
            secilenDoktor.Telefon = mtxtDoktorTelefon.Text;
            secilenDoktor.Bolum.Adi = cmbBolum.SelectedItem.ToString();

            lstDoktorlar.Items[index] = secilenDoktor;

            Temizle();
            MessageBox.Show("Başarıyla güncellendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Doktor seçiniz.");
                return;
            }
            lstDoktorlar.Items.Remove(lstDoktorlar.SelectedItem);
            MessageBox.Show("Başarıyla silindi.");
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Doktor[] doktarlar = new Doktor[0];
            foreach (Doktor item in lstDoktorlar.Items)
            {
                Array.Resize(ref doktarlar, doktarlar.Length + 1);
                doktarlar[doktarlar.Length - 1] = item;
            }
            Form3 form3 = new Form3(doktarlar);
            form3.ShowDialog();
        }
    }
}
