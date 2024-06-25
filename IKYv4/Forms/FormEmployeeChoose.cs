using Business.Abstract;
using DataAccess.Abstract;
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
    public partial class FormEmployeeChoose : Form
    {
        public Personel SeciliPersonel { get; set; }

        readonly IPersonelManager _personelManager;

        public FormEmployeeChoose(IPersonelManager personelManager)
        {
            InitializeComponent();

            _personelManager = personelManager;
        }

        private void FormEmployeeChoose_Load(object sender, EventArgs e)
        {
            DataGridViewEmployees.DataSource = _personelManager.GetAll().Data;
        }

        private void DataGridViewEmployees_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = DataGridViewEmployees.SelectedRows[0];

            int id = (int)row.Cells[1].Value;

            var getEmployeeData = _personelManager.GetAll(x => x.Id == id).Data.FirstOrDefault();

            if (getEmployeeData != null)
            {
                SeciliPersonel = getEmployeeData;
            }

            this.Close();
        }
    }
}
