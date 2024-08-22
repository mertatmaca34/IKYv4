using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYv4.Utilities
{
    public static class Export
    {
        static public void ToExcel(DataGridView dataGridView)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";

                // İlk iki sütunu atlayarak başlıkları ekle
                for (int i = 3; i < dataGridView.Columns.Count + 1; i++)
                {              
                    worksheet.Cells[1, i - 2] = dataGridView.Columns[i - 1].HeaderText;
                }

                // İlk iki sütunu atlayarak verileri ekle
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (!dataGridView.Rows[i].IsNewRow) // Boş satırları atla
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++) // İlk iki sütunu atla
                        {
                            var value = dataGridView.Rows[i].Cells[j].Value;
                            worksheet.Cells[i + 2, j - 1] = value != null ? value.ToString() : string.Empty;
                        }
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }

        }
    }
}
