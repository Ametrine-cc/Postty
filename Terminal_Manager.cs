using System.IO;
using System;

namespace Terminal_Manager
{
    class User
    {
        string config_path = "config.conf";
        string dark_theme_path = "themes/dark_theme.conf";

        private static void NewConfig()
        {
            // Create a new config file with default settings
            File.WriteAllText(config_path, "# Default config settings\nCURSOR_TYPE=\"line\"\nGIT=\"disabled\"\nTHEME=\"dark\"\n");
            Console.WriteLine("New config file created with default settings.");
        }

        private static string CheckConfigExists()
        {
            if (File.Exists(config_path))
            {
                Console.WriteLine("File exists!");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        private static string CheckDarkThemeExists()
        {
            if (File.Exists(dark_theme_path))
            {
                Console.WriteLine("Dark theme file exists!");
            }
            else
            {
                Console.WriteLine("Dark theme file does not exist.");
            }
        }

        private static void LoadConfig()
        {
            if (CheckConfigExists())
            {
                // Load the config file
                string configContent = File.ReadAllText(config_path);
                Console.WriteLine("Config loaded successfully:");
                Console.WriteLine(configContent);
            }
            else
            {
                Console.WriteLine("Config file does not exist.");
                NewConfig();
            }
        }

        private static string GetUserInput()
        {
            Console.Write("> ");
            return Console.ReadLine();
        }

        public static string Terminal()
        {
            string input = GetUserInput();
            return $"Hello from Terminal_Manager! You entered: {input}";
        }
    }
}