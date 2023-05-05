using System;
using CandCPP;
using SystemDirectoryUtils;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Choose Project Type:");
        Console.Write("1. C \n2. C++ \nInput a Number: ");
        int choice = Int32.Parse(Console.ReadLine());
        Console.Write("Input project name: ");
        string projectName = Console.ReadLine();
        string[] fileNames;
        switch(choice) {
            case 1:
                fileNames = FileUtils.ObtainFileNamesArray();
                System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + '/' + projectName);
                CLang.CreateFiles(fileNames, System.IO.Directory.GetCurrentDirectory() + $"/{projectName}");
                break;
            case 2:
                fileNames = FileUtils.ObtainFileNamesArray();
                Console.WriteLine("Choose suffix:");
                Console.Write("1. .cpp \n2. .cc \n3. .cxx \n> ");
                short suffix = short.Parse(Console.ReadLine());
                System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + '/' + projectName);
                CPP.CreateFiles(fileNames, System.IO.Directory.GetCurrentDirectory() + '/' + projectName, suffix);
                break;
        }
    }
}