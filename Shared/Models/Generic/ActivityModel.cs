using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Models.Generic
{
	public class ActivityModel
	{
		[System.ComponentModel.DataAnnotations.Required()]
		public virtual long ID { get; set; }

		[System.ComponentModel.DataAnnotations.Required()]
		public virtual string Name { get; set; }

		[System.ComponentModel.DataAnnotations.Required()]
		public virtual string Path { get; set; }
	}
}
