using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Sin.UI.UserControls.ItemsUserControls.karmandan
{

    public partial class AddEditFishHoghoghi : UserControl
    {
            public List<mazaya> lstmazaya = new List<mazaya>();
       public List<kosorat> lstkosorat = new List<kosorat>();


        public ObservableCollection<fish> fishes = new ObservableCollection<fish>();
        public AddEditFishHoghoghi()
        {
            InitializeComponent();
            
            kosorat kosorat = new kosorat()
            {
                k_id = 2,
                k_price = 0,
                k_title = "بیمه سهم کارمند"
            };
           kosorat kosorat1 = new kosorat()
            {
                k_id = 3,
                k_price = 0,
                k_title = "مرخصی"
            };
            kosorat kosorat3 = new kosorat()
            {
                k_id = 4,
                k_price = 0,
                k_title = "غیبت"
            };
            mazaya mazaya2 = new mazaya
            {
                m_id = 2,
                m_price = 0,
                m_title = "حق مسکن"
            };
            mazaya mazaya3 = new mazaya
            {
                m_id = 3,
                m_price = 0,
                m_title = "حق اولاد"
            };
            mazaya mazaya4 = new mazaya
            {
                m_id = 4,
                m_price = 0,
                m_title = "حق بیمه"
            };
            lstmazaya.Add(new mazaya
            {
                m_id = 1,
                m_title = "حقوق",
                m_price = 0
            });

            lstmazaya.Add(mazaya2);
            lstmazaya.Add(mazaya4);
            lstmazaya.Add(mazaya3);
            lstkosorat.Add(kosorat);
            lstkosorat.Add(kosorat1);
            lstkosorat.Add(kosorat3);
            fishes.Add(new fish()
            {
                id = 1,
                namkarmand = "محمد ابرهیمی",
                mah = "مهر",
                mazayas=lstmazaya,
                kosorats=lstkosorat
            });
            fishes.Add(new fish()
            {
                id = 2,
                namkarmand = "محمد بهرامی",
                mah = "آبان",
                mazayas = lstmazaya,
                kosorats = lstkosorat
            });
            fishes.Add(new fish()
            {
                id = 3,
                namkarmand = "مسلم بهمنی",
                mah = "آذر",
                mazayas = lstmazaya,
                kosorats = lstkosorat
            });
            this.dgvFishhoghogh.ItemsSource = fishes;
            
        }
        

        private void btnAddToList_Click(object sender, RoutedEventArgs e)
        {
            fishes.Add(new fish() { id = 5, namkarmand = "تست", mah = "ماه تست", kosorats = lstkosorat, mazayas = lstmazaya });
        }
    }
    public class mazaya
    {
        public int m_id { get; set; }
        public string m_title { get; set; }
        public int m_price { get; set; }

    }
    public class kosorat
    {
        public int k_id { get; set; }
        public string k_title { get; set; }
        public int k_price { get; set; }

    }
    public class fish
    {
        public int id { get; set; }
        public string namkarmand { get; set; }
        public string mah { get; set; }
        public List<mazaya> mazayas { get; set; }
        public List<kosorat> kosorats { get; set; }


    }
}
