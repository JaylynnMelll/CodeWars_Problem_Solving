using System;
using System.Collections.Generic;
using System.Linq;
​
public static class Kata
{
    public static int Solution(int value)
    {
        // guard
        if (value <= 0) return 0;
      
        // Preperation
        int[] numbers = Enumerable.Range(1, value - 1).ToArray();
        List<int> resultArray = new List<int>{};
        int result = 0;
      
        // Execution
        foreach (int number in numbers)
        {
            bool multipleOf3 = number % 3 == 0;
            bool multipleOf5 = number % 5 == 0;
           
            if (multipleOf3 && multipleOf5)
            {
               resultArray.Add(number);
               continue;
            }
          
            if (multipleOf3)
            {
                resultArray.Add(number);
                continue;
            }
          
            if (multipleOf5)
            {
                resultArray.Add(number);
                continue;
            }
                
        }
      
        // Wrapping up
        result = resultArray.Sum();
        return result;
    }
}