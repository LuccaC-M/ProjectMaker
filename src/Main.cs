using System;
using CandCPP;

class Program {
    static void Main(string[] args) {
        /*Varibles*/
        string currentDirectory = System.IO.Directory.GetCurrentDirectory() + '/';

        /*Getting the type of projects*/
        Console.WriteLine("Choose Project Type:");
        Console.Write("1. C \n2. C++ \n3.Web (no framework)\nInput a Number: ");
        int choice = Int32.Parse(Console.ReadLine()); // recording the input

        /*Obtaining Project name*/
        Console.Write("Input project name: ");
        string projectName = Console.ReadLine();
        
        /*Obtaing fileNames array*/
        string[] fileNames = AskFileNames();
        
        switch(choice) {
            case 1:
                CLang.StartProject(fileNames, currentDirectory, projectName, 1);
                break;
            case 2:
                CLang.StartProject(fileNames, currentDirectory, projectName, 2);
                break;
            case 3:
                FileUtils.CreateProjectDirectory(currentDirectory, projectName);
                break;
        }
    }

    static string AskFileNames() {
        Console.Write("Input file name(s) separated by comas: ");
        return Console.ReadLine().Replace(" ", string.Empty).Split(',');
    }
}