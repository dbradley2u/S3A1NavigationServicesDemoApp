using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Data;

namespace S3A1NavigationServicesDemoApp
{
    /// Documentation on APIs used in this page:
    /// https://github.com/Windows-XAML/Template10/wiki

    [Bindable]
    sealed partial class App : Template10.Common.BootStrapper
    {
        public App() { InitializeComponent(); }

        public override async Task OnInitializeAsync(IActivatedEventArgs args)
        {
            await Task.CompletedTask;
        }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            //This is the first Navigation Service; property of Bootstrapper.
            //First arguement is a type (typeof) or enumeration
            //Second arguement is an object parameter that is serialize-able (i.e. ).
            //Third arguement in infoOverride.  When you navigate to a page and there is a transition animation that occurs, 
            //   (by default it in the entrance animation), you can pass that animation here.
            NavigationService.Navigate(typeof(Views.MainPage), "TheTest");
            await Task.CompletedTask;
        }
    }
}

