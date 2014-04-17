using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Models.Generic
{
	public class EntryModel
	{
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual long ID { get; set; }

		[System.ComponentModel.DataAnnotations.Required()]
		public virtual DateTime? StartDate { get; set; }

		[System.ComponentModel.DataAnnotations.Required()]
		public virtual DateTime? EndDate { get; set; }

		[System.ComponentModel.DataAnnotations.Required()]
		public virtual long? TotalTime { get; set; }

		[System.ComponentModel.DataAnnotations.Required()]
		public virtual long? SubTotalTime { get; set; }

		[System.ComponentModel.DataAnnotations.Required()]
		public virtual long? BreakTime { get; set; }

		[System.ComponentModel.DataAnnotations.Required()]
		public virtual string Description { get; set; }

		public virtual ActivityModel Activity { get; set; }
	}
}
