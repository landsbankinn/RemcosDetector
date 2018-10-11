using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RemcosDetector
{
    class Program
    {
        private static string _logo = @"#################################################
######################=====================######
###################=====================#########
#################=====================###########
#################=====================###########
################=====================############
###############=====================#############
###############=====================#############
##############=====================##############
#############=====================###############
#############=====================###############
############=====================################
###########=====================########=########
###########=====================#######===#######
##########=====================#######=====######
#########=====================########=====######
#########=====================#######=======#####
########=====================#######=========####
#######======================#######=========####
#######=====================#######===========###
######=====================#######=============##
######=====================#######==============#
#####=====================#######===============#
###========================#####================#
#=============================================###
#################################################
";

        static void Main(string[] args)
        {
            OutputLogo();
            Console.WriteLine("Remcos shadesoul detection tool - (C) Landsbankinn 2018");
            Console.WriteLine("Press q to quit");
            Console.WriteLine("Press any other key to continue");
            var key = Console.ReadKey();
            if (key.KeyChar == 'q' || key.KeyChar == 'Q') return;
            Console.Clear();
            var userprofile = Environment.GetEnvironmentVariable("userprofile");
            if (!Directory.Exists(userprofile)) Console.WriteLine("Could not find userprofile folder");

            var infected = false;

            infected |= CheckPath(userprofile, @"AppData\Local\Temp\Windows 93.exe", "Remcos Decoy file");
            infected |= CheckPath(userprofile, @"AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\PrivatacyCleanzer.vbs", "Remcos persistence file");
            infected |= CheckPath(userprofile, @"AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\UniMP Softwares.vbs", "Remcos persistence file");

            if (infected)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This computer is infected by Remcos shadesoul");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("This computer is not infected by Remcos shadesoul");
            }

            Console.ReadLine();
        }

        private static bool CheckPath(string basePath, string subPath, string name)
        {
            var tempForeground = Console.ForegroundColor;

            var path = Path.Combine(basePath, subPath);
            Console.WriteLine($"Checking for {name}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Looking in {path}");
            var found = false;
            if(File.Exists(path))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{name} found");
                found = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{name} not found");
            }
            Console.ForegroundColor = tempForeground;
            return found;
        }

        private static void OutputLogo()
        {
            var tempForeground = Console.ForegroundColor;
            var tempBackground = Console.BackgroundColor;
            foreach (var c in _logo)
            {
                if (c == '#')
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                else if(c == '=')
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                Console.Write(c);
            }
            Console.ForegroundColor = tempForeground;
            Console.BackgroundColor = tempBackground;
        }
    }
}
