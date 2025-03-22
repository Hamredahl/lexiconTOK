
namespace Fibonacci {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine(fib(int.Parse(Console.ReadLine())));
            }
        }

        static int fib (int n) {
            int f2 = 0;
            int f1 = 1;
            int f0 = 0;

            if (n < 3) {
                return (n == 1) ? f2 : f1;
            } else { 
                for (int i = 3; i <= n; i++) {
                    f0 = f2 + f1;
                    f2 = f1;
                    f1 = f0;
                }
            }
            return f0;
        }
    }
}
