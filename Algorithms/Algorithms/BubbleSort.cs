using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSort
    {
        public void bubble()
        {

            int[] number = { 5, 8, 4, 3, 9, 2, 1 };
            bool flag = true;
            int temp;
            int numLength = number.Length;


            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {

                    if (number[j + 1] > number[j])
                    {

                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;

                    }

                }
            }

            //Sorted array  
            foreach (int num in number)
            {
                Console.Write("\t {0}", num);

            }
            Console.Read();

        }

    }
}
