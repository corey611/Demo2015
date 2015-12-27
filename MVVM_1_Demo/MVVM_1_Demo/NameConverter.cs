using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace MVVM_1_Demo
{
    public class NameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            int temp = (int)value;
            string name = "App: " + temp;
            return name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
