using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Sin.UI.Tools.Convertors
{
    public class FilePathConvertor : IValueConverter
    {
        public static string FilePath;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            FilePath = (string)value;
            string TextFile="";
            if (value !=null)
            {
                TextFile=File.ReadAllText(value.ToString()!);
            }
            return TextFile;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           return FilePath;
               
        }
    }
}
