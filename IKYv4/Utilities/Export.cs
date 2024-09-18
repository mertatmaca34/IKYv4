using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace IKYv4.Utilities
{
    public static class Export
    {
        static public void ToExcel(DataGridView dataGridView)
        {
            try
            {
                // SaveFileDialog oluştur
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                saveFileDialog.Title = "Excel Dosyasını Kaydet";
                saveFileDialog.FileName = "veriler.xlsx";

                // Kullanıcı bir dosya yolu seçti mi?
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Excel uygulaması oluştur
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Application.Workbooks.Add(Type.Missing);
                    Excel.Workbook workbook = excelApp.Workbooks[1];
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                    // Başlıkları yaz
                    for (int i = 1; i <= dataGridView.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                    }

                    // Verileri yaz
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }

                    // Seçilen dosya yoluna kaydet
                    workbook.SaveAs(saveFileDialog.FileName);

                    // Excel uygulamasını kapat
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show("Veriler başarıyla Excel dosyasına aktarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
