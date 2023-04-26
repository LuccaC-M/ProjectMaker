using System;
using CandCPP;
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
                string[] fileNames = FileUtils.ObtainFileNamesArray();
                CPP.CreateFiles(fileNames, System.IO.Directory.GetCurrentDirectory() + '/')
                break;
            case 2:
                string[] fileNames = FileUtils.ObtainFileNamesArray();
                Console.WriteLine("Choose suffix:");
                Console.Write("1. .cpp \n2. .cc \n3. .cxx \n> ");
                short suffix = short.Parse(Console.ReadLine());
                CPP.CreateFiles(fileNames, System.IO.Directory.GetCurrentDirectory() + '/', suffix);
                break;
        }
    }
}