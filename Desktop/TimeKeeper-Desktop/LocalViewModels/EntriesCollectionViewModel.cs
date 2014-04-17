using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeKeeper.ViewModels;

namespace TimeKeeper_Desktop.LocalViewModels
{
	public class EntriesCollectionViewModel : BaseViewModel
	{
		private ObservableCollection<EntryViewModel> _entries;
		public ObservableCollection<EntryViewModel> Entries 
		{
			get { return this._entries; }
			set
			{
				this._entries = value;
				RaisePropertyChanged();
			}
		}

		public EntriesCollectionViewModel()
		{
			this.Entries = new ObservableCollection<EntryViewModel>();
		}

		public EntriesCollectionViewModel(IEnumerable<EntryViewModel> entries)
		{
			this.Entries = new ObservableCollection<EntryViewModel>(entries);
		}

		public void AddEntry(EntryViewModel entry)
		{
			if(entry != null)
				this.Entries.Add(entry);
		}

		public void RemoveEntry(long entryID)
		{
			var entryToRemove = this.Entries.FirstOrDefault(entry => entry.ID == entryID);
			RemoveEntry(entryToRemove);
		}

		public void RemoveEntry(EntryViewModel entry)
		{
			if(entry != null)
				this.Entries.Remove(entry);
		}
	}
}
