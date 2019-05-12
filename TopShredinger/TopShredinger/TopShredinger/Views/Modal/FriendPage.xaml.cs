using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShredinger.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopShredinger.Views.Modal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FriendPage : ContentPage
	{
        public FriendViewModel ViewModel { get; private set; }
        public FriendPage(FriendViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }
    }
}