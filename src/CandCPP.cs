using System;
using System.IO;
using Project;

namespace CandCPP {
    class CLang : Project {

        public override static StartProject(string[] fileNames, string currentDirectory, string projectName, short type) {
            System.IO.Directory.CreateDirectory(currentDirectory + $"/{projectName}/");
            System.IO.Directory.CreateDirectory(currentDirectory + $"/{projectName}/" + "src");
            this.CreateFiles(filenames, currentDirectory + $"/{projectName}/", type);
        }

        public override static void CreateFiles(string[] fileNames, string filePath, short type) {
            foreach (string fileName in fileNames) {
                CreateSourceFile(fileName, filePath + "src/", type);
                CreateHeaderFile(fileName, filePath + "src/");
            }
            CreateMainFile(filePath, type);
        }

        static void CreateSourceFile(string fileName, string filePath, short type) {
            filePath += fileName + (type == 1 ? ".c" + ".cc");
            // Create & Write to file     #include "the_name_of_the_file.h"
            File.WriteAllText(filePath, $"#include \"{fileName + ".h"}\"");
        }

        static void CreateHeaderFile(string fileName, string filePath) {
            filePath += fileName + ".h";
            string headerGuard = fileName.ToUpper() + "_H";
            // Create the file & add include guards
            File.WriteAllText(filePath, $"#ifndef {headerGuard} \n#define {headerGuard} \n#endif //{headerGuard}");
        }

        static void CreateMainFile(string filePath, short type) {
            filePath += type == 1 ? "main.c" : "main.cc";
            File.WriteAllText(filePath, "int main(int argc, char *argv[]) {\n}");
        }
    }
}