using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana2DCardenas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                var notaSeguimiento1 = Convert.ToDouble(entryNotaSeguimiento1.Text) * 0.3;
                var notaExamen1 = Convert.ToDouble(entryExamen1.Text) * 0.2;
                var notaParcial1 = notaSeguimiento1 + notaExamen1;
                labelNotaParcial1.Text = "Nota Parcial: " + notaParcial1.ToString();

                var notaSeguimiento2 = Convert.ToDouble(entryNotaSeguimiento2.Text) * 0.3;
                var notaExamen2 = Convert.ToDouble(entryExamen2.Text) * 0.2;
                var notaParcial2 = (notaSeguimiento2 + notaExamen2);
                labelNotaParcial2.Text = "Nota Parcial: " + notaParcial2.ToString();
                
                var notaFinal = notaParcial1 + notaParcial2;
                textnotaFinal.Text = "NOTA FINAL: " + notaFinal;
                if (notaFinal >= 7)
                {
                    textEstado.Text = "APROBADO";
                }
                else if(notaFinal <7)
                {
                    textEstado.Text = "REPROBADO";
                }
            }
            catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }  
        }
    }
}
