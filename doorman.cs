using System;

namespace Doorman {
    class Program {
        static void Main(string[] args) {
            int diff = int.Parse(Console.ReadLine());
            string queue = Console.ReadLine();
            DoorCount(diff, queue);
        }

        static void DoorCount(int max, string s) {
            int count = 0;
            int people = 0;

            while ((count <= max || count >= 0 - max) && people < s.Length) {
                if (count == max && s[people] == 'W') {
                    if (s[people + 1] == 'W') {
                        break;
                    }
                    people = people + 2;
                } else if (count == 0 - max && s[people] == 'M') {
                    if (s[people + 1] == 'M') {
                        break;
                    }
                    people = people + 2;
                } else {
                    count = (s[people] == 'W') ? count = count + 1 : count = count - 1;
                    people++;
                }
            }
            Console.WriteLine(people);
        }
    }
}