using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Provider;
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

    public partial class AddEditSahamdar : UserControl
    {
        public sahamdar Sahamdar { get; set; } = new();
       
        public AddEditSahamdar()
        {
            InitializeComponent();
            Sahamdar= new sahamdar()
            {
                factory = "شن و ماسه کمال اباد",
                id = 1,
                name = "شرکت",
                sahm = 2,
                lsttankhah = new List<tankhah>() {

                new tankhah() { id = 1, namet = "تنخواه 1", mobile = "091222222", email = "@email.com", desc = "this is desc for t1" },
                new tankhah() { id = 2, namet = "تنخواه2", mobile = "32135584", email = "@email.com", desc = "this is desc for t2" },
                new tankhah() { id = 3, namet = "تنخواه 3", mobile = "091222654222", email = "@email.com", desc = "this is desc for t3" }
            }
            };
          sahamdar  Sahamdar2 = new sahamdar()
            {
                factory = "شن و ماسه کمال اباد",
                id = 1,
                name = "بازیار",
                sahm = 2,
                lsttankhah = new List<tankhah>() {

                new tankhah() { id = 4, namet = "تنخواه 4", mobile = "091222222", email = "4@email.com", desc = "this is desc for t1" },
                new tankhah() { id = 5, namet = "5", mobile = "32135584", email = "5@email.com", desc = "this is desc for t2" },
                new tankhah() { id = 6, namet = "تنخواه 6", mobile = "091222654222", email = "6@email.com", desc = "this is desc for t3" }
            }
            };
            List<sahamdar> slist = new List<sahamdar>();
            slist.Add(Sahamdar);
            slist.Add(Sahamdar2);
            this.dgvsahamdar.ItemsSource = slist.ToList();
            
          
        }
    }

    public class sahamdar
    {
        public int id { get; set; }
        public string name { get; set; }
        public int sahm { get; set; }
        public string factory { get; set; }
        public List<tankhah> lsttankhah { get; set; }
    }
    public class tankhah
    {
        public int id { get; set; }
        public int idsahamdar { get; set; }
        public string namet { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string desc { get; set; }
        public bool faaal { get; set; } = true;
    }
}
