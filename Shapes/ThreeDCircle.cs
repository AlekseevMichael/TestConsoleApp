using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    //Этот класс расширяет Circle и скрывает унаследованный метод Draw()
    class ThreeDCircle : Circle
    {
        //Скрыть любую реализацию Draw(), находящуюся выше в иерархии
        public new void Draw()
        {
            Console.WriteLine($"Drawing a Sphere");
        }
    }
}
