using sample.Data;
using sample.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;



namespace sample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            
            InitializeComponent();
            BindingContext = new MainPageViewModel();
            carousel.ItemsSource = new AssetList();
            Play();


        }

        private void Play()
        {
            var s = new AssetList();
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {

                carousel.Position = (carousel.Position + 1) % s.Count;
                return true;
            }));
        }

    }

    
}
