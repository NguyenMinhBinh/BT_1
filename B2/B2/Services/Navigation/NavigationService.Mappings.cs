using B2.ViewModels;
using B2.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using B2.Class;
using B2.View;

namespace B2.Services.Navigation
{
    public partial class NavigationService

    {

        private void Mappings()

        {

            Map<LoginViewModel, Login>();
            Map<MainViewModel, MainView>();

        }



        private void Map<TViewModel, TView>()

            where TViewModel : ViewModelBase

            where TView : Page

        {

            _mappings.Add(typeof(TViewModel), typeof(TView));

        }

    }
}
