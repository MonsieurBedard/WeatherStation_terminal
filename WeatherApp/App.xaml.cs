using System.Threading;
using System.Windows;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// TODO 11 : Ajouter les ressources linguistiques au projet
        /// TODO 12 : Charger la langue d'affichage

        protected override void OnStartup(StartupEventArgs e)
        {

            string lang = WeatherApp.Properties.Settings.Default.lang;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

            base.OnStartup(e);

            ApplicationView app = new ApplicationView();


            app.Show();

        }
    }
}
