using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int k = Convert.ToInt32(Console.ReadLine()); 
        for(int i = 0; i < k; i++){
            long a = long.Parse(Console.ReadLine()); 
            long sum = solve(a, 3) + solve(a, 5) - solve(a, 15);            
            Console.WriteLine(sum);           
        }           
    }

    static long solve(long x, int y) {
        if(y == 0 ) return 0;
        long z = (x-1)/y;
        return y * z * (z+1) / 2;
    }
}
