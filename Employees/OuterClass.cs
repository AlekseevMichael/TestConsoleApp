using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class OuterClass
    {
        //Открытый вложенный тип может использоваться кем угодно!
        public class PublicInnerClass { }

        //Закрытый вложенный тип может использоваться только членами
        //включающего класса
        private class PrivateInnerClass { }
    }
}
