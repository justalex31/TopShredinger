using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShredinger.Data;
using TopShredinger.UWP.Data;
using Windows.Networking.Connectivity;
using Xamarin.Forms;

[assembly: Dependency(typeof(NetworkConnection))]
namespace TopShredinger.UWP.Data
{
    public class NetworkConnection : INetworkConnection
    {
        public bool IsConnected { get; set; }

        public void CheckNetworkConnection()
        {
            var profile = NetworkInformation.GetInternetConnectionProfile();
            if (profile != null && profile.GetNetworkConnectivityLevel() != NetworkConnectivityLevel.None)
            {
                IsConnected = true;
            }
            else
            {
                IsConnected = false;
            }
        }
    }
}
