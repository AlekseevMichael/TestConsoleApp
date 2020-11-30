using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Car
    {
        public readonly int maxSpeed;
        private int currSpeed;

        public int Speed
        {
            get => currSpeed;
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                    currSpeed = maxSpeed;
            }
        }

        public Car(int max)
        {
            maxSpeed = max;
        }

        public Car()
        {
            maxSpeed = 55;
        }
    }
}
