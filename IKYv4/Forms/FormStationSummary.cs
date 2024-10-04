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
            AssignChartEducations();
        }

        private void DataGridViewCustomization()
        {
            var seflik = _seflikManager.GetAll(s => s.Id == _stationId).Data.FirstOrDefault();

            _kadroDurumlari = _kadroDurumlariManager.GetAll(k => k.SeflikId == seflik.Id).Data;

            DataGridViewKadroDurumlari.DataSource = _kadroDurumlari;

            DataGridViewKadroDurumlari.Columns[0].Visible = false;
            DataGridViewKadroDurumlari.Columns[1].Visible = false;
            DataGridViewKadroDurumlari.Columns[2].Visible = false;
            DataGridViewKadroDurumlari.Columns[3].Visible = false;

            DataGridViewKadroDurumlari.Columns[4].HeaderText = "Ünvan Grubu";
            DataGridViewKadroDurumlari.Columns[5].HeaderText = "Kadro";
            DataGridViewKadroDurumlari.Columns[6].HeaderText = "Mevcut Personel";

            DataGridViewKadroDurumlari.Refresh();
        }

        private void AssignChartAges()
        {
            var seflik = _seflikManager.GetAll(s => s.Id == _stationId).Data.FirstOrDefault();

            var personeller = _personelManager.GetAll(x => x.Seflik == seflik.SeflikAdi).Data;

            List<Nufus> personelNufuslari = new List<Nufus>();

            foreach (var personel in personeller)
            {
                var res = _nufusManager.GetAll(n => n.PersonelId == personel.Id);

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

            List<Tahsil> personelTahislleri = new List<Tahsil>();

            foreach (var personel in personeller)
            {
                var tahsil = _tahsilManager.GetAll(x => x.PersonelId == personel.Id).Data.FirstOrDefault();

                if (tahsil != null)
                {
                    personelTahislleri.Add(tahsil);

                }
            }

            if (personelTahislleri != null && personelTahislleri.Count > 0)
            {
                var lisansUstuCount = personelTahislleri.FindAll(x => x.TahsilTuru == "YÜKSEK LİSANS" || x.TahsilTuru == "DOKTORA");
                var lisansCount = personelTahislleri.FindAll(x => x.TahsilTuru == "LİSANS");
                var liseCount = personelTahislleri.FindAll(x => x.TahsilTuru == "LİSE");
                var ortaOkulCount = personelTahislleri.FindAll(x => x.TahsilTuru == "ORTAOKUL");
                var ilkOkulCount = personelTahislleri.FindAll(x => x.TahsilTuru == "İLKOKUL");

                if (lisansUstuCount != null && lisansUstuCount.Count > 0)
                {
                    ChartEducations.Series[0].Points.AddXY("LİSANS ÜSTÜ", lisansUstuCount.Count);
                }
                if (lisansCount != null && lisansCount.Count > 0)
                {
                    ChartEducations.Series[0].Points.AddXY("LİSANS", lisansCount.Count);
                }
                if (liseCount != null && liseCount.Count > 0)
                {
                    ChartEducations.Series[0].Points.AddXY("LİSE", liseCount.Count);
                }
                if (ortaOkulCount != null && ortaOkulCount.Count > 0)
                {
                    ChartEducations.Series[0].Points.AddXY("ORTAOKUL", ortaOkulCount.Count);
                }
                if (ilkOkulCount != null && ilkOkulCount.Count > 0)
                {
                    ChartEducations.Series[0].Points.AddXY("İLKOKUL", ilkOkulCount.Count);
                }
            }
        }
    }
}
