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

namespace Sin.UI.UserControls.ItemsUserControls
{
    /// <summary>
    /// Interaction logic for MachinesUC.xaml
    /// </summary>
    public partial class MachinesUC : UserControl
    {
        public MachinesUC()
        {
            InitializeComponent();
            calc();
            dgvRanande.ItemsSource=new List<ranande> { new ranande() { id=1,name="محمد",mobile="098165654"},
             new ranande() { id=2,name="محمد",mobile="098165654"},
              new ranande() { id=3,name="محمد",mobile="098165654"},
               new ranande() { id=4,name="محمد",mobile="098165654"},
                new ranande() { id=5,name="محمد",mobile="098165654"},
                 new ranande() { id=4,name="محمد",mobile="098165654"},
                  new ranande() { id=7,name="محمد",mobile="098165654"},
                   new ranande() { id=8,name="محمد",mobile="098165654"}, new ranande() { id=1,name="محمد",mobile="098165654"}




            };
            dgvmalek.ItemsSource = new List<malek>
            {
                new malek() { id=1,sahm=100 ,name="asdasds"},
                new malek() { id=2,sahm=100 ,name="sdfsdfsf"},
                new malek() { id=3,sahm=100 ,name="sdfsdfsf"},
                new malek() { id=4,sahm=100 ,name="sdfsdfsf"},
                new malek() { id=5,sahm=100 ,name="sdfsdfsf"},
                new malek() { id=6,sahm=100 ,name="sdfsdfsf"}

            };
        }
        void calc()
        {
            List<ranande> lstranande = new List<ranande>();
            List<malek> lstmalek
                = new List<malek>();
            List<dastgah> dastgahs = new List<dastgah>();
           
            ranande ranande = new ranande()
            {
                id = 1,
                name = "ممد",
                mobile = "0914221233"
            };
            ranande ranande2 = new ranande()
            {
                id = 2,
                name = "2ممد",
                mobile = "0914221233"
            };
            ranande ranande3 = new ranande
            {
                id = 3,
                name = "ممد3 ",
                mobile = "0914221233"
            };
            lstranande.Add(ranande);
            lstranande.Add(ranande2);
            lstranande.Add(ranande3);
            malek malek = new malek()
            {
                id = 1,
                name = "کمالی"

            };
            malek malek3 = new malek()
            {
                id = 4,
                name = "کمالی4"

            };
            malek malek1 = new malek()
            {
                id = 2,
                name = "2کمالی"

            };
            malek malek2 = new malek()
            {
                id = 3,
                name = "کمالی2"

            };
            lstmalek.Add(malek);
            lstmalek.Add(malek1);
            lstmalek.Add(malek2);
            lstmalek.Add(malek3);
            dastgah dastgah = new dastgah()
            {
                id = 1,
                title = "دهچرخ",
                maleks = lstmalek,
                ranandes = lstranande
            };
            dastgahs.Add(dastgah);
            this.dgvdastgah.ItemsSource = dastgahs;
            
        }

    }
    public class dastgah
    {
        public int id { get; set; }
        public string nodastgah { get; set; } = "باربری";
        public string title { get; set; }
        public List<malek> maleks { get; set; }
        public List<ranande> ranandes { get; set; }

    }
    public class malek
    {
        public int id { get; set; }
        public string name { get; set; }
        public int sahm { get; set; }
    }
    public class ranande
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
      

    }
}
