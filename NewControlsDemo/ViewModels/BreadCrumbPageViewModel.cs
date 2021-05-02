using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using NewControlsDemo.Models;
using NewControlsDemo.Services;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms.Internals;

namespace NewControlsDemo.ViewModels
{
    public class BreadCrumbPageViewModel : BaseViewModel
    {
        ProductService ProductService = new ProductService();
        public ObservableCollection<Product> MenuItems { get; set; }

        public BreadCrumbPageViewModel(INavigationService navigationService, FacadeService facadeService)
            : base(navigationService, facadeService)
        {
            MenuItems = ProductService.GetMenuItemsList();
        }

        private Product _currentTab;
        public Product CurrentTab
        {
            get { return _currentTab; }
            set
            {
                SetProperty(ref _currentTab, value);
                SetSelection();
            }
        }

        private string _selectedItemName;
        public string SelectedItemName
        {
            get { return _selectedItemName; }
            set { SetProperty(ref _selectedItemName, value); }
        }

        private void SetSelection()
        {
            this.MenuItems.ForEach(vm => vm.IsSelected = false);
            this.CurrentTab.IsSelected = true;
            SelectedItemName = this.CurrentTab.ProductName;
        }
    }
}
