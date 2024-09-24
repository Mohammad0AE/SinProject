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

namespace Sin.UI.UserControls.HomeUserControls
{
    /// <summary>
    /// Interaction logic for AddKarteksUC.xaml
    /// </summary>
    /// 
    public partial class AddKarteksUC : UserControl
    {
        List<karteks> lstk = new List<karteks>() { new karteks { id = 1, name = "مسعود پزشکیان", tarikh = "1403/05/31" }, new karteks { id = 12, name = "سید روح اله موسوی خمینی", tarikh = "1403/05/31" } , new karteks { id = 13, name = "جو بایدن", tarikh = "1403/05/31" }

        ,new karteks { id = 1, name = "مسعود  رجبی", tarikh = "1403/05/31" }
,new karteks { id = 2, name = "فردریش نیچه", tarikh = "1403/05/31" }
,new karteks { id = 3, name = "محسن میر محمدی", tarikh = "1403/05/31" }
,new karteks { id = 4, name = "محمد ابراهیمی", tarikh = "1403/05/31" }
,new karteks { id = 5, name = " اص منصور رحیمی", tarikh = "1403/05/31" }
,new karteks { id = 6, name = "میلاد کی مرام", tarikh = "1403/05/31" }
,new karteks { id = 7, name = "داریوش اقبالی", tarikh = "1403/05/31" }
,new karteks { id = 8, name = "هاشم بلاغی", tarikh = "1403/05/31" }
,new karteks { id = 9, name = "ژان پل سارتر", tarikh = "1403/05/31" }
,new karteks { id = 10, name = "نیکی میناژ", tarikh = "1403/05/31" }
,new karteks { id = 11, name = "محمد علی کلی", tarikh = "1403/05/31" }
            
        };

        public AddKarteksUC()
        {
            InitializeComponent();
            dgvKarteks.ItemsSource = lstk;
        }

       
    }
    public class karteks
    {
        public int id { get; set; }
        public string name { get; set; }
        public string tarikh { get; set; }
    }
}
