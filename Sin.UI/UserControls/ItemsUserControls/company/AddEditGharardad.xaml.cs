using MaterialDesignThemes.Wpf;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sin.UI.UserControls.ItemsUserControls.company
{
   
    public partial class AddEditGharardad : UserControl
    {
        List<gharardad> gharardads=new();

        public AddEditGharardad()
        {
            InitializeComponent();
            gharardads.Add(new gharardad()
            {
                id = 1,
                title="t1",
                kharidar="kh1",
                foroshande="fsh1",
                sdate=DateTime.Now,
                edate=DateTime.Now,
                sharh="sharh........."
                      

            });
            gharardads.Add(new gharardad
            {
                id = 2,
                title = "t2",
                kharidar = "kh2",
                foroshande = "fsh2",
                sdate = DateTime.Now,
                edate = DateTime.Now,
                sharh = "sharh2.........",
                file= "D:/gharardad.txt"
            });
            this.dgvGharardad.ItemsSource = gharardads;
        }

      

        private void btnEditgharadad_Click(object sender, RoutedEventArgs e)
        {
            gharardad gharardad =gharardads.FirstOrDefault(x=>x.id==2);
         
           
           
            EditGharardadWin editGharardadWin = new EditGharardadWin(gharardad);
            editGharardadWin.Owner = App.Current.MainWindow;
            editGharardadWin.ShowDialog();
        }

        private void btnSaveGharardad_Click(object sender, RoutedEventArgs e)
        {
            string filepath = "D:/gharardad.txt";
           
            if (txtMatnGharardad != null)
            {
                
                File.AppendAllText(filepath, txtMatnGharardad.Text);

                MessageBox.Show("Successfully Added....");
            }
        }
    }
    public class gharardad
    {
        public int id { get; set; }
        public string title { get; set; }
        public string kharidar { get; set; }
        public string foroshande { get; set; }
        public string sharh { get; set; }
        public DateTime sdate { get; set; }
        public DateTime edate { get; set; }
        public int mablagh { get; set; } = 250000000;
        public string file { get; set; }
    }
}
