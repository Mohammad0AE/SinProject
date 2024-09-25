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
    /// Interaction logic for DaryaftPardakhtUC.xaml
    /// </summary>
    public partial class DaryaftPardakhtUC : UserControl
    {
        public DaryaftPardakhtUC()
        {
            InitializeComponent();
            List<gardesh> gardeshes = new List<gardesh>
            {
                new gardesh{id=1, np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,

                new gardesh{id=2, np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now}  ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now},
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now} ,
                new gardesh{id=2,np="سهامداران",npt="کمالی" ,nd="کارمند",ndt="محمد ابراهیمی",bs=2500000,bd=2986565200,t=DateTime.Now}


            };
            this.dgvDaryaftPardakht.ItemsSource = gardeshes;
            this.dgvDaryaftPardakht.DataContext = gardeshes;

        }

    }

    public class gardesh
    {
        public int id { get; set; }
        public string np { get; set; }
        public string npt { get; set; }
        public string nd { get; set; }
        public string ndt { get; set; }
        public double bd { get; set; }
        public double bs { get; set; }
        public DateTime t { get; set; }


    }
    
}
