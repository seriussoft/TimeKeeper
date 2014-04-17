using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using TimeKeeper.Models.SQLite;
using TimeKeeper.Models.Generic;

namespace TimeKeeper.ViewModels
{
	public class ActivityViewModel : BaseViewModel
	{
		private ActivityModel _model;
		protected internal ActivityModel Model
		{
			get { return this._model; }
			set { this._model = value; }
		}

		public override bool IsNew { get { return this.Model == null; } }

		public long ID
		{
			get { return this.Model.ID; }
			set { this.Model.ID = value; }
		}

		public string Name
		{
			get { return this.Model.Name; }
			set { this.Model.Name = value; }
		}

		public string Path
		{
			get { return this.Model.Path; }
			set { this.Model.Path = value; }
		}

		public ActivityViewModel()
		{
			this.Model = new ActivityModel();
		}

		protected internal ActivityViewModel(ActivityModel model)
		{
			this.Model = model;
		}
	}
}
