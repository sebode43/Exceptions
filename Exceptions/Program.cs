using System;

namespace Exceptions {
    class Program {
        static void Main(string[] args) {
            var a = 1;
            var b = 1;
            try {
                var c = a / (b - b);
            } 
            catch(DivideByZeroException ex) {
                Console.WriteLine(ex.Message);
            }
            


        }
    }
}
