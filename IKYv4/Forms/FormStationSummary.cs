using Business.Abstract;
using Entities.Concrete;
using Entities.Enums;
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
        private readonly int _stationId;

        List<KadroDurumlari> _kadroDurumlari;

        public FormStationSummary(IKadroDurumlariManager kadroDurumlariManager, ISeflikManager seflikManager, Stations station)
        {
            _kadroDurumlariManager = kadroDurumlariManager;
            _seflikManager = seflikManager;
            _stationId = Convert.ToInt16(station);

            InitializeComponent();
        }

        private void FormStationSummary_Load(object sender, EventArgs e)
        {
            DataGridViewCustomization();
        }

        private void DataGridViewCustomization()
        {
            var seflik = _seflikManager.GetAll(s => s.Id == _stationId).Data.FirstOrDefault();

            _kadroDurumlari = _kadroDurumlariManager.GetAll(k => k.SeflikId == seflik.Id).Data;

            DataGridViewKadroDurumlari.DataSource = _kadroDurumlari;

            DataGridViewKadroDurumlari.Columns.RemoveAt(0);
            DataGridViewKadroDurumlari.Columns.RemoveAt(0);
            DataGridViewKadroDurumlari.Columns.RemoveAt(0);

            DataGridViewKadroDurumlari.Refresh();
        }
    }
}
