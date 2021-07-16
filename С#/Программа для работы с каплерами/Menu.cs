using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using infSis.Model;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace infSis
{
    public partial class Menu : Form
    {

        infSisContext db;
        string text = "Ошибка подключения к БД";
        string caption = "Ошибка";
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBoxIcon icon = MessageBoxIcon.Error;

        public Menu()
        {
            InitializeComponent();

            db = new infSisContext();
            try
            {
                db.Danns.Load();
                db.Tipes.Load();

                dgvDann.AutoGenerateColumns = false;
               
                dgvDann.DataSource = db.Danns.Local.ToBindingList();
            }
            catch
            {
                MessageBox.Show(this, text, caption, buttons, icon);
            }
        }

        private void btnDobP_Click(object sender, EventArgs e)
        {
            int check = 0;
            Pla plat = new Pla();

            plat.cmbPlatTipe.DataSource = db.Tipes.ToList();
            plat.cmbPlatTipe.ValueMember = "Id";
            plat.cmbPlatTipe.DisplayMember = "tipe";

            if (plat.ShowDialog(this) == DialogResult.Cancel)
                return;
            for (int i = 0; i < dgvDann.RowCount; i++)
            {
                if (dgvDann[2, i].FormattedValue.ToString().Contains(plat.cmbPlatTipe.SelectedItem.ToString()))
                {
                    if (dgvDann[3, i].FormattedValue.ToString().Contains(plat.SnNew.Text.ToString()))
                    {
                        DialogResult result;
                        result = MessageBox.Show("Каплер с таким серийным номером уже существует. При повторном добавлении удалиться первоначальный каплер.", "Добавить?", MessageBoxButtons.OKCancel);
                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            check = 1;
                            int index = dgvDann.Rows[i].Index;
                            int id = 0;
                            bool converted = Int32.TryParse(dgvDann[0, index].Value.ToString(), out id);
                            if (converted == false)
                                return;

                            Dann delHis = db.Danns.Find(id);
                            db.Danns.Remove(delHis);
                            try
                            {
                                Dann dann = new Dann();
                                dann.Tipe = (Tipe)plat.cmbPlatTipe.SelectedItem;
                                dann.sn = plat.SnNew.Text;
                                db.Danns.Add(dann);
                                db.SaveChanges();
                            }
                            catch
                            {
                                MessageBox.Show(this, text, caption, buttons, icon);
                            }
                        }
                        else
                        {
                            plat.Close();
                            check = 1;
                        }
                        break;

                    }
                }
            }
            if (check == 0)
            {
                try
                {
                    Dann dann = new Dann();
                    dann.Tipe = (Tipe)plat.cmbPlatTipe.SelectedItem;
                    dann.sn = plat.SnNew.Text;
                    db.Danns.Add(dann);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show(this, text, caption, buttons, icon);
                }
            }

        }

        private void bthDelP_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите удалить данные?", "Удалить запись", MessageBoxButtons.OKCancel);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    int index = dgvDann.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dgvDann[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;

                    Dann delHis = db.Danns.Find(id);
                    db.Danns.Remove(delHis);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show(this, text, caption, buttons, icon);
                }
            }
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDann.DataSource = db.Danns.Where(p => p.sn.ToLower().Contains(tbPoiskPlat.Text.ToLower())).ToList();
                dgvDann.Refresh();
            }
            catch
            {
                MessageBox.Show(this, text, caption, buttons, icon);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDann.DataSource = db.Danns.ToList();
                dgvDann.Refresh();
            }
            catch
            {
                MessageBox.Show(this, text, caption, buttons, icon);
            }
        }

        private void dgvDann_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvDann.Refresh();
            double n1, n2, x, x1, x2;
            int index = dgvDann.SelectedRows[0].Index;
            n1 = double.Parse(dgvDann[6, index].Value.ToString());
            n2 = double.Parse(dgvDann[8, index].Value.ToString());
            TypRed typRed = new TypRed();

            int rows = dgvDann.Rows.Count;

            if ((n1 != 0) && (n2 != 0))
            {
                dgvDann[12, index].Value = Math.Round((Math.Abs(n1) / Math.Abs(n2)), 4);

                x1 = Math.Pow(10, (n1 / 10)) * 100;
                x2 = Math.Pow(10, (n2 / 10)) * 100;
                x = x1 + x2;

                dgvDann[7, index].Value = Math.Round(((x1/x)*100), 4);
                dgvDann[9, index].Value = Math.Round(((x2/x)*100), 4);


            }

            if ((n1 == 0) && (n2 == 0))
            {
                dgvDann[11, index].Value = " ";
            }
            db.SaveChanges();
        }

        private void dgvDann_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            autorize auto = new autorize();

            if (auto.ShowDialog(this) == DialogResult.Cancel)
                return;
        }

        private void btnObn_Click(object sender, EventArgs e)
        {
            dgvDann.Refresh();
            DateTime datProv;
            datProv = DateTime.MinValue;
            /*string datePdf = datProv.ToString("dd/MM/yy");*/
            int resh1, resh2, resh3, tipS, danS, godn, negodn, neprov, prov1, prov2;
            godn = 0;
            negodn = 0;
            neprov = 0;
            resh1 = 0;
            resh2 = 0;
            danS = dgvDann.RowCount;
            TypRed typRed = new TypRed();
            tipS = typRed.dgvTip.RowCount;

            for (int i = 0; i < danS; i++)
            {
                for (int k = 0; k < tipS; k++)
                {

                    if (typRed.dgvTip[1, k].Value.ToString() == dgvDann[2, i].Value.ToString())
                    {
                        prov1 = 0;
                        prov2 = 0;
                        if (double.Parse(dgvDann[6, i].Value.ToString()) == 0)
                        {
                            prov1 = 1;
                        }
                        else
                        {
                            if (((double.Parse(typRed.dgvTip[2, k].Value.ToString())) <= double.Parse(dgvDann[6, i].Value.ToString())) && ((double.Parse(typRed.dgvTip[3, k].Value.ToString())) >= double.Parse(dgvDann[6, i].Value.ToString())))
                            {
                                resh1 = 1;
                                dgvDann[6, i].Style.BackColor = Color.Green;
                            }
                            else
                            {
                                resh1 = 0;
                                dgvDann[6, i].Style.BackColor = Color.Red;
                            }
                        }
                        if (double.Parse(dgvDann[8, i].Value.ToString()) == 0)
                        {
                            prov2 = 1;
                        }
                        else
                        {
                            if (((double.Parse(typRed.dgvTip[4, k].Value.ToString())) <= double.Parse(dgvDann[8, i].Value.ToString())) && ((double.Parse(typRed.dgvTip[5, k].Value.ToString())) >= double.Parse(dgvDann[8, i].Value.ToString())))
                            {
                                resh2 = 1;
                                dgvDann[8, i].Style.BackColor = Color.Green;
                            }
                            else
                            {
                                resh2 = 0;
                                dgvDann[8, i].Style.BackColor = Color.Red;
                            }
                        }
                        if (((double.Parse(typRed.dgvTip[6, k].Value.ToString())) <= double.Parse(dgvDann[12, i].Value.ToString())) && ((double.Parse(typRed.dgvTip[7, k].Value.ToString())) >= double.Parse(dgvDann[12, i].Value.ToString())))
                        {
                            resh3 = 1;
                            dgvDann[12, i].Style.BackColor = Color.Green;
                        }
                        else
                        {
                            resh3 = 0;
                            dgvDann[12, i].Style.BackColor = Color.Red;
                        }
                        DateTime DateProv = DateTime.Parse(dgvDann[11, i].Value.ToString());
                        string dateProv = DateProv.ToString("dd.MM.yyyy");
                        if (prov1 == 1 | prov2 == 1)
                        {
                            dgvDann[13, i].Value = "Не проверен";
                            dgvDann[13, i].Style.BackColor = Color.Red;
                            dgvDann[3, i].Style.BackColor = Color.Red;
                            neprov++;
                        }
                        else
                        {
                            if (resh1 + resh2 + resh3 == 3)
                            {
                                dgvDann[13, i].Value = "Годен";
                                dgvDann[13, i].Style.BackColor = Color.Green;
                                dgvDann[3, i].Style.BackColor = Color.Green;
                                godn++;
                            }
                            else
                            {
                                dgvDann[13, i].Value = "Не годен";
                                dgvDann[13, i].Style.BackColor = Color.Red;
                                dgvDann[3, i].Style.BackColor = Color.Red;
                                negodn++;
                            }
                        }
                    }
                }
                lblGodn.Text = godn.ToString();
                lblNeGodn.Text = negodn.ToString();
                lblNeProv.Text = neprov.ToString();
                lblAll.Text = Convert.ToString(godn+negodn+neprov);
            }

            db.SaveChanges();
        }

        private void btnPdf_Click_1(object sender, EventArgs e)
        {
            DateTime month;
            month = DateTime.Now;
            string datePdf = month.ToString("dd/MM/yy");
            int godn, ob, negodn, neprov;
            godn = 0;
            ob = 0;
            negodn = 0;
            neprov = 0;

            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgvDann.ColumnCount -1);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 108;
            pdfTable.SetWidths(new float[] { 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3});
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font fontB = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.BOLD);

            // шапка
            PdfPCell cell = new PdfPCell(new Phrase("Отчёт по проверке каплеров", fontB));
            cell.Colspan = 13;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 0;
            pdfTable.AddCell(cell);

            PdfPCell cell2 = new PdfPCell(new Phrase(" "));
            cell2.Colspan = 13;
            cell2.BorderWidth = 0;
            pdfTable.AddCell(cell2);

            //Названия колонок  
            PdfPCell c1 = new PdfPCell(new Phrase("№", font));
            c1.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c1);

            PdfPCell c2 = new PdfPCell(new Phrase("Тип", font));
            c2.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c2);

            PdfPCell c3 = new PdfPCell(new Phrase("S/N", font));
            c3.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c3);

            PdfPCell c4 = new PdfPCell(new Phrase("Заявленные потери 1", font));
            c4.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c4);

            PdfPCell c5 = new PdfPCell(new Phrase("Заявленные потери 2", font));
            c5.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c5);

            PdfPCell c6 = new PdfPCell(new Phrase("Фактические потери 1", font));
            c6.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c6);

            PdfPCell c7 = new PdfPCell(new Phrase("Процент 1", font));
            c7.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c7);

            PdfPCell c8 = new PdfPCell(new Phrase("Фактические потери 2", font));
            c8.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c8);

            PdfPCell c9 = new PdfPCell(new Phrase("Процент 2", font));
            c9.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c9);

            PdfPCell c10 = new PdfPCell(new Phrase("Дата поступления", font));
            c10.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c10);

            PdfPCell c11 = new PdfPCell(new Phrase("Дата проверки", font));
            c11.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c11);

            PdfPCell c12 = new PdfPCell(new Phrase("Отношение", font));
            c12.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c12);

            PdfPCell c13 = new PdfPCell(new Phrase("Решение", font));
            c13.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            pdfTable.AddCell(c13);

            //Adding DataRow
            for (int i = 0; i < dgvDann.SelectedRows.Count; i++)
            {
                int j = i;
                j++;
                pdfTable.AddCell(new Phrase(j.ToString(), font));
                pdfTable.AddCell(new Phrase(dgvDann.SelectedRows[i].Cells[2].Value.ToString(), font));
                pdfTable.AddCell(new Phrase(dgvDann.SelectedRows[i].Cells[3].Value.ToString(), font));
                pdfTable.AddCell(new Phrase(dgvDann.SelectedRows[i].Cells[4].Value.ToString(), font));
                pdfTable.AddCell(new Phrase(dgvDann.SelectedRows[i].Cells[5].Value.ToString(), font));
                pdfTable.AddCell(new Phrase(dgvDann.SelectedRows[i].Cells[6].Value.ToString(), font));
                pdfTable.AddCell(new Phrase(dgvDann.SelectedRows[i].Cells[7].Value.ToString(), font));
                pdfTable.AddCell(new Phrase(dgvDann.SelectedRows[i].Cells[8].Value.ToString(), font));
                pdfTable.AddCell(new Phrase(dgvDann.SelectedRows[i].Cells[9].Value.ToString(), font));

                DateTime DatePos = DateTime.Parse(dgvDann.SelectedRows[i].Cells[10].Value.ToString());
                string datePos = DatePos.ToString("dd.MM.yyyy");
                DateTime DateProv = DateTime.Parse(dgvDann.SelectedRows[i].Cells[11].Value.ToString());
                string dateProv = DateProv.ToString("dd.MM.yyyy");
                string pusto = " ";
                if (datePos == "01.01.0001")
                {
                    pdfTable.AddCell(new Phrase(pusto, font));
                }
                else
                {
                    pdfTable.AddCell(new Phrase(datePos, font));
                }
                if (dateProv == "01.01.0001")
                {
                    pdfTable.AddCell(new Phrase(pusto, font));
                }
                else
                {
                    pdfTable.AddCell(new Phrase(dateProv, font));
                }
                pdfTable.AddCell(new Phrase(dgvDann.SelectedRows[i].Cells[12].Value.ToString(), font));
                pdfTable.AddCell(new Phrase(dgvDann.SelectedRows[i].Cells[13].Value.ToString(), font));
                if (dgvDann.SelectedRows[i].Cells[13].Value.ToString() == "Годен")
                {
                    godn++;
                }
                if (dgvDann.SelectedRows[i].Cells[13].Value.ToString() == "Не годен")
                {
                    negodn++;
                }
                if (dgvDann.SelectedRows[i].Cells[13].Value.ToString() == "Не проверен")
                {
                    neprov++;
                }

            }
            // подписи после таблицы
            PdfPCell cell3 = new PdfPCell(new Phrase(" "));
            cell3.Colspan = 13;
            cell3.BorderWidth = 0;
            pdfTable.AddCell(cell3);

            ob = neprov + negodn + godn;

            PdfPCell cell10 = new PdfPCell(new Phrase("Общее количество: "+ob, font));
            cell10.Colspan = 3;
            cell10.BorderWidth = 0;
            pdfTable.AddCell(cell10);

            PdfPCell cell11 = new PdfPCell(new Phrase("Годные: " + godn, font));
            cell11.Colspan = 2;
            cell11.BorderWidth = 0;
            pdfTable.AddCell(cell11);

            PdfPCell cell12 = new PdfPCell(new Phrase("Не годные: " + negodn, font));
            cell12.Colspan = 2;
            cell12.BorderWidth = 0;
            pdfTable.AddCell(cell12);

            PdfPCell cell13 = new PdfPCell(new Phrase("Не проверенные: " + neprov, font));
            cell13.Colspan = 3;
            cell13.BorderWidth = 0;
            pdfTable.AddCell(cell13);

            PdfPCell cell8 = new PdfPCell(new Phrase("Дата печати: "+datePdf, font));
            cell8.Colspan = 3;
            cell8.HorizontalAlignment = Element.ALIGN_LEFT;
            cell8.BorderWidth = 0;
            pdfTable.AddCell(cell8);

            PdfPCell ce2 = new PdfPCell(new Phrase(" "));
            ce2.Colspan = 13;
            ce2.BorderWidth = 0;
            pdfTable.AddCell(ce2);

            PdfPCell cell4 = new PdfPCell(new Phrase("Проверил(а): Должность _______________ ФИО _______________ Подпись _______________", font));
            cell4.Colspan = 13;
            cell4.HorizontalAlignment = Element.ALIGN_LEFT;
            cell4.BorderWidth = 0;
            pdfTable.AddCell(cell4);

            PdfPCell ce3 = new PdfPCell(new Phrase(" "));
            ce3.Colspan = 13;
            ce3.BorderWidth = 0;
            pdfTable.AddCell(ce3);

            PdfPCell cell5 = new PdfPCell(new Phrase("Согласовано:", font));
            cell5.Colspan = 13;
            cell5.HorizontalAlignment = Element.ALIGN_LEFT;
            cell5.BorderWidth = 0;
            pdfTable.AddCell(cell5);

            PdfPCell ce1 = new PdfPCell(new Phrase(" "));
            ce1.Colspan = 13;
            ce1.BorderWidth = 0;
            pdfTable.AddCell(ce1);

            PdfPCell cell6 = new PdfPCell(new Phrase("Должность _______________ ФИО _______________ Подпись _______________", font));
            cell6.Colspan = 13;
            cell6.HorizontalAlignment = Element.ALIGN_LEFT;
            cell6.BorderWidth = 0;
            pdfTable.AddCell(cell6);

            PdfPCell cell9 = new PdfPCell(new Phrase(" "));
            cell9.Colspan = 13;
            cell9.BorderWidth = 0;
            pdfTable.AddCell(cell9);

            PdfPCell cell7 = new PdfPCell(new Phrase("Должность _______________ ФИО _______________ Подпись _______________", font));
            cell7.Colspan = 13;
            cell7.HorizontalAlignment = Element.ALIGN_LEFT;
            cell7.BorderWidth = 0;
            pdfTable.AddCell(cell7);

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            try
            {
                using (FileStream stream = new FileStream(folderPath + "Каплеры " + datePdf + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4.Rotate());
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("Pdf-документ сохранен. Путь к файлу: С/PDFs/");
            }
            catch
            {
                MessageBox.Show("Закройте текущий PDF файл");
            }
        }

        private void tbPoiskPlat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSerch.PerformClick();
        }
    }
}
