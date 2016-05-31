using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;

namespace S3A1NavigationServicesDemoApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        //
        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            //Pipeline is more reliable here than in OnNavigatedTo() on MainPage.xaml.cs.

            //IDictionary<string, object> state (i.e. suspended)
            if (state.Any())
            {
                //Key; being resumed from termination
            }
            var key = parameter as string;
            if (SessionState.ContainsKey(key))
            {
                //Just use key to restore data from suspension
            }
            else
            {
                //Get the key the hard way, from somewhere else.
            }

            //Passing in object parameter TheTest
            //var x = parameter as string;

            //NavigationMode mode parameter
            mode = NavigationMode.Back;

            return base.OnNavigatedToAsync(parameter, mode, state);
        }

        public override Task OnNavigatedFromAsync(IDictionary<string, object> pageState, bool suspending)
        {
            //Navigate away from your ViewModel to another page.

            //Logic for suspending
            if (suspending)
            {
                //Save properties into this so that when you resume, you can fill them in again.
                //Saving transitory states, not data in the database.
                pageState["FirstName"] = "Denise";
            }

            return base.OnNavigatedFromAsync(pageState, suspending);
        }

        public override Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            //Navigation has not occurred yet
            args.Cancel = true;

            return base.OnNavigatingFromAsync(args);
        }
    }
}

