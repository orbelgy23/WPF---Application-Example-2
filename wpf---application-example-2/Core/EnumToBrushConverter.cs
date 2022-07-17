using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

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
                    return new SolidColorBrush() { Color = Color.FromRgb(112, 112, 112) };
                case StateEnum.Off:
                    return new SolidColorBrush() { Color = Color.FromRgb(255, 0, 0) };
                case StateEnum.On:
                    return new SolidColorBrush() { Color = Color.FromRgb(0, 255, 0) };
                case StateEnum.Loading:
                    return new SolidColorBrush() { Color = Color.FromRgb(255, 255, 0) };
                default:
                    return new SolidColorBrush() { Color = Color.FromRgb(112, 112, 112) };
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
