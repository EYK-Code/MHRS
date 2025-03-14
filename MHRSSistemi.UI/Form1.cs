using MHRSSistemi.UI.Models;

namespace MHRSSistemi.UI
{
    public partial class Form1 : Form
    {
        List<Bolum> bolumler = new List<Bolum>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstBolumler.SelectedItem == null)
            {
                MessageBox.Show("Güncellemek istediðiniz bölümü seçiniz.");
                return;
            }
            Bolum seciliBolum = (Bolum)lstBolumler.SelectedItem;

            seciliBolum.Adi = txtBolumAdi.Text;
            seciliBolum.Aciklama = txtBolumAciklamasi.Text;

            int index = lstBolumler.SelectedIndex;
            lstBolumler.Items[index] = seciliBolum;

            Temizle();
            MessageBox.Show("Baþarýyla güncellendi.");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text) || string.IsNullOrWhiteSpace(txtBolumAdi.Text))
            {
                MessageBox.Show("Bölüm adý veya açýklamasý boþ olmamalýdýr.");
                return;
            }
            try
            {
                Bolum bolum = new Bolum()
                {
                    Adi = txtBolumAdi.Text,
                    Aciklama = txtBolumAciklamasi.Text
                };

                lstBolumler.Items.Add(bolum);
                Temizle();
                MessageBox.Show("Bölüm eklenmiþtir.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Temizle()
        {
            txtBolumAciklamasi.Text = txtBolumAdi.Text = string.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstBolumler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bölüm seçiniz.");
                return;
            }
            lstBolumler.Items.Remove(lstBolumler.SelectedItem);
            MessageBox.Show("Bölüm baþarýyla silindi.");
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            foreach (Bolum item in lstBolumler.Items)
            {
                bolumler.Add(item);
            }
            form2.Bolumler = bolumler;

            form2.ShowDialog();

        }
    }
}
