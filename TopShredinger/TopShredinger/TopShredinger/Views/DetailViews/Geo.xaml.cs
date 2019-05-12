using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopShredinger.Views.DetailViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Geo : ContentPage
	{
		public Geo ()
		{
			InitializeComponent ();
		}

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(timeout: TimeSpan.FromSeconds(10));

            LogitudeLabel.Text = position.Longitude.ToString();

            LatitudeLabel.Text = position.Latitude.ToString();

        }
    }
}