using System;

namespace SystemDirectoryUtils {
    class FileUtils {
        public static string[] ObtainFileNamesArray() {
            return AskFileNames().Replace(" ", string.Empty).Split(',');
        }

        static string AskFileNames() {
            Console.Write("Input file name(s) separated by comas: ");
            return Console.ReadLine();
        }

        public static void CreateProjectDirectory(string currentDirectory, string projectName) {
            System.IO.Directory.CreateDirectory(currentDirectory + projectName);
        }
    }
}