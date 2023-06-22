using System;
using System.IO;
using Project;

namespace CandCPP {
    class CLang : Project {
        // Changed the Start Project function to add type, a variable that decides if the Project is in C or C++
        public override static StartProject(string[] fileNames, string currentDirectory, string projectName, short type) {
            System.IO.Directory.CreateDirectory(currentDirectory + $"/{projectName}/");
            System.IO.Directory.CreateDirectory(currentDirectory + $"/{projectName}/" + "src");
            this.CreateFiles(filenames, currentDirectory + $"/{projectName}/", type);
        }

        public override static void CreateFiles(string[] fileNames, string filePath, short type) {
            // Loop over the files and create a source and header files per file name
            foreach (string fileName in fileNames) {
                CreateSourceFile(fileName, filePath + "src/", type);
                CreateHeaderFile(fileName, filePath + "src/");
            }
            // Create the main file
            CreateMainFile(filePath, type);
        }

        static void CreateSourceFile(string fileName, string filePath, short type) {
            // Add the file name to the filePath and append the suffix depending on type
            filePath += fileName + (type == 1 ? ".c" + ".cc");
            // Create & Write to file     #include "the_name_of_the_file.h"
            File.WriteAllText(filePath, $"#include \"{fileName + ".h"}\"");
        }

        static void CreateHeaderFile(string fileName, string filePath) {
            // Add the file name to the file path
            filePath += fileName + ".h";
            string headerGuard = fileName.ToUpper() + "_H";
            // Create the file & add include guards
            File.WriteAllText(filePath, $"#ifndef {headerGuard} \n#define {headerGuard} \n#endif //{headerGuard}");
        }

        static void CreateMainFile(string filePath, short type) {
            // Add main to the file path and append the suffix depending on type
            filePath += (type == 1 ? "main.c" : "main.cc");
            // Create the main file and write the main function
            File.WriteAllText(filePath, "int main(int argc, char *argv[]) {\n}");
        }
    }
}