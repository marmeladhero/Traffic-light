using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Traffic_light
{   
    class TrafficLight
    {
        public delegate void DelStateChange(bool state);
        public event DelStateChange LightChanged;

        private static Random randChangeLight = new Random();

        public string Color { get; private set; }
        private bool _IsRed = true;

        public void ChangeState()
        {
            _IsRed = randChangeLight.Next(100) <= 20;

            if (_IsRed)
            {
                _IsRed = false;
                Color = "Green";
            }
            else
            {
                _IsRed = true;
                Color = "Red";
            }

            Console.WriteLine(Color);
            LightChanged(_IsRed);
        }
    }


    class Human
    {
        public string Name { get; private set; }        
        public Human(string strName) => Name = strName;                
    }
}
