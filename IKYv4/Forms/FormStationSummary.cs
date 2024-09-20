using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormStationSummary : Form
    {
        private readonly IKadroDurumlariManager _kadroDurumlariManager;
        private readonly ISeflikManager _seflikManager;
        private readonly IPersonelManager _personelManager;
        private readonly INufusManager _nufusManager;
        private readonly ITahsilManager _tahsilManager;

        private readonly int _stationId;

        List<KadroDurumlari> _kadroDurumlari;

        public FormStationSummary(
            IKadroDurumlariManager kadroDurumlariManager, 
            ISeflikManager seflikManager, 
            IPersonelManager personelManager, 
            INufusManager nufusManager,
            ITahsilManager tahsilManager,
            Stations station)
        {
            _kadroDurumlariManager = kadroDurumlariManager;
            _seflikManager = seflikManager;
            _personelManager = personelManager;
            _nufusManager = nufusManager;
            _tahsilManager = tahsilManager;

            _stationId = Convert.ToInt16(station);

            InitializeComponent();
        }

        private void FormStationSummary_Load(object sender, EventArgs e)
        {
            DataGridViewCustomization();
            AssignChartAges();
            AssignChartExperiences();
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

        private void AssignChartExperiences()
        {
            var seflik = _seflikManager.GetAll(s => s.Id == _stationId).Data.FirstOrDefault();

            var personeller = _personelManager.GetAll(x => x.Seflik == seflik.SeflikAdi).Data;

            foreach (var personel in personeller)
            {
                var deneyimTimestamp = DateTime.Now - personel.IseGirisTarihi;

                var deneyimYil = deneyimTimestamp.TotalDays / 365;

                ChartExperiences.Series[0].Points.AddY(deneyimYil);
            }
        }

        private void AssignChartEducations()
        {
            var seflik = _seflikManager.GetAll(s => s.Id == _stationId).Data.FirstOrDefault();

            var personeller = _personelManager.GetAll(x => x.Seflik == seflik.SeflikAdi).Data;
        }
    }
}
