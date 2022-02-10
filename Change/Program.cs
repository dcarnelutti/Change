using System;
using System.Collections.Generic;

namespace Change
{
    class Program
    {

        public static List<int> getChange(double Note, double price) {

            int result = (int)(Note *100 ) - (int)(price * 100);
            int pending = result;

            List<int> change = new List<int>() { 0, 0, 0, 0, 0, 0 };
            List<int> coins = new List<int>() { 100, 50, 25, 10, 5, 1 };


            for (int j = 0; j < 6; j++) { 
                if((pending / coins[j])>0)
                {
                    change[j] = pending / coins[j];
                    pending -= change[j] * coins[j];


                }
                 
            }
            change.Reverse();
            return change;



        }
        static void Main(string[] args)
        {
             List<int> xx = getChange(3, 0.01);
            foreach (int i in xx) {
                Console.WriteLine(i);
            }
        }
    }
}
