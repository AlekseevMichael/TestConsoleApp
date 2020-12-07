using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class Card
    {
        int own;
        bool b;
        private int ownerID = 12345;
        private string ownerName = "Michael";

        public int ID
        {
            get { return ownerID; } set { }
        }

        public string Name
        {
            get { return ownerName; } set { }
        }



        public Card GetCardById(int ID)
        {
            if (ID > 50000)
                return new Card { };
            else
                return null;
        }
    }
}
