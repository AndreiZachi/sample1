using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace sample.Data
{
    public class StandardCalList : ObservableCollection<Template>
    {
        public ObservableCollection<string> CableDiameter { get; set; }
        public ObservableCollection<string> Voltage { get; set; }
        public ObservableCollection<string> Distance { get; set; }
        public ObservableCollection<string> LEDsCurrent { get; set; }
        public ObservableCollection<string> CurrentRange { get; set; }

        
       
        public StandardCalList()
        {
            
            InitList();



            Add(new Template { lblTitle="1", picker = CableDiameter });
            Add(new Template { lblTitle = "2", picker = Voltage });
            Add(new Template { lblTitle = "3", picker = Distance });
            Add(new Template { lblTitle = "4", picker = LEDsCurrent });
            Add(new Template { lblTitle = "5", picker = CurrentRange });

        }

        private void InitList()
        {
 
            CableDiameter = new ObservableCollection<string>() {
                "9 / 6.63mm2" ,
                "10 / 5.26mm2" ,
                "12 / 3.31mm2" ,
                "15 / 1.65mm2" ,
                "16 / 1.31mm2" ,
                "18 / 0.823mm2" ,
                "22 / 0.326mm2" ,
                "24 / 0.205mm2" ,
                "26 / 0.129mm2"  };

            Voltage = new ObservableCollection<string>() {
                "12 V" ,
                "24 V" ,
                "46.25 V" ,
                "47 V" ,
                "48 V"  };

            Distance = new ObservableCollection<string>() {
                "20m" ,
                "50m" ,
                "100m" ,
                "250m" ,
                "500m"  };

            LEDsCurrent = new ObservableCollection<string>() {
                "350 mA" ,
                "500 mA" ,
                "650 mA" ,
                "700 mA" ,
                "750 mA" ,
                "1000 mA" ,
                "1050 mA"  };

        CurrentRange = new ObservableCollection<string>() {
                "±50 mA" ,
                "±100 mA" ,
                "±300 mA" ,
                "±500 mA" ,
                "±1000 mA" ,
                "±2000 mA" ,
                "±4000 mA"  };

        }
    }
}
