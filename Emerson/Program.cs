using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = new int[5];
            int[] outputArray = new int[inputArr.Length];
            int product = 1;           
            outputArray[0] = 1;

            inputArr[0] = 5;
            inputArr[1] = 4;
            inputArr[2] = 3;
            inputArr[3] = 2;
            inputArr[4] = 1;
          
            for (int i = 1; i < inputArr.Length; i++)
            {
                outputArray[i] = outputArray[i-1] * inputArr[i - 1]; //output[0] * input [0] = 1, 5, 20, 60, 120
            }
            for (int i = inputArr.Length - 1; i > 0; i--)
            {
                product = product * inputArr[i];
                outputArray[i-1] = product * outputArray[i-1];
            }

            for (int i = 0; i < outputArray.Length; i++)
            {
                Console.WriteLine(outputArray[i]);    
            }
            Console.ReadLine();
        }

    }
}
