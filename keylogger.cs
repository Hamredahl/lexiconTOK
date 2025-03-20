using System;

namespace Keylogger {
    internal class Program {
        static void Main(string[] args) {
            int soundsAmount = int.Parse(Console.ReadLine());
            string[] outputMessage = new string[soundsAmount];

            bool shiftActive = false;
            int placeInArray = 0;

            for (int i = 0; i < soundsAmount; i++) {
                switch (Console.ReadLine()) {
                    case "clank":
                        Typer("a");
                        break;
                    case "bong":
                        Typer("b");
                        break;
                    case "click":
                        Typer("c");
                        break;
                    case "tap":
                        Typer("d");
                        break;
                    case "poing":
                        Typer("e");
                        break;
                    case "clonk":
                        Typer("f");
                        break;
                    case "clack":
                        Typer("g");
                        break;
                    case "ping":
                        Typer("h");
                        break;
                    case "tip":
                        Typer("i");
                        break;
                    case "cloing":
                        Typer("j");
                        break;
                    case "tic":
                        Typer("k");
                        break;
                    case "cling":
                        Typer("l");
                        break;
                    case "bing":
                        Typer("m");
                        break;
                    case "pong":
                        Typer("n");
                        break;
                    case "clang":
                        Typer("o");
                        break;
                    case "pang":
                        Typer("p");
                        break;
                    case "clong":
                        Typer("q");
                        break;
                    case "tac":
                        Typer("r");
                        break;
                    case "boing":
                        Typer("s");
                        break;
                    case "boink":
                        Typer("t");
                        break;
                    case "cloink":
                        Typer("u");
                        break;
                    case "rattle":
                        Typer("v");
                        break;
                    case "clock":
                        Typer("w");
                        break;
                    case "toc":
                        Typer("x");
                        break;
                    case "clink":
                        Typer("y");
                        break;
                    case "tuc":
                        Typer("z");
                        break;
                    case "whack":
                        Typer(" ");
                        break;
                    case "bump":
                    case "dink":
                    case "thumb":
                        shiftActive = (shiftActive) ? false : true;
                        break;
                    case "pop":
                        if (placeInArray > 0) {
                            placeInArray--;
                            break;
                        }
                        break;
                }
            }

            for (int i = 0; i < placeInArray; i++) {
                Console.Write(outputMessage[i]);
            }

            void Typer(string l) {
                outputMessage[placeInArray] = (shiftActive) ? l.ToUpper() : l;
                placeInArray++;
            }
        }
    }
}