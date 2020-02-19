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

            try {
                var e = "ABC";
                e = null;
                var len = e.Length;
            } catch (NullReferenceException n) {
                var bce = new BootcampException("BootCamp Exception", n);
                throw bce;
            } 
            catch (Exception except) {
                Console.WriteLine(except.Message);
            }



        }
    }
}
