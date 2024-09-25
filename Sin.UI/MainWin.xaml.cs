using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using ControlzEx.Theming;
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
        
        }

    

        

        private void lighttheme_Click(object sender, RoutedEventArgs e)
        {
      

         
            PaletteHelper paletteHelper = new PaletteHelper();
            
           
            
            var theme = paletteHelper.GetTheme();


            theme.Background = Color.FromRgb(240, 240, 240);
            theme.Foreground = Color.FromRgb(1,22,39);
            theme.SetPrimaryColor(Color.FromRgb(1, 22, 39));
            theme.SetSecondaryColor(Color.FromRgb(240, 240, 240));
           
            paletteHelper.SetTheme(theme);


        }

        private void Darktheme_Click(object sender, RoutedEventArgs e)
        {
            PaletteHelper paletteHelper = new PaletteHelper();

      


            var theme = paletteHelper.GetTheme();

            theme.Background = Color.FromRgb(1, 22, 39);
            theme.Foreground = Color.FromRgb(33,159,213);

            theme.SetPrimaryColor(Color.FromRgb(33, 159, 213));
            theme.SetSecondaryColor(Colors.LightSkyBlue);

            paletteHelper.SetTheme(theme);
        }

      

      

        private void topPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
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
