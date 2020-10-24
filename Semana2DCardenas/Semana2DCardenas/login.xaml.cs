using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana2DCardenas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async void btnAbrirVentanaDos_Clicked(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && textPass.Text == "12345")
            {
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Error", "Acceso no Autorizado", "ok");
            }
        }
    }
}