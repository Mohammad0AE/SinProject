using HandyControl.Tools;
using MaterialDesignThemes.Wpf;
using System.Configuration;
using System.Data;
using System.Globalization;
using Sin.UI.Tools;
using System.Windows;

namespace Sin.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
          CultureInfo culture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            ConfigHelper.Instance.SetLang(culture.IetfLanguageTag);
            base.OnStartup(e);
        }
    }

}
