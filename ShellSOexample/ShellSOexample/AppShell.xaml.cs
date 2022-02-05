
using ShellSOexample.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShellSOexample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(StartPage), typeof(StartPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ItemDetailPage");
            Shell.Current.FlyoutIsPresented = false;

        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}
