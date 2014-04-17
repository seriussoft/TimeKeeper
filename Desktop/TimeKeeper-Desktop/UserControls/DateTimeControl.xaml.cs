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
	/// Interaction logic for DateTimeControl.xaml
	/// </summary>
	public partial class DateTimeControl : BaseTimeControl<DateTime>
	{
		public DateTimeControl() : base()
		{
			InitializeComponent();
		}

		protected override DateTime CreateValue(int hours, int minutes, int seconds)
		{
			return new DateTime(1, 1, 1, hours, minutes, seconds);
		}

		public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(DateTime), typeof(DateTimeControl), new UIPropertyMetadata(DateTime.Now, new PropertyChangedCallback(OnValueChanged)));

		public override DateTime Value
		{
			get { return (DateTime)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}

		protected override void SetHoursMinutesAndSecondsFromNewValue(DateTime newValue)
		{
			this.Hours = newValue.Hour;
			this.Minutes = newValue.Minute;
			this.Seconds = newValue.Second;
		}

	}

	
}
