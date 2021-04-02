using System;
using NewControlsDemo.Services;
using Prism.Navigation;

namespace NewControlsDemo.ViewModels
{
    public class WebUrlTestPageViewModel : BaseViewModel
    {
        public WebUrlTestPageViewModel(INavigationService navigationService, FacadeService facadeService)
             : base(navigationService, facadeService)
        {
            //AccountPageURL = "http://54.244.107.179/Plaid/Plaid"; //"http://34.216.71.66/Plaid/Plaid";
            AccountPageURL = "https://us04web.zoom.us/j/9218226818?pwd=ZmdXcjJ3Z2RqcUE4UzBmVnhwWUNsdz09";
        }

        private string _accountPageURL;
        public string AccountPageURL
        {
            get { return _accountPageURL; }
            set { SetProperty(ref _accountPageURL, value); }
        }

    }
}