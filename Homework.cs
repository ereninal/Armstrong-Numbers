using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong_numbers
{
    class Homework
    {
        public bool Armstrong(string number)
        {
            bool state = false;
            char[] ArrayNumber = number.ToCharArray();
            int NumberLength = number.Length;
            int Number = Convert.ToInt32(number);
            int total_array = 1;
            int total = 0;
            for (int i = 0; i < NumberLength; i++)
            {
                for (int j = 0; j < NumberLength; j++)
                {
                    total_array *=Convert.ToInt32(ArrayNumber[i].ToString());  
                }
                total += total_array;
                total_array = 1;
            }
            state = number == total.ToString() ? !state : state;
            return state;
        }
    }
}
