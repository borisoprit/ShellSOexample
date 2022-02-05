using ShellSOexample.Services;
using ShellSOexample.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSOexample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            Shell.Current.FlyoutIsPresented = true;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
