using sample.Data;
using sample.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace sample.ViewModel
{

    
    public class MainPageViewModel : INotifyPropertyChanged
    {

        



        public MainPageViewModel()
        {
            
        }

        public ICommand ImageTapped => new Command(async (object sender) => 
        {
            Debug.WriteLine("Something something");

            string s = sender as string;
            Debug.WriteLine(s);
            await Browser.OpenAsync(s, BrowserLaunchMode.SystemPreferred); 
            

        });


        public Command StandardCalcCommand => new Command(async () => 
        {
            await App.Current.MainPage.Navigation.PushAsync(new StandardCalculation());
        });
        public Command AdvancedCalcCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new AdvancedCalculation());
        });

        #region INotifyPropertyChanged 
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


    }
}
