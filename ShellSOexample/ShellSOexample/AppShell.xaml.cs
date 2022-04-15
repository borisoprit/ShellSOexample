
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
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ItemDetailPage");
            Shell.Current.FlyoutIsPresented = false;

        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
             Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
         

            await Shell.Current.GoToAsync("SettingsPage");
         
            Shell.Current.FlyoutIsPresented = false;
         
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            /// do stuff what you want
        }

    }
}
