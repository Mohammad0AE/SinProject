using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
  
    public partial class BankUC : UserControl
    {
        public List<bank> banks { get; set; }=new List<bank>();

       
        public BankUC()
        {
            InitializeComponent();
            banks.Add(new bank()
            {
                id=1,
                title="ملت",
                faal=true,
                rasmi=true,
                sharh="شرح بانک",

                banktitle = new List<banktitle> { new banktitle { idtitle = 1, shomarehesab = "122435465464", title = "ملت کمالی", sahebhesab = "کمالی" } }

            });
            banks.Add(new bank()
            {
                id = 2,
                title = "کشاورزی",
                faal = true,
                rasmi = true,
                sharh = "شرح 2",
                banktitle= new List<banktitle> { new banktitle { idtitle = 1, shomarehesab = "122435465464", title = "کشاورزی بازیار", sahebhesab = "بازیار" } }

            });
            this.dgvBank.ItemsSource = banks;

        }
    }
    public class bank
    {
        public int id { get; set; }
        public string title { get; set; }
        public bool faal { get; set; }
        public bool rasmi { get; set; }
        public string sharh { get; set; }
        
        public List<banktitle> banktitle { get; set; }
    }

    public class banktitle 
    {

        public int idtitle { get; set; }    
        public string sahebhesab { get; set; }
        public string shomarehesab { get; set; }
        public string title { get; set; }

    }
}
