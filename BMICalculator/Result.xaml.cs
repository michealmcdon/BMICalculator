using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BMICalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Result : Page
    {
        public Result()
        {
            this.InitializeComponent();
            showBMIResults();
        }

        private void showBMIResults()
        {
            Results.Text = "" + String.Format("{0:00.00}", App.BMICalc);
            if (App.BMICalc < 20)
            {
                YouAre.Text = "You are too skinny... get a burger!";
            }
            else if (App.BMICalc < 25)
            {
                YouAre.Text = "You're healthy... Good job!";
            }
            else if (App.BMICalc <= 30)
            {
                YouAre.Text = "You are getting fat, eat a salad!";
            }
            else if (App.BMICalc < 40)
            {
                YouAre.Text = "You are getting really fat, eat alot less!";
            }
            else if (App.BMICalc > 40)
            {
                YouAre.Text = "You are extremely Obese, stop eating and start running!";
            }


        }

        private void ButtonEntry_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}

