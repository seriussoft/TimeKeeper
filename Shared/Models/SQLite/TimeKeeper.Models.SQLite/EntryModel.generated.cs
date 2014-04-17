#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using System.ComponentModel;
using TimeKeeper.Models.SQLite;

namespace TimeKeeper.Models.SQLite	
{
	[Table()]
	public partial class EntryModel : IDataErrorInfo, INotifyPropertyChanging, INotifyPropertyChanged
	{
		private long _iD;
		[Column(IsPrimaryKey = true)]
		[Storage("_iD")]
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual long ID
		{
			get
			{
				return this._iD;
			}
			set
			{
				if(this._iD != value)
				{
					this.OnPropertyChanging("ID");
					this._iD = value;
					this.OnPropertyChanged("ID");
				}
			}
		}
		
		private DateTime? _startDate;
		[Storage("_startDate")]
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual DateTime? StartDate
		{
			get
			{
				return this._startDate;
			}
			set
			{
				if(this._startDate != value)
				{
					this.OnPropertyChanging("StartDate");
					this._startDate = value;
					this.OnPropertyChanged("StartDate");
				}
			}
		}
		
		private DateTime? _endDate;
		[Storage("_endDate")]
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual DateTime? EndDate
		{
			get
			{
				return this._endDate;
			}
			set
			{
				if(this._endDate != value)
				{
					this.OnPropertyChanging("EndDate");
					this._endDate = value;
					this.OnPropertyChanged("EndDate");
				}
			}
		}
		
		private long? _totalTime;
		[Storage("_totalTime")]
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual long? TotalTime
		{
			get
			{
				return this._totalTime;
			}
			set
			{
				if(this._totalTime != value)
				{
					this.OnPropertyChanging("TotalTime");
					this._totalTime = value;
					this.OnPropertyChanged("TotalTime");
				}
			}
		}
		
		private long? _subTotalTime;
		[Storage("_subTotalTime")]
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual long? SubTotalTime
		{
			get
			{
				return this._subTotalTime;
			}
			set
			{
				if(this._subTotalTime != value)
				{
					this.OnPropertyChanging("SubTotalTime");
					this._subTotalTime = value;
					this.OnPropertyChanged("SubTotalTime");
				}
			}
		}
		
		private long? _breakTime;
		[Storage("_breakTime")]
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual long? BreakTime
		{
			get
			{
				return this._breakTime;
			}
			set
			{
				if(this._breakTime != value)
				{
					this.OnPropertyChanging("BreakTime");
					this._breakTime = value;
					this.OnPropertyChanged("BreakTime");
				}
			}
		}
		
		private string _description;
		[Storage("_description")]
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if(this._description != value)
				{
					this.OnPropertyChanging("Description");
					this._description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}
		
		private ActivityModel _activity;
		[ForeignKeyAssociation(IsManaged = true)]
		[Storage("_activity")]
		public virtual ActivityModel Activity
		{
			get
			{
				return this._activity;
			}
			set
			{
				if(this._activity != value)
				{
					this.OnPropertyChanging("Activity");
					this._activity = value;
					this.OnPropertyChanged("Activity");
				}
			}
		}
		
		#region IDataErrorInfo members
		
		[Transient()]
		private string error = string.Empty;
		[Transient()]
		public string Error
		{
			get
			{
				return this.error;
			}
		}
		
		[Transient()]
		public string this[string propertyName]
		{
			get
			{
				this.ValidatePropertyInternal(propertyName, ref this.error);
		
				return this.error;
			}
		}
		
		protected virtual void ValidatePropertyInternal(string propertyName, ref string error)
		{
		    this.ValidateProperty(propertyName, ref error);
		}
		
		// Please implement this method in a partial class in order to provide the error message depending on each of the properties.
		partial void ValidateProperty(string propertyName, ref string error);
		
		#endregion
		
		#region INotifyPropertyChanging members
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		protected virtual void OnPropertyChanging(string propertyName)
		{
			if(this.PropertyChanging != null)
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		#endregion
		
		#region INotifyPropertyChanged members
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if(this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		#endregion
		
	}
}
#pragma warning restore 1591