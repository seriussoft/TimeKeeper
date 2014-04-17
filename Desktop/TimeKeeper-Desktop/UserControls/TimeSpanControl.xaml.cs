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
using TimeKeeper.GenericUserControls;

namespace TimeKeeper_Desktop.UserControls
{
	/// <summary>
	/// Interaction logic for TimeSpanControl.xaml
	/// </summary>
	public partial class TimeSpanControl : BaseTimeControl<TimeSpan>
	{
		public TimeSpanControl() : base()
		{
			InitializeComponent();
		}

		protected override TimeSpan CreateValue(int hours, int minutes, int seconds)
		{
			return new TimeSpan(hours, minutes, seconds);
		}

		public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(TimeSpan), typeof(TimeSpanControl), new UIPropertyMetadata(DateTime.Now.TimeOfDay, new PropertyChangedCallback(OnValueChanged)));

		public override TimeSpan Value
		{
			get { return (TimeSpan)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}

		protected override void SetHoursMinutesAndSecondsFromNewValue(TimeSpan newValue)
		{
			this.Hours = newValue.Hours;
			this.Minutes = newValue.Minutes;
			this.Seconds = newValue.Seconds;
		}
	}
}
