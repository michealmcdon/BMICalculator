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



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BMICalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Windows.Storage.ApplicationDataContainer localSettings =
            Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;

        public MainPage()
        {
            this.InitializeComponent();

            
        }

        private void ButtonEntry_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                double weight = Double.Parse(WeightEntry.Text);
                localSettings.Values["weight"] = weight;
                double height = Double.Parse(HeightEntry.Text);
                localSettings.Values["height"] = height;
                double BMI = weight / (height * height);
                App.BMICalc = BMI;
                localSettings.Values["BMI"] = BMI;
                this.Frame.Navigate(typeof(Result), null);
            } catch (Exception Error){}
        }
    }
}
