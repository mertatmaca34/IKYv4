using Business.Abstract;
using System;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormStaffs : Form
    {
        ISeflikManager _seflikManager;

        public FormStaffs(ISeflikManager seflikManager)
        {
            InitializeComponent();

            _seflikManager = seflikManager;
        }

        private void FrormStaffs_Load(object sender, EventArgs e)
        {
            var seflikler = _seflikManager.GetAll().Data;

            foreach (var item in seflikler)
            {
                //ComboBoxSeflik.Items.Add(item.SeflikAdi);
            }
        }
    }
}
