namespace Week_5_Assignment_5._3._1
{
    internal class Program
    {
        // You have a long flowerbed in which some of the plots are planted,
        // and some are not. However, flowers cannot be planted in adjacent plots.

        //Given an integer array flowerbed containing 0's and 1's,
        //where 0 means empty and 1 means not empty, and an integer n,
        //return true if n new flowers can be planted in the flowerbed
        //without violating the no-adjacent-flowers rule and false otherwise.

        //Example 1:
        //Input: flowerbed = [1, 0, 0, 0, 1], n = 1
        //Output: true

        // Inititiate Count 0
        // Loop thru the array 
        // Use if condition to check on the left of the beginning element 
        // Also to the right to the right of the end element
        // if meets requitememnt then plant one and increment and return true
        // Also check at the end of the loop if the condition is fully met
        //O(n)
        static bool Flowerbed(int[] x, int n)
        { 
            int count = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 0 && (i == 0 || x[i - 1] == 0) && (i == x.Length - 1 || x[i + 1] == 0)) // Condition
                {
                    x[i] = 1; // Plant new flower if met condition of adjacent
                    count++; // increment 

                    if (count >= n) // planted flowers already then it's true
                        return true;
                }
            }
            return count >= n;
              
        }
        static void Main(string[] args)
        {
            var x = new int[] { 1, 0, 0, 0, 1 };
            Console.WriteLine(Flowerbed(x, 1));
            Console.WriteLine(Flowerbed(new int[] {1, 0, 0, 0, 1}, 2));
        }
    }
}
