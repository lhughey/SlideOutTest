using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SlideOutTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //BindingContext = new MainPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //((MainPageViewModel)BindingContext).AlertCommand.Execute(0);
        }

        private void SwipeView_OnSwipeStarted(object sender, SwipeStartedEventArgs e)
        {
            
            var x = ((SwipeView) sender);
            var y = e.SwipeDirection;
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var x = ((SwipeView) sender);
            var y = e;
        }
    }
}
