namespace Traffic_light
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static Queue<Human> humans;

        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.LightChanged += TrafficLight_lightChanged;
            humans = new Queue<Human>(GenerateHumans(10));

            while (humans.Count > 0)
            {
                trafficLight.ChangeState();
            }

            Console.ReadKey();
                        
        }

        /// <summary>
        /// True - red, False - Green
        /// </summary>
        /// <param name="state"></param>
        private static void TrafficLight_lightChanged(bool state)
        {
            if (state != true)
                Console.WriteLine($"{humans.Dequeue().Name} passed");
        }

        static IEnumerable<Human> GenerateHumans(int count)
        {
            List<Human> lstHumans = new List<Human>();
            for(int i = 0; i < count; i++)
            {
                lstHumans.Add(new Human($"People #{i + 1}"));
            }
            return lstHumans;
        }
    }
}
