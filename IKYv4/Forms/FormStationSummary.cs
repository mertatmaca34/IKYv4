using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormStationSummary : Form
    {
        private readonly IKadroDurumlariManager _kadroDurumlariManager;
        private readonly ISeflikManager _seflikManager;
        private readonly string _stationName;

        public FormStationSummary(IKadroDurumlariManager kadroDurumlariManager, string stationName)
        {
            _kadroDurumlariManager = kadroDurumlariManager;
            _stationName = stationName;
        }

        private void FormStationSummary_Load(object sender, EventArgs e)
        {
            var seflik = _seflikManager.GetAll(s => s.SeflikAdi == _stationName).Data.FirstOrDefault();

            var kadroDurumlari = _kadroDurumlariManager.GetAll(k => k.SeflikId == seflik.Id).Data;

            foreach (var kadro in kadroDurumlari)
            {
                kadro.
            }
        }
    }
}
