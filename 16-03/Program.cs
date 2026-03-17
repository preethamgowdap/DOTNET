using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] cars = {1,2,3,4,5};
      foreach (int i in cars) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}
