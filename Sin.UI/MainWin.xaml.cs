using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

using MaterialDesignThemes.Wpf;
namespace Sin.UI
{
    /// <summary>
    /// Interaction logic for MainWin.xaml
    /// </summary>
    public partial class MainWin : Window
    {
        public MainWin()
        {
            InitializeComponent();
           var cultureInfo = new CultureInfo("fa-IR");
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
         
         
        }

    

        

        private void lighttheme_Click(object sender, RoutedEventArgs e)
        {
      

         
            PaletteHelper paletteHelper = new PaletteHelper();
            
           
            
            var theme = paletteHelper.GetTheme();


            theme.Background = Color.FromRgb(240, 240, 240);
            theme.Foreground = Color.FromRgb(1, 22, 39);
            theme.SetPrimaryColor(Color.FromRgb(1, 22, 39));
            theme.SetSecondaryColor(Color.FromRgb(240, 240, 240));
            theme.Cards.Background = Color.FromRgb(240, 240, 240);
            theme.SecondaryDark = Color.FromRgb(17, 34, 51);
            theme.DataGrids.RowHoverBackground = Color.FromRgb(219, 219, 220);
            

            paletteHelper.SetTheme(theme);


        }

        private void Darktheme_Click(object sender, RoutedEventArgs e)
        {
            PaletteHelper paletteHelper = new PaletteHelper();




            var theme = paletteHelper.GetTheme();

            theme.Background = Color.FromRgb(1, 22, 39);
            theme.Foreground = Color.FromRgb(33, 159, 213);

            theme.SetPrimaryColor(Color.FromRgb(33, 159, 213));
            theme.SetSecondaryColor(Colors.LightSkyBlue);
            theme.Cards.Background = Color.FromRgb(17, 34, 51);
            theme.DataGrids.RowHoverBackground = Color.FromRgb(17, 34, 51);
            theme.SecondaryDark = Color.FromRgb(6, 45, 90);
            theme.DataGrids.ColumnHeaderForeground=Colors.LightSkyBlue;
            paletteHelper.SetTheme(theme);
        }

      

      

        private void topPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            this.DragMove(); 
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void btnmax_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState=this.WindowState==WindowState.Normal?WindowState.Maximized:WindowState.Normal;
        }

        private void btnmin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState=this.WindowState==WindowState.Normal||this.WindowState==WindowState.Maximized?WindowState.Minimized:WindowState.Normal;
        }
    }
}
