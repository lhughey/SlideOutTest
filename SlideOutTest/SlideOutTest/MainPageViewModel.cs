using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Xamarin.Forms;

namespace SlideOutTest
{
    public class MainPageViewModel : ReactiveObject
    {
        public ICommand FavoritePatientCommand { get; }
        public ICommand AlertCommand { get; }

        [Reactive] public bool IsBusy { get; set; }

        public MainPageViewModel()
        {
            FavoritePatientCommand =
                ReactiveCommand.CreateFromTask(execute: async () => await FavoriteAction()); //.OnExecuting(b => IsBusy = b);

            AlertCommand = new Command(async () =>
            {
                await UserDialogs.Instance.AlertAsync("Alert Command Pressed", "Alert");
            });
        }


        public async Task FavoriteAction()
        {
            await UserDialogs.Instance.AlertAsync("Favorited Command", "Alert");
            //Load the 
        }
    }
}
