using System;
using System.Threading;
using System.Threading.Tasks;

namespace SampleHelloWorldProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Available commands:\n" +
                                  "ping\n" +
                                  "echo <anyText>\n" +
                                  "login <login> <pass>\n" +
                                  "list\n" +
                                  "msg <destinationUser> <text>\n" +
                                  "file <destinationUser> <filename>\n" +
                                  "exit\n");

                string command = Console.ReadLine();

                string[] words = command.Split(" ");

                switch (words[0])
                {
                    case "ping":
                        Console.WriteLine($"Command for pinging something.");
                        break;
                    case "list":
                        Console.WriteLine($"Entered command = {command}, without parameters.");
                        break;
                    case "echo":
                        if(words.Length < 2) Console.WriteLine("Its just echo without any words.");
                        else Console.WriteLine($"Its like pinging, but echo. Word for echo: {words[1]}");
                        break;
                    case "login":
                        if(words.Length < 3) Console.WriteLine("You must give some credentials."); 
                        else Console.WriteLine($"Are you want to come in? But you just can see what you enter: \"{words[1]}\" and \"{words[2]}\".");
                        break;
                    case "msg":
                        if (words.Length > 2)
                        {
                            Console.WriteLine($"Sending a message...");
                            Thread.Sleep(1000);
                            Console.WriteLine($"...");
                            Thread.Sleep(1000);
                            Console.WriteLine($"...");
                            Thread.Sleep(700);
                            Console.WriteLine($"Fail.");
                        }
                        else Console.WriteLine("What is your message and who you sending it?");
                        break;
                    case "file":
                        if(words.Length < 3) Console.WriteLine("Nope.");
                        else Console.WriteLine($"Entered command = {words[0]}. Its file opening or something. Parameters = {words[1]}{words[2]}");
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine($"There is no command \"{command}\".");
                        break;
                }
            }
        }
    }
}