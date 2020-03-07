using System;

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
                    case "list":
                        Console.WriteLine($"Entered command = {command}, parameters = none.");
                        break;
                    case "echo":
                        Console.WriteLine($"Entered command = echo, parameters = {words[1]}");
                        break;
                    case "login":
                    case "msg":
                    case "file":
                        Console.WriteLine($"Entered command = {words[0]}, parameters = {words[1]}{words[2]}");
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