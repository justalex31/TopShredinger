using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShredinger.Models;
using TopShredinger.Views.DetailViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopShredinger.Views.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
        public ListView ListView { get { return listView; } }
        public List<MasterMenuItem> items;
		public MasterPage ()
		{
			InitializeComponent();
            SetItems();
		}

        void SetItems()
        {
            items = new List<MasterMenuItem>()
            {
                new MasterMenuItem("InfoScreen1", "icon.png", Color.White, typeof(InfoScreen1)),
                new MasterMenuItem("InfoScreen2", "icon.png", Color.White, typeof(InfoScreen2)),
                new MasterMenuItem("Camera", "icon.png", Color.White, typeof(Camera)),
                new MasterMenuItem("FriendList", "icon.png", Color.White, typeof(FriendsListPage)),
                new MasterMenuItem("Geo", "icon.png", Color.White, typeof(Geo))
            };
            ListView.ItemsSource = items;
        }
    }
}