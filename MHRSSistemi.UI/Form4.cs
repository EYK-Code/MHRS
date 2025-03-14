using ClosedXML.Excel;
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
    public partial class Form4 : Form
    {
        private Randevu[] randevular;
        public Form4(Randevu[] array) : this()
        {
            this.randevular = array;

            ListeyiGuncelle(DateTime.Today, DateTime.Today);
        }

        private void ListeyiGuncelle(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            lvZRaporu.Items.Clear();

            var filtrelenmisRandevular = randevular
                .Where(r => r.Tarih.Date >= baslangicTarihi && r.Tarih.Date <= bitisTarihi)
                .ToList();

            foreach (var item in filtrelenmisRandevular)
            {
                ListViewItem listViewItem = new ListViewItem(item.Hasta.AdSoyad);
                listViewItem.SubItems.Add(item.Hasta.Doktor.Bolum.ToString());
                listViewItem.SubItems.Add(item.Hasta.Doktor.ToString());
                listViewItem.SubItems.Add(item.Hasta.Sikayet);
                listViewItem.SubItems.Add(item.Tarih.ToShortDateString());


                lvZRaporu.Items.Add(listViewItem);
            }


        }

        public Form4()
        {
            InitializeComponent();
        }

        private void btnDokumanOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime baslangicTarihi = dtpBaslangicTarihi.Value.Date;
                DateTime bitisTarihi = dtpBitisTarihi.Value.Date;
                ListeyiGuncelle(baslangicTarihi, bitisTarihi);
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.AddWorksheet("Z Raporu");
                    //başlıkları ekle
                    worksheet.Cell(1, 1).Value = "Hasta Adı Soyadı";
                    worksheet.Cell(1, 2).Value = "Bölüm";
                    worksheet.Cell(1, 3).Value = "Doktor";
                    worksheet.Cell(1, 4).Value = "Şikayet";
                    worksheet.Cell(1, 5).Value = "Tarih";
                    int satir = 2;
                    foreach (ListViewItem item in lvZRaporu.Items)
                    {
                        worksheet.Cell(satir, 1).Value = item.SubItems[0].Text;
                        worksheet.Cell(satir, 2).Value = item.SubItems[1].Text;
                        worksheet.Cell(satir, 3).Value = item.SubItems[2].Text;
                        worksheet.Cell(satir, 4).Value = item.SubItems[3].Text;
                        worksheet.Cell(satir, 5).Value = item.SubItems[4].Text;
                        satir++;
                    }
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|xlsx";
                        saveFileDialog.Title = "Excel Dosyasını Kaydet";
                        saveFileDialog.FileName = "ZRaporu.xlsx";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath);
                            MessageBox.Show("Excel dosyası başarıyla oluşturuldu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle(dtpBaslangicTarihi.Value.Date, dtpBitisTarihi.Value.Date);
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle(dtpBaslangicTarihi.Value.Date, dtpBitisTarihi.Value.Date);
        }

        private void lvZRaporu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lvZRaporu.View = View.Details;
            lvZRaporu.GridLines = true;
            lvZRaporu.Columns.Add("Hasta Adı Soyadı", 160);
            lvZRaporu.Columns.Add("Bölüm Adı ", 160);
            lvZRaporu.Columns.Add("Doktor Adı Soyadı", 160);
            lvZRaporu.Columns.Add("Şikayet", 160);
            lvZRaporu.Columns.Add("Tarih", 160);

        }
    }
}
