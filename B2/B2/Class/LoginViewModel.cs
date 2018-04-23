using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using B2.ViewModels.Base;
using B2.View;
using B2.MVVM.Commands;
using B2.Services.Navigation;
using Plugin.Media;
using System.Threading.Tasks;
using Plugin.Media.Abstractions;

namespace B2.Class
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;

        private string _password;

        private string _passwordstrength;

        public Image _image;

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value, () => { LoginCommand.RaiseCanExecuteChanged(); });
        }

        public string Password
        {
            get => _password;
            //set
            //{
            //    if (_password != value)
            //    {
            //        _password = value;
            //        //PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Password"));
            //        RaisePropertyChanged(nameof(Password));
            //        if (_password != null && _password.Length > 6)
            //            PasswordStreng = "Good";
            //        else PasswordStreng = "Bad";
            //    }
            //}
            set => SetProperty(ref _password, value, () => { LoginCommand.RaiseCanExecuteChanged(); });
        }

        public Image Image
        {
            get => _image;
            set
            {
                if (_image != value)
                {
                    _image = value;
                    //PropertyChanged.Invoke(this, new PropertyChangedEventArgs("_passwordstrength"));
                    //RaisePropertyChanged(nameof(Image));
                }
            }
         }

        public void SetUserName(string value)
        {
            Username = value;
        }

        public string PasswordStreng
        {
            get => _passwordstrength;
            set
            {
                if (_passwordstrength != value)
                {
                    _passwordstrength = value;
                    //PropertyChanged.Invoke(this, new PropertyChangedEventArgs("_passwordstrength"));
                    RaisePropertyChanged(nameof(PasswordStreng));
                }
            }
        }

        public DelegateCommand LoginCommand { get; }

        public DelegateCommand PhotoCommand { get; }

        private void Login()
        {
            NavigationService.NavigateToAsync<MainViewModel>();
        }

        private async void Photo()
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsPickPhotoSupported || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", "  No supported.", "OK");

            }
            else
            {
                var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {

                    Directory = "Images",
                    Name = DateTime.Now.ToString() + "test.jpg"
                });
                if (file == null) return;
                //await DisplayAlert("Warning", file.Path, "OK");
                //Image.Source = ImageSource.FromStream(() =>
                //{
                //    var stream = file.GetStream();
                //    return stream;
                //});
            }
        }

        private Task DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public LoginViewModel ()
        {
            LoginCommand = new DelegateCommand(Login, CanLogin).ObservesProperty(() => Username).ObservesProperty(() => Password);
            PhotoCommand = new DelegateCommand(Photo);
        }

        //trả trạng thái pass và user có null ko để cho ấn và ko ấn Login
        private bool CanLogin()
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }


    }
}
