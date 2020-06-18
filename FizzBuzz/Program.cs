using System;

namespace FizzBuzz {
    class Program {
        static int Main(string[] args) {
            return -1;
            for(var idx = 1; idx <= 30; idx++) {
                if(idx % 3 == 0 && idx % 5 == 0) {
                    Console.Write("FizzBuzz ");
                    continue;
                }
                if(idx % 3 == 0) {
                    Console.Write("Fizz ");
                    continue;
                }
                if(idx % 5 == 0) {
                    Console.Write("Buzz ");
                    continue;
                }
                Console.Write($"{idx} ");
            }
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
        }
    }
}
