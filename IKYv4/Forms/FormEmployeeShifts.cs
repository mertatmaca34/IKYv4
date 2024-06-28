using Business.Abstract;
using Entities.Concrete;
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
    public partial class FormEmployeeShifts : Form
    {
        ICalismaSaatleriManager _calismaSaatleriManager;

        CalismaSaatleri _selectedPersonelShifts { get; set; }

        public FormEmployeeShifts(ICalismaSaatleriManager calismaSaatleriManager, CalismaSaatleri selectedPersonelShifts)
        {
            InitializeComponent();

            _calismaSaatleriManager = calismaSaatleriManager;
            _selectedPersonelShifts = selectedPersonelShifts;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _selectedPersonelShifts.PazartesiBaslama    = ComboBoxMondayStart.Text;
            _selectedPersonelShifts.PazartesiBitme      = ComboBoxMondayEnd.Text;
            _selectedPersonelShifts.SaliBaslama         = ComboBoxTuesdayStart.Text;
            _selectedPersonelShifts.SaliBitme           = ComboBoxTuesdayEnd.Text;
            _selectedPersonelShifts.CarsambaBaslama     = ComboBoxWednesdayStart.Text;
            _selectedPersonelShifts.CarsambaBitme       = ComboBoxWednesdayEnd.Text;
            _selectedPersonelShifts.PersembeBaslama     = ComboBoxThursdayStart.Text;
            _selectedPersonelShifts.PersembeBitme       = ComboBoxThursdayEnd.Text;
            _selectedPersonelShifts.CumaBaslama         = ComboBoxFridayStart.Text;
            _selectedPersonelShifts.CumaBitme           = ComboBoxFridayEnd.Text;
            _selectedPersonelShifts.CumartesiBaslama    = ComboBoxSaturdayStart.Text;
            _selectedPersonelShifts.CumartesiBitme      = ComboBoxSaturdayEnd.Text;
            _selectedPersonelShifts.PazarBaslama        = ComboBoxSundayStart.Text;
            _selectedPersonelShifts.PazarBitme          = ComboBoxSundayEnd.Text;

            var res = _calismaSaatleriManager.Add(_selectedPersonelShifts);

            MessageBox.Show(res.Message);

            this.Close();
        }
    }
}
