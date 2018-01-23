using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCenterExemplo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //ira enviar o valor de acordo com a plataforma
            //Android 

            if (Device.RuntimePlatform == Device.Android)
            {
                Analytics.TrackEvent("Android HomePage");
            }
            // iOS
            else
            {
                Analytics.TrackEvent("iOS HomePage");
            }

            InitializeComponent();

           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Botão Clicado", new Dictionary<string, string> {
                    { "Tela", "Main" },
                    { "Botão", "Botão teste"}
                });

            //Simula um crash
            //Crashes.GenerateTestCrash();
        }
    }
}
