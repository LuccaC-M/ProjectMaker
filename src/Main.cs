using System;
using CandCPP;
using SystemDirectoryUtils;

class Program {
    static void Main(string[] args) {
        /**Constants**/
        string currentDirectory = System.IO.Directory.GetCurrentDirectory() + '/';

        /**Getting the type of projects**/
        Console.WriteLine("Choose Project Type:");
        Console.Write("1. C \n2. C++ \nInput a Number: ");
        int choice = Int32.Parse(Console.ReadLine()); // recording the input

        /**Obtaining Project name**/
        Console.Write("Input project name: ");
        string projectName = Console.ReadLine();
        
        /**Obtaing fileNames array**/
        string[] fileNames /*Array with all the file names*/ = FileUtils.ObtainFileNamesArray();
        
        switch(choice) {
            case 1:
                System.IO.Directory.CreateDirectory(currentDirectory + projectName);
                CLang.CreateFiles(fileNames, currentDirectory + $"/{projectName}/");
                break;
            case 2:
                Console.WriteLine("Choose suffix:");
                Console.Write("1. .cpp \n2. .cc \n3. .cxx \n> ");
                short suffix = short.Parse(Console.ReadLine());
                System.IO.Directory.CreateDirectory(currentDirectory + projectName);
                CPP.CreateFiles(fileNames, System.IO.Directory.GetCurrentDirectory() + $"/{projectName}/", suffix);
                break;
        }
    }
}