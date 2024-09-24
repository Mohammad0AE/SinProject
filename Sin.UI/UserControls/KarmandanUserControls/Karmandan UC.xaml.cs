using Sin.UI.UserControls.ToolWindows;
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

namespace Sin.UI.UserControls.KarmandanUserControls
{
    /// <summary>
    /// Interaction logic for KarmandanUC.xaml
    /// </summary>
    public partial class KarmandanUC : UserControl
    {
        public class Karmand
        {
            public int cod { get; set; }
            public string name { get; set; }
            public string hesab { get; set; }
            public string mobile { get; set; }
            public string nogh { get; set; }
            public string title { get; set; }

        }
        List<Karmand>klist=new List<Karmand>()
        {
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="راننده کامیون"},
            new Karmand(){cod=2,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="راننده بیل مکانیکی"},
            new Karmand(){cod=3,name="کریم عبدلجیار",hesab ="سهامدار 1",mobile="09178812255",nogh="داعم",title="اپراتور"},
            new Karmand(){cod=4,name="موسی محمدی",hesab ="سهامدار 2",mobile="09178812255",nogh="داعم",title=" اپراتور"},
            new Karmand(){cod=5,name="فردین  رمضانی",hesab ="سهامدار 1",mobile="09178812255",nogh="داعم",title="راننده"},
            new Karmand(){cod=6,name="مصطفی روستا",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="راننده لودر"},
            new Karmand(){cod=7,name=" مبیتا علی مردانی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="مسیول اداری"},
            new Karmand(){cod=8,name="محمد علی ابراهیمی",hesab ="سهامدار 2",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=9,name="محمد علی ابراهیمی",hesab ="سهامدار 1",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=10,name="محمد علی ابراهیمی",hesab ="سهامدار 2",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=11,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=12,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=13,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
            new Karmand(){cod=1,name="محمد علی ابراهیمی",hesab ="شرکت",mobile="09178812255",nogh="داعم",title="متصدی باسکول"},
        };


        public KarmandanUC()
        {
            InitializeComponent();
            dgvKarmand.ItemsSource = klist;
        }

        private void txtSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Foreground = new SolidColorBrush ( Colors.DarkBlue);

            txtSearch.Opacity = 1;
        }

        private void btndate_Click(object sender, RoutedEventArgs e)
        {
            EditeDateAndTime editeDateAnd = new EditeDateAndTime();
            editeDateAnd.Show();

        }
    }
}
