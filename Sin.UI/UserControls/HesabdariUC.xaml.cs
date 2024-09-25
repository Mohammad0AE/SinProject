using HandyControl.Tools.Extension;
using Sin.UI.UserControls.ItemsUserControls.company;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sin.UI.UserControls
{
    /// <summary>
    /// Interaction logic for HesabdariUC.xaml
    /// </summary>
    public partial class HesabdariUC : UserControl
    {
        public HesabdariUC()
        {
            InitializeComponent();
        }

       

        private void gardesMoshtariItem_Click(object sender, RoutedEventArgs e)
        {
           
            
            this.mainFrame.Navigate(new Uri("/UserControls/HesabdariUserControls/MoshtariGardeshUC.xaml", uriKind: UriKind.RelativeOrAbsolute));
        }

        private void itemgaharardad_Click(object sender, RoutedEventArgs e)
        { 
            this.mainFrame.Navigate(new Uri("/UserControls/ItemsUserControls/company/AddEditGharardad.xaml", uriKind: UriKind.RelativeOrAbsolute));

        }

    }
    
}
