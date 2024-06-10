using Business.Abstract;
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
    public partial class FormEmployeeVacation : Form
    {
        IPersonelManager _personelManager;
        IMudurlukManager _mudurlukManager;
        ISeflikManager _seflikManager;
        ITesisManager _tesisManager;

        public FormEmployeeVacation(IPersonelManager personelManager, IMudurlukManager mudurlukManager, ISeflikManager seflikManager, ITesisManager tesisManager)
        {
            _personelManager = personelManager;
            _mudurlukManager = mudurlukManager;
            _seflikManager = seflikManager;
            _tesisManager = tesisManager;

            InitializeComponent();
        }

        private void TextBoxEmployee_TextChanged(object sender, EventArgs e)
        {
            FormEmployeeListing formEmployeeListing = new FormEmployeeListing(_personelManager, _mudurlukManager, _seflikManager, _tesisManager);
            formEmployeeListing.ShowDialog();
        }

        private void TextBoxEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeListing formEmployeeListing = new FormEmployeeListing(_personelManager, _mudurlukManager, _seflikManager, _tesisManager);
            formEmployeeListing.FormBorderStyle = FormBorderStyle.Fixed3D;
            formEmployeeListing.ShowDialog();
        }
    }
}
