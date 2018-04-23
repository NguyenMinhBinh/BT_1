using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B2.Services.Navigation;
using B2.Class;

using Xamarin.Forms;

namespace B2
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

       //     MainPage = new B2.View.Login();
            //MainPage = new B2.MasterPage.MasterDetailPage1();
            //MainPage = new B2.Class.AstronomyMasterDetailPage();

            ServiceLocator.Instance.Build();

            ServiceLocator.Instance.Resolve<INavigationService>().NavigateToAsync<LoginViewModel>();

            //tạo nền để back
            //MainPage = new NavigationPage(new View.Login());

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
