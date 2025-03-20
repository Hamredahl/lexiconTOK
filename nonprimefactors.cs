using System;
using System.Linq;
using System.Collections.Generic;
using Kattis.IO;


namespace NonPrimeFactors {
    internal class Program {

        static bool[] primeSieve = PrimeSieve(2000000);
        static void Main(string[] args) {

            Scanner scanner = new Scanner();
            int throwAway = scanner.NextInt();
            while (scanner.HasNext()) {
                using (BufferedStdoutWriter writer = new BufferedStdoutWriter()) {                
                    writer.WriteLine(NPFCalc(scanner.NextInt()));
                }
            }
        }

        static int NPFCalc (int n) {

            int primeFactorCalc = 1;
            int primeUnique = 0;
            int primeTemp = 0;

            for (int p = 2; p <= n; p++) {
                primeTemp = 0;
                if (!primeSieve[p]) {
                    if (n % p == 0) {
                        primeUnique++;
                        while (n % p == 0) {
                            primeTemp++;
                            n /= p;
                        }
                        primeFactorCalc *= (primeTemp + 1);                    
                    }                    
                }
            }           
            return primeFactorCalc - primeUnique;
        }

        static bool[] PrimeSieve(int i) {
            bool[] sieve = new bool[i];
            for (int j = 2; j < i; j++) {
                if (!sieve[j]) {
                    for (int k = j * 2; k < i; k += j) {
                        sieve[k] = true;
                    }
                }
            }
            return sieve;
        }
    }
}