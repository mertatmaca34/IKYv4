using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormSelectColumns : Form
    {
        public List<string> Columns = new List<string>();

        public FormSelectColumns()
        {
            InitializeComponent();
        }

        private void CheckBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in TableLayoutPanelColumns.Controls)
            {
                if(item is CheckBox)
                {
                    (item as CheckBox).Checked = CheckBoxSelectAll.Checked;
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            foreach (var item in TableLayoutPanelColumns.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkBox = (item as CheckBox);

                    if(checkBox.Checked)
                    {
                        Columns.Add(checkBox.Name);
                    }
                }
            }
        }
    }
}
