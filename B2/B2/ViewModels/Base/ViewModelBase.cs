using System;
using System.Collections.Generic;
using System.Text;
using B2.MVVM;
using B2.Services.Navigation;

namespace B2.ViewModels.Base
{
    public class ViewModelBase : BindableBase
    {
        private string _title;
        private bool _isBusy;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        protected INavigationService NavigationService { get; }

        public ViewModelBase()
        {
            NavigationService = ServiceLocator.Instance.Resolve<INavigationService>();
        }
    }
}
