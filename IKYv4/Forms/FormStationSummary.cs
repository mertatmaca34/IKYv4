using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormStationSummary : Form
    {
        readonly List<KadroDurumlari> _kadroDurumlari;

        public FormStationSummary(List<KadroDurumlari> kadroDurumlari)
        {
            InitializeComponent();

            _kadroDurumlari = kadroDurumlari;
        }

        private void FormStationSummary_Load(object sender, EventArgs e)
        {

        }
    }
}
