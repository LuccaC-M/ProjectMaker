using System;
using C;

namespace Principal {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Choose Project Type:");
            Console.Write("1. C \n2. C++ \nInput a Number: ");
            int choice = Int32.Parse(Console.ReadLine());
            
            switch(choice) {
                case 1:
                    Console.Write("Input file name (without suffix): ");
                    string fileName = Console.ReadLine();
                    CLang.CreateFiles(fileName);
                    Console.WriteLine("C File has been created!");
                    break;
                case 2:
                    Console.WriteLine("C++ File has been created!");
                    break;
            }
        }
    }
}