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

namespace Sin.UI.UserControls.TozinUserControls
{
    /// <summary>
    /// Interaction logic for MoshtariUC.xaml
    /// </summary>
    public partial class MoshtariUC : UserControl
    {
        public MoshtariUC()
        {
            InitializeComponent();
            dgvMoshtari.ItemsSource = new List<moshtari>
            {

                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"},
                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"},
                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"},
                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"},
                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"},
                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"},
                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"},
                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"},
                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"},
                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"},
                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"},
                new moshtari{nameg="حقیقی",name="محمد ابراهیمی", mahdodiat=false,mobile="098152665"}
            };
        }
    }
    public class moshtari
    {
        public string nameg {  get; set; }
        public string name { get; set; }
        public string mobile     { get; set; }
        public bool mahdodiat { get; set; }
        public string hesab { get; set; } = "شرکت";
    }
}
