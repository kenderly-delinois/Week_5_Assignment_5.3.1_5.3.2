using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Claims;

namespace Week_5_Assignment_5._3._2
{
    internal class Program
    {
        //You are climbing a staircase.It takes n steps to reach the top.
        //Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?

        //Example 1:
        //Input: n = 2
        //Output: 2
        //Explanation: There are two ways to climb to the top.
        //1. 1 step + 1 step
        //2. 2 steps

        static int FibDp(int n)
        {
            
            int[] DiffWays = new int[n + 1];
            DiffWays[0] = 0;
            DiffWays[1] = 1;
            DiffWays[2] = 2;

            for (int i = 3; i <= n; i++) // Looping through
            {
                DiffWays[i] = DiffWays[i - 1] + DiffWays[i - 2]; // Add the previous element to get current
            } 
            return DiffWays[n];
        }
            static void Main(string[] args)
        {
            Console.WriteLine(FibDp(5)); 
        }
    }
}
