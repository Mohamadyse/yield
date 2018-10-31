using System;
using System.Collections.Generic;

class MainClass
{
  static IEnumerable <int> WhileMethod(int order)
    {
        int previous = 0;
        int current = 1;
        for (int j=1; j<=order; j++)
        {
            int old = current;
         yield return  current = current + previous;
          previous = old;
          
        }
    }
    static void Main()
    {
        foreach(int num in WhileMethod(10))
            Console.WriteLine(num);
    }

}