using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    //MiniVan "является" Car
    sealed class MiniVan : Car //Теперь MiniVan имеет доступ ко всем открытым членам Car
    {
        public void TestMethod()
        {
            //Это нормально, доступ к открытым членам родительского типа в
            //производном типе возможен
            Speed = 10;

            //Ошибка! нельзя образаться к закрытым членам родительского
            //типа из производного типа
            //currSpeed = 10;
        }
    }

    //Не может быть унаследовал из-за sealed MiniVan. Seal имеет смысл при создании обслуживающих классов
    //class DeluxeMiniVan : MiniVan
    //{
    //}
}
