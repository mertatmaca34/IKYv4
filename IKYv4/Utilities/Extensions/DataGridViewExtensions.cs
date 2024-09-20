using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYv4.Utilities.Extensions
{
    public static class DataGridViewExtensions
    {
        public static DataGridView DeepCopy(this DataGridView dataGridView)
        {
            DataGridView dataGridViewNew = new DataGridView();

            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                dataGridViewNew.Columns.Add((DataGridViewColumn)col.Clone());
            }

            // Eski DataGridView'in verilerini (satırları) kopyalayın
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataGridViewNew.Rows.Add(new DataGridViewRow());

                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataGridViewNew.Rows[row.Index].Cells[cell.ColumnIndex].Value = cell.Value;
                }
            }

            return dataGridViewNew;
        }
    }
}
