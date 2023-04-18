using System;
using Cfiles;
using CPPfiles;
using FileUtilities;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Choose Project Type:");
        Console.Write("1. C \n2. C++ \nInput a Number: ");
        int choice = Int32.Parse(Console.ReadLine());
        
        string fileName;
        bool success;
        switch(choice) {
            case 1:
                Console.Write("Input file name (without suffix): ");
                fileName = Console.ReadLine();
                success = CLang.CreateFiles(fileName);
                if (success) {
                    Console.WriteLine("C Files have been created!");
                } else {
                    Console.WriteLine("C File(s) couldn't be created");
                }
                break;
            case 2:
                string [] fileNames = FileUtils.ObtainFileNamesArray();
                Console.WriteLine("Choose suffix:");
                Console.Write("1. .cpp \n2. .cc \n3. .cxx \n> ");
                short suffix = short.Parse(Console.ReadLine());
                CPP.CreateFiles(fileNames, System.IO.Directory.GetCurrentDirectory() + '/', suffix);
                break;
        }
    }
}