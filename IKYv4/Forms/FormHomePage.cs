using Entities.Concrete;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using IKYv4.Properties;
using IKYv4.Utilities;
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
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
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

            GmapControlStations.OnMarkerClick += new MarkerClick(OnMarkerClick);

            GmapControlStations.Overlays.Add(gMapOverlay);

            gMapOverlay.Markers.Add(gMapMarkerPasakoy);
            gMapOverlay.Markers.Add(gMapMarkerSile);
            gMapOverlay.Markers.Add(gMapMarkerKadikoy);
            gMapOverlay.Markers.Add(gMapMarkerKucuksu);
            gMapOverlay.Markers.Add(gMapMarkerTuzla);

            GmapControlStations.Invalidate();
            GmapControlStations.Update();

            #endregion
        }

        private void OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if(item.Position == new PointLatLng(41.0084, 29.2851))
            {
                PageChange.Change(PanelContent, this, new FormStationSummary(new List<KadroDurumlari>()));
            }
        }
    }
}
