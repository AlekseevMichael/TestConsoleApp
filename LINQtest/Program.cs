using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtest
{
    class Program
    {
        static void Main(string[] args)
        {
            InternalBaseProgramClass myBase = new InternalBaseProgramClass();
            Console.WriteLine(myBase);
            InternalOtherAssemblyTestClass myOtherBase = new InternalOtherAssemblyTestClass();


        }
    }

    internal class InternalBaseProgramClass
    {
        int BPC = 10;
    }
}
