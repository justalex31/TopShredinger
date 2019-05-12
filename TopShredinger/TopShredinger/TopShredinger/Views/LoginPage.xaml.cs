using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopShredinger.Models;
using TopShredinger.Views.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopShredinger.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            Init();
		}

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            App.StartCheckIfInternet(lbl_NoInternet, this);

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
        }

        private async void SignInProcedure(object sender, EventArgs e)
        {
            var user = new User(Entry_Username.Text, Entry_Password.Text);

            if (user.CheckInformation())
            {
                ActivitySpinner.IsVisible = true;

                //var result = await App.RestService.Login(user);
                var result = new Token();
                await DisplayAlert("Login", "Login Success", "OK");

                //result.access_token
                if (result != null)
                {
                    ActivitySpinner.IsVisible = false;
                    //App.UserDb.SaveUser(user);
                    //App.TokenDb.SaveToken(result);
                    Application.Current.MainPage = new MasterDetail();
                }
            }
            else
            {
                await DisplayAlert("Login", "Login Not Correct", "OK");
            }
        }
    }
}