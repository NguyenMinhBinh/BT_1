using B2.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using B2.View;

namespace B2.Services.Navigation
{
    public partial class NavigationService : INavigationService
    {
        private readonly Dictionary<Type, Type> _mappings;

        public NavigationService()
        {
            _mappings = new Dictionary<Type, Type>();

            Mappings();
        }

        public Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase
        {
            return NavigateToAsync(typeof(TViewModel), null);
        }

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            return NavigateToAsync(typeof(TViewModel), parameter);
        }

        public Task NavigateToAsync(Type viewModelType)
        {
            return NavigateToAsync(viewModelType, null);
        }

        public Task NavigateToAsync(Type viewModelType, object parameter)
        {
            var pageType = _mappings[viewModelType];
            var page = (Page)Activator.CreateInstance(pageType);
            if (page is Login)
            {
                Application.Current.MainPage = new NavigationPage(page);  
            }
            else
            {
                if (page is MainView) Application.Current.MainPage = page;
            }

            return Task.CompletedTask;
            throw new NotImplementedException();
        }

        public Task NavigateBackAsync()
        {
            throw new NotImplementedException();
        }
    }
}
