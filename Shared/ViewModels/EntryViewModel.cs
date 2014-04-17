using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using TimeKeeper.Models.SQLite;
using TimeKeeper.Models.Generic;

namespace TimeKeeper.ViewModels
{
	public class EntryViewModel : BaseViewModel
	{
		private EntryModel _model;
		protected internal EntryModel Model
		{
			get { return this._model; }
			set
			{
				this._model = value;
				this._activity = new ActivityViewModel(value.Activity);
				RaisePropertyChanged();
			}
		}

		#region Public Properties

		public long ID
		{
			get { return this.Model.ID; }
			set
			{
				this.Model.ID = value;
				RaisePropertyChanged();
			}
		}

		public DateTime? StartDate
		{
			get { return this.Model.StartDate; }
			set
			{
				this.Model.StartDate = value;
				RaisePropertyChanged();

				UpdateSubTotalTime();
			}
		}

		public DateTime? EndDate
		{
			get { return this.Model.EndDate; }
			set
			{
				this.Model.EndDate = value;

				RaisePropertyChanged();
				UpdateSubTotalTime();
			}
		}

		public TimeSpan? SubTotalTime
		{
			get { return GetTimeSpan(this.Model.SubTotalTime); }
			private set
			{
				var timespan = value;
				this.Model.SubTotalTime = GetTicks(timespan);

				RaisePropertyChanged();
				UpdateTotalTime();
			}
		}

		public TimeSpan? TotalTime
		{
			get { return GetTimeSpan(this.Model.TotalTime); }
			private set
			{
				var timespan = value;
				this.Model.TotalTime = GetTicks(timespan);

				RaisePropertyChanged();
			}
		}

		public TimeSpan? BreakTime
		{
			get { return GetTimeSpan(this.Model.BreakTime); }
			set
			{
				var timespan = value;
				this.Model.BreakTime = GetTicks(timespan);

				RaisePropertyChanged();
				UpdateTotalTime();
			}
		}

		public string Description
		{
			get { return this.Model.Description; }
			set
			{
				this.Model.Description = value;
				RaisePropertyChanged();
			}
		}

		private ActivityViewModel _activity;
		public ActivityViewModel Activity
		{
			get { return this._activity; }
			set
			{
				var activity = value;
				this._activity = activity;
				this.Model.Activity = activity.Model;
				RaisePropertyChanged();
			}
		}

		#endregion Public Properties

		#region Constructors

		public EntryViewModel()
		{
			this.Model = new EntryModel();
		}

		protected internal EntryViewModel(EntryModel model)
		{
			this.Model = model;
		}

		#endregion	Constructors

		#region Helper Methods

		private TimeSpan? GetTimeSpan(long? ticks)
		{
			if (!ticks.HasValue)
				return null;

			return TimeSpan.FromTicks(ticks.Value);
		}

		private long? GetTicks(TimeSpan? timespan)
		{
			if (!timespan.HasValue)
				return null;

			return timespan.Value.Ticks;
		}

		protected void UpdateSubTotalTime()
		{
			var startTime = this.StartDate;
			var endTime = this.EndDate;

			TimeSpan? subTotalTime = null;

			if (startTime.HasValue && endTime.HasValue)
			{
				subTotalTime = endTime.Value.Subtract(startTime.Value);
			}
			else
			{
				subTotalTime = null;
			}
			
			this.SubTotalTime = subTotalTime;
		}

		protected void UpdateTotalTime()
		{
			var defaultTimeIfMissing = DateTime.Now;
			var defaultTimeMin = DateTime.MinValue;

			var subTotal = this.SubTotalTime;
			var breakTime = this.BreakTime;

			TimeSpan? totalTime = null;

			if (subTotal.HasValue && breakTime.HasValue)
			{
				totalTime = subTotal.Value.Subtract(breakTime.Value);
			}
			else if (subTotal.HasValue)
			{
				totalTime = subTotal;
			}
			else
			{
				totalTime = null;
			}
			
		}

		#endregion	Helper Methods
	}
}
