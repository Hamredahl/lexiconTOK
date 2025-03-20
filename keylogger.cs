using System;
using System.Net.NetworkInformation;

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
                        outputMessage[placeInArray] = (shiftActive) ? "A" : "a";
                        placeInArray++;
                        break;
                    case "bong":
                        outputMessage[placeInArray] = (shiftActive) ? "B" : "b";
                        placeInArray++;
                        break;
                    case "click":
                        outputMessage[placeInArray] = (shiftActive) ? "C" : "c";
                        placeInArray++;
                        break;
                    case "tap":
                        outputMessage[placeInArray] = (shiftActive) ? "D" : "d";
                        placeInArray++;
                        break;
                    case "poing":
                        outputMessage[placeInArray] = (shiftActive) ? "E" : "e";
                        placeInArray++;
                        break;
                    case "clonk":
                        outputMessage[placeInArray] = (shiftActive) ? "F" : "f";
                        placeInArray++;
                        break;
                    case "clack":
                        outputMessage[placeInArray] = (shiftActive) ? "G" : "g";
                        placeInArray++;
                        break;
                    case "ping":
                        outputMessage[placeInArray] = (shiftActive) ? "H" : "h";
                        placeInArray++;
                        break;
                    case "tip":
                        outputMessage[placeInArray] = (shiftActive) ? "I" : "i";
                        placeInArray++;
                        break;
                    case "cloing":
                        outputMessage[placeInArray] = (shiftActive) ? "J" : "j";
                        placeInArray++;
                        break;
                    case "tic":
                        outputMessage[placeInArray] = (shiftActive) ? "K" : "k";
                        placeInArray++;
                        break;
                    case "cling":
                        outputMessage[placeInArray] = (shiftActive) ? "L" : "l";
                        placeInArray++;
                        break;
                    case "bing":
                        outputMessage[placeInArray] = (shiftActive) ? "M" : "m";
                        placeInArray++;
                        break;
                    case "pong":
                        outputMessage[placeInArray] = (shiftActive) ? "N" : "n";
                        placeInArray++;
                        break;
                    case "clang":
                        outputMessage[placeInArray] = (shiftActive) ? "O" : "o";
                        placeInArray++;
                        break;
                    case "pang":
                        outputMessage[placeInArray] = (shiftActive) ? "P" : "p";
                        placeInArray++;
                        break;
                    case "clong":
                        outputMessage[placeInArray] = (shiftActive) ? "Q" : "q";
                        placeInArray++;
                        break;
                    case "tac":
                        outputMessage[placeInArray] = (shiftActive) ? "R" : "r";
                        placeInArray++;
                        break;
                    case "boing":
                        outputMessage[placeInArray] = (shiftActive) ? "S" : "s";
                        placeInArray++;
                        break;
                    case "boink":
                        outputMessage[placeInArray] = (shiftActive) ? "T" : "t";
                        placeInArray++;
                        break;
                    case "cloink":
                        outputMessage[placeInArray] = (shiftActive) ? "U" : "u";
                        placeInArray++;
                        break;
                    case "rattle":
                        outputMessage[placeInArray] = (shiftActive) ? "V" : "v";
                        placeInArray++;
                        break;
                    case "clock":
                        outputMessage[placeInArray] = (shiftActive) ? "W" : "w";
                        placeInArray++;
                        break;
                    case "toc":
                        outputMessage[placeInArray] = (shiftActive) ? "X" : "x";
                        placeInArray++;
                        break;
                    case "clink":
                        outputMessage[placeInArray] = (shiftActive) ? "Y" : "y";
                        placeInArray++;
                        break;
                    case "tuc":
                        outputMessage[placeInArray] = (shiftActive) ? "Z" : "z";
                        placeInArray++;
                        break;
                    case "whack":
                        outputMessage[placeInArray] = (" ");
                        placeInArray++;
                        break;
                    case "bump":
                        shiftActive = (shiftActive) ? false : true;
                        break;
                    case "dink":
                        shiftActive = (shiftActive) ? false : true;
                        break;
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
        }
    }
}