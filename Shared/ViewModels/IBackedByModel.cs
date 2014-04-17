using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeKeeper.ViewModels
{
	public interface IBackedByModel
	{
		bool IsNew { get; }
		bool IsBacked { get; set; }
	}
}
