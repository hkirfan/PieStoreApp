using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PieStoreApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PieStoreApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : MasterDetailPage
	{
		public MainView ()
		{
			InitializeComponent ();

		    MasterView.NavigationListView.ItemSelected += NavigationListView_ItemSelected;
        }

	    private void NavigationListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        if (e.SelectedItem is MasterNavigationItem item)
	        {
	            Detail = new NavigationPage((Page)Activator.CreateInstance(item.Target));
	            MasterView.NavigationListView.SelectedItem = null;
	            IsPresented = false;
	        }
	    }
    }
}