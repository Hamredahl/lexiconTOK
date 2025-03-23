using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Kattis.IO;


namespace NonPrimeFactors {
    internal class Program {
        static void Main(string[] args) {

            bool[] primeSieve = PrimeSieve(2000000);
            Tokenizer tokenizer = new Tokenizer();            
            int calls = toInt(tokenizer.Next());

            using (BufferedStdoutWriter writer = new BufferedStdoutWriter()) {
                while (tokenizer.HasNext()) {
                    writer.Write(NPFCalc(toInt(tokenizer.Next())) + "\n");
                }
                writer.Flush();
            }

            int NPFCalc(int n) {

                int primeFactorCalc = 1;
                int primeUnique = 0;
                int primeTemp = 0;
                int sqrtN = Convert.ToInt32(Math.Sqrt(n));

                for (int p = 2; p <= sqrtN; p++) {
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
                if (n >= sqrtN) {
                    primeFactorCalc *= 2;
                    primeUnique++;
                }
                return primeFactorCalc - primeUnique;
            }

            bool[] PrimeSieve(int n) {
                int len = Convert.ToInt32(Math.Sqrt(n)) + 1;
                int sqrtLen = Convert.ToInt32(Math.Sqrt(len));
                bool[] sieve = new bool[len];

                for (int i = 2; i <= sqrtLen; i++) {
                    if (!sieve[i]) {
                        for (int j = i * i; j < len; j += i) {
                            sieve[j] = true;
                        }
                    }
                }
                return sieve;
            }

            int toInt(string s) {
                int n = 0;
                for (int i = 0; i < s.Length; i++) {
                    n = n * 10 + (s[i] - '0');
                }
                return n;
            }
        }
    }
}
