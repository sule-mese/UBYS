﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frm_Ders_Index : Form
    {
        public frm_Ders_Index()
        {
            InitializeComponent();
        }

        private void frm_Ders_Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen aranacak bir bilgi giriniz!", "Uyarı");
            }
            else
            {
                str = @"Select Ders_ID AS 'ID' ,
                        DersNo AS 'Ders Kodu' ,
                        DersAdi AS 'Dersin Adı' ,
                        DersKredi AS 'Kredi',
                        DersHoca AS 'Öğretim Görevlisi'
                        from Ders_Bilgi
                        where DersNo like '%" + textBox1.Text + @"%'
                        or DersAdi like '%" + textBox1.Text + @"%'
                        or DersHoca like '%" + textBox1.Text + "%' ";
                dataGridView1.DataSource = DBLayer.IslemYap(str);
            }
        }

        private void btn_YeniDers_Click(object sender, EventArgs e)
        {
            frm_Ders_Ekle frm1 = new frm_Ders_Ekle();
            frm1.ShowDialog();
            frm1.Close();
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            frm_Ders_Düzenle frm2 = new frm_Ders_Düzenle();
            frm2.ShowDialog();
            frm2.Close();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ID.ToString()))
            {
                MessageBox.Show("Lütfen silinecek bir kayıt seçiniz!", "Uyarı");
            }
            else
            {
                str = @"Delete from Ders_Bilgi
                        where Ders_ID=( '" + ID.ToString() + "' )";
                DBLayer.IslemYap(str);
                str = @"Select Ders_ID AS 'ID' ,
                        DersNo AS 'Ders Kodu' ,
                        DersAdi AS 'Dersin Adı' ,
                        DersKredi AS 'Kredi',
                        DersHoca AS 'Öğretim Görevlisi'
                        from Ders_Bilgi";
                dataGridView1.DataSource = DBLayer.TabloSorgula(str);
                ID = "0";
            }
        }

        private void frm_Ders_Index_Load(object sender, EventArgs e)
        {
            str = @"Select Ders_ID AS 'ID' ,
                        DersNo AS 'Ders Kodu' ,
                        DersAdi AS 'Dersin Adı' ,
                        DersKredi AS 'Kredi',
                        DersHoca AS 'Öğretim Görevlisi'
                        from Ders_Bilgi";
            dataGridView1.DataSource = DBLayer.TabloSorgula(str);
        }

        public static string ID="0",str;

        private void btn_raporla_Click(object sender, EventArgs e)
        {
            //PDF ayarları
            BaseFont STF_Helvetica_Turkish = BaseFont.CreateFont("Helvetica", "CP1254", BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.DefaultCell.Phrase = new Phrase() { Font = fontNormal };
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Başlık eklendi
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(dataGridView1.Columns[j].HeaderText, fontNormal));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //alt satırlar
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                    {
                        pdfTable.AddCell(new Phrase(dataGridView1[k, i].Value.ToString(), fontNormal));
                    }
                }
            }

            //PDF oluştur
            string folderPath = "Rapor\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Ders Listesi.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            System.Diagnostics.Process.Start(@"Rapor\\Ders Listesi.pdf");
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = dataGridView1.SelectedCells[0].RowIndex;
            ID = dataGridView1.Rows[num].Cells[0].Value.ToString();
        }
    }
}
