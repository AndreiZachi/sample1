using sample.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace sample.ViewModel
{
    public class StandardCalculationViewModel : INotifyPropertyChanged
    {
        private StandardCalList _standardCol = new StandardCalList();
        public StandardCalList standardCol { get
            { return _standardCol; }
            set { _standardCol = value; OnPropertyChanged(); } }


        public StandardCalculationViewModel()
        {

           

        }


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
