using System;
using System.Collections.Generic;
using NewControlsDemo.Models;
using Xamarin.Forms;

namespace NewControlsDemo.Views
{
    public partial class BreadCrumbPage : ContentPage
    {
        public BreadCrumbPage()
        {
            InitializeComponent();
        }

        void CustomTabsView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var item = e.CurrentSelection;
            Product p = new Product();
            for (int i = 0; i < item.Count; i++)
            {
                p = item[i] as Product;
            }
            CustomTabsView.ScrollTo(p, null, ScrollToPosition.Center, true);
            
        }
    }
}
