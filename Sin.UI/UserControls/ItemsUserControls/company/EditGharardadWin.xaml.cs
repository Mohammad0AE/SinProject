using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sin.UI.UserControls.ItemsUserControls.company
{

    public partial class EditGharardadWin : Window
    {
        
        public EditGharardadWin(gharardad gharardad)
        {
            InitializeComponent();
            this.DataContext = gharardad;
          
            
          
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)

        {

            this.Close();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState=this.WindowState==WindowState.Normal?WindowState.Maximized:WindowState.Normal;

        }

        private void btnMaximize_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
