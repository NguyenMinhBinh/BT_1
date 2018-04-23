using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using B2.Services;

namespace B2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : MasterDetailPage
    {
		public MainView ()
		{
			InitializeComponent ();
            var service = DependencyService.Get<IEmailservices>();
            service.Send("mail", "title", "content");
            //btn_back.Clicked += back_click;
        }

        //xóa page ở vị trí [0] trở về trước trong navigation(khi back đến trang đó thì ko back dc nữa
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    //kiểm tra vị trí page [0] phải trang Login ko?
        //    if (Navigation.NavigationStack[0] is Login)
        //        Navigation.RemovePage(Navigation.NavigationStack[0]);
        //}

        private void back_click(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
	}
}