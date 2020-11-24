using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        //"Состояние" объекта Car
        public string petName;
        public int currSpeed;

        //Специальный стандартный конструктор
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        //Специальный конструктор, где currSpeed получает стандартное (int) значение (0)
        public Car(string name)
        {
            petName = name;
        }

        //Специальный конструктор, где задается полное состояние объекта Car
        public Car(string name, int speed)
        {
            petName = name;
            currSpeed = speed;
        }

        //Специальный конструктор, где задается только скорость для Chuck и используется сжатие до выражения (допускается только для однострочных методов)
        public Car(int speed) => currSpeed = speed;

        //Моделируем поведение класса
        //Использован синтаксис членов, сжатых до выражения, который появился в С# 6
        public void PrintState()
            => Console.WriteLine($"{petName} is going {currSpeed} MPH.");

        public void SpeedUp(int delta)
            => currSpeed += delta;
    }
}
