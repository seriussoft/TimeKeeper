using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TimeKeeper.GenericUserControls
{
	/// <summary>
	/// Interaction logic for TimeControl.xaml
	/// </summary>
	public class BaseTimeControl<T> : UserControl where T : new()
	{
		public BaseTimeControl()
		{
			//InitializeComponent();
		}

		public virtual T Value { get; set; }
		//{
		//	get { return (T)GetValue(ValueProperty); }
		//	set { SetValue(ValueProperty, value); }
		//}

		public int Hours
		{
			get { return (int)GetValue(HoursProperty); }
			set { SetValue(HoursProperty, value); }
		}

		public int Minutes
		{
			get { return (int)GetValue(MinutesProperty); }
			set { SetValue(MinutesProperty, value); }
		}

		public int Seconds
		{
			get { return (int)GetValue(SecondsProperty); }
			set { SetValue(SecondsProperty, value); }
		}

		protected virtual T CreateValue(int hours, int minutes, int seconds) { return default(T); }

		protected void Down(object sender, KeyEventArgs args)
		{
			switch (((Grid)sender).Name)
			{
				case "sec":
					if (args.Key == Key.Up)
						this.Seconds++;
					if (args.Key == Key.Down)
						this.Seconds--;
					break;

				case "min":
					if (args.Key == Key.Up)
						this.Minutes++;
					if (args.Key == Key.Down)
						this.Minutes--;
					break;

				case "hour":
					if (args.Key == Key.Up)
						this.Hours++;
					if (args.Key == Key.Down)
						this.Hours--;
					break;
			}
		}

		//public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(T), typeof(BaseTimeControl<T>), new UIPropertyMetadata(DateTime.Now.TimeOfDay, new PropertyChangedCallback(OnValueChanged)));
		public static readonly DependencyProperty HoursProperty = DependencyProperty.Register("Hours", typeof(int), typeof(BaseTimeControl<T>), new UIPropertyMetadata(0, new PropertyChangedCallback(OnTimeChanged)));
		public static readonly DependencyProperty MinutesProperty = DependencyProperty.Register("Minutes", typeof(int), typeof(BaseTimeControl<T>), new UIPropertyMetadata(0, new PropertyChangedCallback(OnTimeChanged)));
		public static readonly DependencyProperty SecondsProperty = DependencyProperty.Register("Seconds", typeof(int), typeof(BaseTimeControl<T>), new UIPropertyMetadata(0, new PropertyChangedCallback(OnTimeChanged)));

		public static void OnValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
		{
			var control = obj as BaseTimeControl<T>;
			var newValue = (T)e.NewValue;
			control.SetHoursMinutesAndSecondsFromNewValue(newValue);
			//control.Hours = ((dynamic)e.NewValue).Hours;
			//control.Minutes = ((dynamic)e.NewValue).Minutes;
			//control.Seconds = ((dynamic)e.NewValue).Seconds;
		}

		protected virtual void SetHoursMinutesAndSecondsFromNewValue(T newValue) { ; }

		//protected abstract int GetHours(T newValue);
		//protected abstract int GetMinutes(T newValue);
		//protected abstract int GetSeconds(T newValue);

		public static void OnTimeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
		{
			var control = obj as BaseTimeControl<T>;
			control.Value = control.CreateValue(control.Hours, control.Minutes, control.Seconds);
		}

	}
}
