using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TimeKeeper.Converters
{
	public class NullableDateTimeConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var d = (DateTime?)value;
			if (d.HasValue)
				return d.Value;
			else
				return DateTime.MinValue;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			//var s = (string)value;
			//if (String.IsNullOrEmpty(s))
			//	return null;
			//else
			//	return (decimal?)decimal.Parse(s, culture);
			throw new NotImplementedException();
		}
	}
}
