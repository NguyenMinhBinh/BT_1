using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B2.MasterPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage1MenuItem;
            if (item == null)
                return;
            else
            {
                var page = (Page)Activator.CreateInstance(item.TargetType);
                Label lb1 = page.FindByName<Label>("lb");
                lb1.Text = "Master Detail Page";
                switch (item.Id)
                {
                    case 3:
                        page = new B2.View.Login();
                        break;
                    case 0:
                        page.BackgroundColor = Xamarin.Forms.Color.Yellow;                        
                        lb1.Text= "Yellow";
                        break;
                    case 1:
                        page.BackgroundColor = Xamarin.Forms.Color.Black;
                        lb1.Text = "Black";
                        lb1.TextColor = Xamarin.Forms.Color.White;
                        break;
                    case 2:
                        page.BackgroundColor = Xamarin.Forms.Color.Blue;
                        lb1.Text = "Blue";
                        break;
                }
                page.Title = item.Title;

                Detail = new NavigationPage(page);
                IsPresented = false;

                MasterPage.ListView.SelectedItem = null;
            }                    
        }
    }
}