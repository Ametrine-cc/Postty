// Global using directives
using System.Diagnostics;
using System.IO;
using System;

// Custom using directives
using Terminal_Manager;

class Program
{
    static void Main()
    {
        bool runtime = true;

        while (runtime)
        {
            string result = Terminal_Manager.User.Terminal();
            Console.WriteLine(result);
        }
    }
}