using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 60, 2, 56, 67, 66, 63 };

        var result = numbers
                        .Where(n => n > 60)
                        .OrderBy(n => n);

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }
}
