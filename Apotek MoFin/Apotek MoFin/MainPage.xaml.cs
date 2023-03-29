using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Apotek_MoFin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void daftar_tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DaftarPage());
        }
        private void login_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BerandaPage());
        }
    }
}
