using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A018_ClassBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 클래스를 사용하자
            // 클래스의 객체(개체), object/instance를 만들어서 사용한다
            Car x = new Car();
            x.setInTime();
            //...
            x.setOutTime();
            //x.setCarColor (1);
            x.CarColor = 1;
            Console.WriteLine(Math.Sin(Math.PI));

        }
    }

    class Car
    {
        private int carNumber;
        private DateTime inTime;   // 들어오는 시간
        private DateTime outTime;  // 나가는 시간
        //private int carColor;
        public int CarColor { set; get; } // 속성

        public void setInTime()
        {
            this.inTime = DateTime.Now;
        }
        public void setOutTime()
        {
            this.outTime = DateTime.Now;
        }
        //public void setCarColor(int color)
        //{
        //    carColor = color;
        //}

    }
}
