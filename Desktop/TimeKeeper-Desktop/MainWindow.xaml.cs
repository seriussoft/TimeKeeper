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
using System.Windows.Interactivity;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls;
using TimeKeeper.ViewModels;
using TimeKeeper_Desktop.LocalViewModels;

namespace TimeKeeper_Desktop
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : MetroWindow
  {
		

    public MainWindow()
    {
			var collection = CreateEntryCollection(4);
			this.DataContext = new EntriesCollectionViewModel(collection);

      InitializeComponent();

      //AddWindowBehaviors();
    }

		private IEnumerable<EntryViewModel> CreateEntryCollection(int numberOfEntries)
		{
			var entries =
				Enumerable.Range(0, numberOfEntries)
				.Select
				(
					i => new EntryViewModel()
					{
						ID = i,
						StartDate = DateTime.MinValue,
						EndDate = DateTime.MinValue.AddHours(i),
						Description = String.Concat("Description - ", i),
						Activity = new ActivityViewModel()
						{
							ID = i,
							Name = String.Concat("Activity-",i)
						}
					}
				);

			return entries.ToList();
		}

    private void AddWindowBehaviors()
    {
      var windowBehavior = new BorderlessWindowBehavior() { EnableDWMDropShadow = true, AllowsTransparency = false, ResizeWithGrip = true };
      var behaviors = Interaction.GetBehaviors(this);
      behaviors.Add(windowBehavior);
    }
  }
}
