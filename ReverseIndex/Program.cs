using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseIndex
{
    class Program
    {
        static int[] ModifyArray(int[] array, int index, int count)
        {
            int[] array1 = new int[count];

            if (count >= array.Length)
            {
                for (int k = 0; k < index; k++) { array1[k] = 1; }
                for (int k = index, l = index; l < array.Length; k++, l++) { array1[k] = array[l]; }
                for (int k = array.Length; k < count; k++) { array1[k] = 1; }
            }
            else 
            {
                for (int k = 0, l = index; l < array.Length; k++, l++) { array1[k] = array[l]; }
                for (int k = 1; k < count; k++) { array1[k] = 1; }
            }

            return array1;
        }

        static void Main()
        {

            int[] myArray = { 72, 37, 24, 44, 53 };

            myArray = ModifyArray(myArray, 4, 18);


            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0},", myArray[i]);
            }

            Console.ReadKey();
        }
    }
}
