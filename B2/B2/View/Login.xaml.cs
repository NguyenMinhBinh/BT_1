using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using B2.Class;
using Acr.UserDialogs;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace B2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        private LoginViewModel LoginViewModel { get; }
        public Login ()
		{
			InitializeComponent ();
            //tắt master trên navigation
            NavigationPage.SetHasNavigationBar(this, false);
            //
            LoginViewModel = new Class.LoginViewModel();
            LoginViewModel.Username = "admin";
            LoginViewModel.Password = "123";
           
            this.BindingContext = LoginViewModel;
            //LoginViewModel.SetUsername("admin");

            //btn_Login.Clicked += SignIn_Click;
            //btn_Photo.Clicked += Photo_Click;
        }
        

        //navigation là 1 hệ thống các trang đã mở và dùng để bấm back lại trang trước
        //private async void SignIn_Click(object sender, EventArgs e)
        //{
        //    if (user.Text == "admin" && pass.Text == "123")
        //    {
        //        UserDialogs.Instance.ShowLoading();
        //        await Task.Delay(2000);

        //        //DisplayAlert("THÔNG BÁO","THÀNH CÔNG","ĐÓNG");

        //        //chuyển trang ko back về trang trước vứt hết những trang trước đó hoàn toàn ko back dc
        //        MainView mv = new MainView();
        //        Application.Current.MainPage = mv;

        //        UserDialogs.Instance.HideLoading();
        //        //chuyền trang back lại dc
        //        //Navigation.PushAsync(new MainView());
        //    }
        //}
       
        //private async void Photo_Click(object sender, EventArgs e)
        //{
        //    await CrossMedia.Current.Initialize();
        //    if (!CrossMedia.Current.IsPickPhotoSupported || !CrossMedia.Current.IsTakePhotoSupported)
        //    {
        //        await DisplayAlert("No Camera", "  No supported.", "OK");

        //    }
        //    else
        //    {
        //        var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
        //        {

        //            Directory = "Images",
        //            Name = DateTime.Now.ToString() + "test.jpg"
        //        });
        //        if (file == null) return;
        //        await DisplayAlert("Warning", file.Path, "OK");
        //        MyImage.Source = ImageSource.FromStream(() =>
        //        {
        //            var stream = file.GetStream();
        //            return stream;
        //        });
        //    }

        //}
        }
    }