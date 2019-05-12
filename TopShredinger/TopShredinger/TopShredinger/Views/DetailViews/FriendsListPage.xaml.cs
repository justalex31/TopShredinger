using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShredinger.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopShredinger.Views.DetailViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FriendsListPage : ContentPage
	{
		public FriendsListPage ()
		{
            InitializeComponent();
            BindingContext = new FriendsListViewModel() { Navigation = this.Navigation };
        }
	}
}