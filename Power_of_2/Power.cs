using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_2
{
    public class Power
    {
        public void FindPower()
        {
            int N = 0;  //Intializing the value for N
            while (N < 31)     //  N value is Given as less than 31
            {
                double value =Math.Pow(2, N); //Used Math.pow Method 
                Console.WriteLine(value);
                N++;   //Increments the Value after One Iteration 
            }
        }
    }
}
