using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace sample.Data
{
    public class AdvancedCalList : ObservableCollection<string>
    {
        public ObservableCollection<string> CableDiameter;
        public ObservableCollection<string> Current;
        public ObservableCollection<string> Voltage;
        public ObservableCollection<string> driverVoltage;
        public ObservableCollection<string> Distance;
        public ObservableCollection<string> DistanceRange;
        public AdvancedCalList()
        {
            InitList();

            //Add(new Template { lblTitle = "Cable AWG / Diameter", picker = CableDiameter });
            //Add(new Template { lblTitle = "LED's forward Current", picker = Current });
            //Add(new Template { lblTitle = "Forward Voltage per LED", picker = Voltage });
            //Add(new Template { lblTitle = "Max driver Voltage", picker = driverVoltage });
            //Add(new Template { lblTitle = "Distance", picker = Distance });
            //Add(new Template { lblTitle = "Distance range (option)", picker = DistanceRange });
        }

        private void InitList()
        {
            CableDiameter = new ObservableCollection<string>() { "9 / 6.63mm2", "10 / 5.26mm2", "12 / 3.31mm2", "15 / 1.65mm2", "16 / 1.31mm2", "18 / 0.823mm2", "22 / 0.326mm2", "24 / 0.205mm2", "26 / 0.129mm2" };

            Current = new ObservableCollection<string>() { "350 mA", "500 mA", "650 mA", "700 mA", "750 mA", "1000 mA", "1050 mA" };

            Voltage = new ObservableCollection<string>() { "2.70 V", "2.80 V", "2.90 V", "3.20 V", "3.40 V", "3.50 V", "3.60 V" };

            driverVoltage =new ObservableCollection<string>() { "12 V", "24 V", "46.25 V", "47 V", "48 V" };

            Distance = new ObservableCollection<string>() { "20m", "50m", "100m", "250m", "500m" };

            DistanceRange = new ObservableCollection<string>() { "±10m", "±20m", "±50m", "±100m", "±200m", "±500m"};

        }
    }
}
