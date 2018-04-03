using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
        bool CommandLine = true;
            string Command;
            while (CommandLine)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Environment.UserName + "@" + "C#-CommandLine:");
                Console.ForegroundColor = ConsoleColor.White;
                Command = Console.ReadLine().ToLower();
                
                switch(Command)
                {
                    case "help":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Help Commands:");
                        Console.Write("Help"); Console.WriteLine(" - Give info about commands");
                        break;
                    case "exit":
                        Console.WriteLine("Good Bye");
                        Thread.Sleep(1000);
                        CommandLine = false;
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }


        }
    }
}
