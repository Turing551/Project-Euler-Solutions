using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(SumEvenFib((ulong)n));
        }
    }
    
      static ulong SumEvenFib(ulong n){
            ulong sum = 0, prev=0, curr=1, next=0;
            while (curr < n){
                next = prev + curr;
                prev = curr;
                curr = next;
                if (prev % 2 == 0){
                    sum += prev;
                }
            }
            return sum;
        }
}
