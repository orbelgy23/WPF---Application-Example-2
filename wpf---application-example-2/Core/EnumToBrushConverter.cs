using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF___Application_Example_2.Core
{

    public enum StateEnum
    {
        Idle = 0,
        Off = 1,
        On = 2,
        Loading = 3
    }

    public class EnumToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((StateEnum)value)
            {
                case StateEnum.Idle:
                    return Brushes.Gray;
                case StateEnum.Off:
                    return Brushes.Red;
                case StateEnum.On:
                    return Brushes.Lime;
                case StateEnum.Loading:
                    return Brushes.Yellow;
                default:
                    return Brushes.Gray;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
