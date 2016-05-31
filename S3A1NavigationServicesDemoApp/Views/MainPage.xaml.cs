using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace S3A1NavigationServicesDemoApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //base.OnNavigatedTo(e);

            //To get "TheTest" object passed from App.xaml.cs use the following code
            var x = e.Parameter as string;

            //Since most of our logic will be in the ViewModel, we would set up our code there instead

        }
    }
}
