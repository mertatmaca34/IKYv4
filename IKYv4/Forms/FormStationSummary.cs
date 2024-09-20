using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormStationSummary : Form
    {
        private readonly IKadroDurumlariManager _kadroDurumlariManager;


        public FormStationSummary(IKadroDurumlariManager kadroDurumlariManager)
        {
            _kadroDurumlariManager = kadroDurumlariManager;
        }

        private void FormStationSummary_Load(object sender, EventArgs e)
        {

        }
    }
}
