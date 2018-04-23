using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
		public MenuView ()
		{
			InitializeComponent ();
            this.BindingContext = new Class.MenuViewModel();
		}

        private void Listview_Onclicked(object sender, EventArgs e)
        {
            if(Mylistview.SelectedItem==null)
            {
                return;
            }

            Mylistview.SelectedItem = null;
        }

        private void OnBookingView(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MainView mainView)
            {
                if (mainView.Detail is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new View.BookingView());
                    mainView.IsPresented = false;
                }
            }
        }

    }
}