using Business.Abstract;
using Business.Concrete;
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
        private readonly IPersonelManager _personelManager;
        private readonly INufusManager _nufusManager;

        private readonly int _stationId;

        List<KadroDurumlari> _kadroDurumlari;

        public FormStationSummary(
            IKadroDurumlariManager kadroDurumlariManager, 
            ISeflikManager seflikManager, 
            IPersonelManager personelManager, 
            INufusManager nufusManager,
            Stations station)
        {
            _kadroDurumlariManager = kadroDurumlariManager;
            _seflikManager = seflikManager;
            _personelManager = personelManager;
            _nufusManager = nufusManager;

            _stationId = Convert.ToInt16(station);

            InitializeComponent();
        }

        private void FormStationSummary_Load(object sender, EventArgs e)
        {
            DataGridViewCustomization();
            AssignChartAges();
        }

        private void DataGridViewCustomization()
        {
            var seflik = _seflikManager.GetAll(s => s.Id == _stationId).Data.FirstOrDefault();

            _kadroDurumlari = _kadroDurumlariManager.GetAll(k => k.SeflikId == seflik.Id).Data;

            DataGridViewKadroDurumlari.DataSource = _kadroDurumlari;

            DataGridViewKadroDurumlari.Columns[0].Visible = false;
            DataGridViewKadroDurumlari.Columns[1].Visible = false;
            DataGridViewKadroDurumlari.Columns[2].Visible = false;

            DataGridViewKadroDurumlari.Columns[3].HeaderText = "Şeflik";
            DataGridViewKadroDurumlari.Columns[4].HeaderText = "Ünvan Grubu";
            DataGridViewKadroDurumlari.Columns[5].HeaderText = "Kadro";
            DataGridViewKadroDurumlari.Columns[6].HeaderText = "Mevcut Personel";

            DataGridViewKadroDurumlari.Refresh();
        }


        private void AssignChartAges()
        {
            var seflik = _seflikManager.GetAll(s=> s.Id == _stationId).Data.FirstOrDefault();

            var personeller = _personelManager.GetAll(x => x.Seflik == seflik.SeflikAdi).Data;

            List<Nufus> personelNufuslari = new List<Nufus>();

            foreach (var personel in personeller)
            {
                var res = _nufusManager.GetAll(n=> n.PersonelId == personel.Id);

                if (res.Data.Count > 0)
                {
                    personelNufuslari.Add(res.Data.FirstOrDefault());
                }
            }

            foreach (var personelNufusu in personelNufuslari)
            {
                var personelYasiTimestamp = DateTime.Now - personelNufusu.DogumTarihi;

                var personelYasi = personelYasiTimestamp.Value.TotalDays / 365;

                ChartAges.Series[0].Points.AddXY(0, personelYasi);
            }
        }
    }
}
