using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    class Radio
    {
        private double Frequency;
        private bool TurnedOn = false;
        private Dictionary<int, double> List;
        private int total = 0;

        public void TurnOn(bool a)
        {
            if (a==true)
            {
                TurnedOn = true;
            }
            else
            {
                TurnedOn = false;
            }
        }

        public void SetFrequencyToList(int a, double freq)
        {
            if (total == 0)
            {
                List = new Dictionary<int, double>();
                List.Add(a, freq);
                total++;

            }
            else
            {
                List.Add(a, freq);
                total++;
            }  
        }

        public void ChooseStation(int a)
        {
            if (a<=total)
            {
                Frequency = List[a];
            }
        }

        public void ManualStation(double freq)
        {
                Frequency = freq;
        }

        public override string ToString()
        {
            if (TurnedOn == true)
            {
                return String.Format($"Frequency:{Frequency} MHz");
            }
            else
            {
                return String.Format("------");
            }
                
        }

    }
}
