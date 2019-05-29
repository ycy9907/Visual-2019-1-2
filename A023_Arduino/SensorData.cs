using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A023_Arduino
{
    class SensorData
    {
        public string Date { get; set; } // 속성
        public string Time { get; set; }
        public int Value { get; set; } 

        public SensorData(string d, string t, int v)
        {
            Date = d;
            Time = t;
            Value = v;
        }
    }
}
