using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


using Xamarin.Forms;

namespace AppCenterExemplo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppCenterExemplo.MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("ios={Sua chave};android={Sua chave}", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            
        }

        protected override void OnResume()
        {
            
        }
    }
}
