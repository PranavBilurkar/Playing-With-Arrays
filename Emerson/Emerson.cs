using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson
{
    class Emerson
    {
        static void Main (string[] args)
        {
            string name = "EMERSON";
            char[] nameSPlit = name.ToCharArray();

            for (int i = 0; i <= nameSPlit.Length-1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0}", nameSPlit[j]);
                }
                Console.Write("\n");
             }
            Console.ReadLine();

        }
    }
}
