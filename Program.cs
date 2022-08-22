using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int A = 111111111;
        int B = 999999999;
        int sum = 0;

        // for (int i = A; i <= B; i++)
        // {
        //     if (i.ToString().Distinct().Count() == 1) sum ++;
        // }
        
        sum = Enumerable.Range(A, B - A+1).Where(x => x.ToString().Distinct().Count() == 1).Count();
        
        Console.WriteLine(sum);
    }
}
