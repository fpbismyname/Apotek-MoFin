using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Apotek_MoFin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DaftarPage : ContentPage
    {
        public DaftarPage()
        {
            InitializeComponent();
        }

        private void login_tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        private void daftar_clicked(object sender, EventArgs e)
        {

            if (!username_daftar.Text.Equals(String.Empty) && password_daftar.Text.Equals(confirm_password_daftar.Text))
            {
                Navigation.PushAsync(new BerandaPage());
            } else if (username_daftar.Text.Equals(String.Empty) && password_daftar.Text.Equals(confirm_password_daftar.Text))
            {
                DisplayAlert("Ops..","Mohon lengkapi username dan passwordnya","Okay");
            }
            else if (!username_daftar.Text.Equals(String.Empty) && !password_daftar.Text.Equals(confirm_password_daftar.Text))
            {
                DisplayAlert("Ops..","Mohon samakan password barunya","Okay");
            }
        }
    }
}