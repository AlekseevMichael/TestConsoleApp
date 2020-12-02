using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        public string PetName { get; set; }
        public Shape(string name = "NoName")
        {
            PetName = name;
        }

        //У абстрактного метода нет тела и реализации, он заставляет всех
        //наследников переопределить метод
        public abstract void Draw();
    }
}
