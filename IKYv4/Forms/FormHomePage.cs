using Business.Abstract;
using Entities.Enums;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using IKYv4.Properties;
using IKYv4.Utilities;
using System;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormHomePage : Form
    {
        IKadroDurumlariManager _kadroDurumlariManager;
        ISeflikManager _seflikManager;
        IPersonelManager _personelManager;
        INufusManager _nufusManager;
        ITahsilManager _tahsilManager;

        public FormHomePage(IKadroDurumlariManager kadroDurumlariManager, ISeflikManager seflikManager, IPersonelManager personelManager, INufusManager nufusManager, ITahsilManager tahsilManager)
        {
            _kadroDurumlariManager = kadroDurumlariManager;
            _seflikManager = seflikManager;
            _personelManager = personelManager;
            _nufusManager = nufusManager;
            _tahsilManager = tahsilManager;

            InitializeComponent();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            GmapControlStations.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GmapControlStations.Position = new GMap.NET.PointLatLng(41.0122, 28.976);
            GmapControlStations.Zoom = 10;

            #region İstasyon Marker'ları

            GMapOverlay gMapOverlay = new GMapOverlay();

            GMapMarker gMapMarkerPasakoy = new GMarkerGoogle(new PointLatLng(41.0084, 29.2851), Resources._3_0);
            GMapMarker gMapMarkerSile = new GMarkerGoogle(new PointLatLng(41.1694, 29.5806), Resources._3_0);
            GMapMarker gMapMarkerKadikoy = new GMarkerGoogle(new PointLatLng(40.9885, 29.0194), Resources._3_0);
            GMapMarker gMapMarkerKucuksu = new GMarkerGoogle(new PointLatLng(41.0410, 29.0429), Resources._3_0);
            GMapMarker gMapMarkerTuzla = new GMarkerGoogle(new PointLatLng(40.8242, 29.2908), Resources._3_0);

            GMapMarker gMapMarkerBaltalimani = new GMarkerGoogle(new PointLatLng(41.0989, 29.0373), Resources._3_0);
            GMapMarker gMapMarkerYenikapi = new GMarkerGoogle(new PointLatLng(40.9760, 28.8430), Resources._3_0);
            GMapMarker gMapMarkerAtakoy = new GMarkerGoogle(new PointLatLng(41.0025, 28.9496), Resources._3_0);
            GMapMarker gMapMarkerKucukcekmece = new GMarkerGoogle(new PointLatLng(40.9806, 28.7566), Resources._3_0);
            GMapMarker gMapMarkerAmbarli = new GMarkerGoogle(new PointLatLng(40.9895, 28.6869), Resources._3_0);
            GMapMarker gMapMarkerBuyukcekmece = new GMarkerGoogle(new PointLatLng(41.0450, 28.5531), Resources._3_0);
            GMapMarker gMapMarkerCanta = new GMarkerGoogle(new PointLatLng(41.0670, 28.1004), Resources._3_0);

            GmapControlStations.OnMarkerClick += new MarkerClick(OnMarkerClick);

            GmapControlStations.Overlays.Add(gMapOverlay);

            gMapOverlay.Markers.Add(gMapMarkerPasakoy);
            gMapOverlay.Markers.Add(gMapMarkerSile);
            gMapOverlay.Markers.Add(gMapMarkerKadikoy);
            gMapOverlay.Markers.Add(gMapMarkerKucuksu);
            gMapOverlay.Markers.Add(gMapMarkerTuzla);

            gMapOverlay.Markers.Add(gMapMarkerBaltalimani);
            gMapOverlay.Markers.Add(gMapMarkerYenikapi);
            gMapOverlay.Markers.Add(gMapMarkerAtakoy);
            gMapOverlay.Markers.Add(gMapMarkerKucukcekmece);
            gMapOverlay.Markers.Add(gMapMarkerAmbarli);
            gMapOverlay.Markers.Add(gMapMarkerBuyukcekmece);
            gMapOverlay.Markers.Add(gMapMarkerCanta);

            GmapControlStations.Invalidate();
            GmapControlStations.Update();

            #endregion
        }

        private void OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (item.Position == new PointLatLng(StationPositions.PasakoyX, StationPositions.PasakoyY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Pasakoy));
            }
            else if (item.Position == new PointLatLng(StationPositions.SileX, StationPositions.SileY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Sile));
            }
            else if (item.Position == new PointLatLng(StationPositions.KadikoyX, StationPositions.KadikoyY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Kadikoy));
            }
            else if (item.Position == new PointLatLng(StationPositions.KucuksuX, StationPositions.KucuksuY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Kucuksu));
            }
            else if (item.Position == new PointLatLng(StationPositions.TuzlaX, StationPositions.TuzlaY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Tuzla));
            }
            else if (item.Position == new PointLatLng(StationPositions.BaltalimaniX, StationPositions.BaltalimaniY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Baltalimani));
            }
            else if (item.Position == new PointLatLng(StationPositions.YenikapiX, StationPositions.YenikapiY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Yenikapi));
            }
            else if (item.Position == new PointLatLng(StationPositions.AtakoyX, StationPositions.AtakoyY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Atakoy));
            }
            else if (item.Position == new PointLatLng(StationPositions.KucukcekmeceX, StationPositions.KucukcekmeceY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Kucukcekmece));
            }
            else if (item.Position == new PointLatLng(StationPositions.AmbarliX, StationPositions.AmbarliY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Ambarli));
            }
            else if (item.Position == new PointLatLng(StationPositions.BuyukcekmeceX, StationPositions.BuyukcekmeceY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Buyukcekmece));
            }
            else if (item.Position == new PointLatLng(StationPositions.CantaX, StationPositions.CantaY))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(_kadroDurumlariManager, _seflikManager, _personelManager, _nufusManager, _tahsilManager, Stations.Canta));
            }
        }

        private void FormHomePage_SizeChanged(object sender, EventArgs e)
        {
            foreach (var control in PanelContent.Controls)
            {
                if (control is Form controlForm)
                {
                    controlForm.Size = PanelContent.Size;
                }
            }
        }
    }
}