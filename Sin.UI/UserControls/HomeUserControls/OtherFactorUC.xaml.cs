using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
    /// Interaction logic for OtherFactorUC.xaml
    /// </summary>
    public partial class OtherFactorUC : UserControl
    {
     
         public OtherFactorUC()
         {

            InitializeComponent();

           this.dgvkala.DataContext = Kalas;
            dgvkala.ItemsSource = Kalas;
            this.DataContext = VahedList;
         }
        private void CalculateSumFactor()
        {
            BigInteger bigInteger = 0;
            BigInteger b = 0;
          foreach ( var item in dgvkala.Items)
            {
                if(item is kala kala)
                {
                    Int64 fee= (Int64)kala.Fee;
                    Int64 tedad= (Int64)kala.Tedad;
                    if (kala.Select)
                        b += BigInteger.Parse((fee*tedad).ToString());

                }
             
            }
            BigInteger ghabelpardakht = b;

           txtmablaghkol.Text =b.ToString();
           if(BigInteger.TryParse(txtTakhfif.Text,out BigInteger takhfif))
            {
                if (BigInteger.TryParse(txtmablaghkol.ToString(), out BigInteger mablaghkol))

                    ghabelpardakht = mablaghkol - takhfif;
            }
            if (takhfif >= b)
            {
                txtTakhfif.Text = "0";
                if (txtGhabelPardakht != null)
                    txtGhabelPardakht.Text = ghabelpardakht.ToString();
            }
           
           
           if(txtGhabelPardakht!=null)
            txtGhabelPardakht.Text =ghabelpardakht.ToString() ;
        }


        List<kala> Kalas = new()
        {
            new kala{ Cod=1,Name="آچار الن",Fee=22100000,Tedad=2,Select=false},
            new kala{ Cod=2,Name="روغن موتور",Fee=150000,Vahed="dfdfs",Tedad=2,Select=false},
             new kala{ Cod=3,Name=" عینک کار",Fee=180000,Tedad=2,Select=true},
              new kala{ Cod=4,Name="فیلتر روغن",Fee=195000,Tedad=2,Select=false},
              new kala{ Cod=4,Name="فیلتر روغن",Fee=195000,Tedad=2,Select=false},
              new kala{ Cod=4,Name="فیلتر روغن",Fee=195000,Tedad=2,Select=false},
              new kala{ Cod=4,Name="فیلتر روغن",Fee=195000,Tedad=2,Select=false},
              new kala{ Cod=4,Name="فیلتر روغن",Fee=195000,Tedad=2,Select=false},
        };
        List<vaheds> VahedList = new List<vaheds>() {new vaheds { Vahed="عدد"},
            new vaheds { Vahed="متر"},new vaheds { Vahed="کیلوگرم"},new vaheds { Vahed="متر"}








        };
        public class kala()
        {
            public int Cod { get; set; }
            public string Name { get; set; }
            public int Fee { get; set; }
            public string Vahed { get; set; } = "عدد";
            public int Tedad { get; set; }
            public bool Select { get; set; } = false;

        }
        public class vaheds
        {
            public string Vahed { get; set; }
        }

        private void txtTakhfif_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalculateSumFactor();
        }

        private void dgvkala_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            CalculateSumFactor();
        }

        private void dgvkala_ColumnDisplayIndexChanged(object sender, DataGridColumnEventArgs e)
        {
            CalculateSumFactor();
        }

        private void dgvkala_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
          

            CalculateSumFactor() ;
        }

        private void dgvkala_CurrentCellChanged(object sender, EventArgs e)
        {
            CalculateSumFactor();
        }
    }
  
}
