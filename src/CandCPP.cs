using System;
using System.IO;

namespace CandCPP {
    class CLang {

        public static void CreateFiles(string[] fileNames, string filePath) {
            foreach (string fileName in fileNames) {
                CreateSourceFile(fileName, filePath);
                CreateHeaderFile(fileName, filePath);
            }
            CreateMainFile(filePath);
        }

        static void CreateSourceFile(string fileName, string filePath) {
            filePath += fileName + ".c";
            // Create & Write to file     #include "the_name_of_the_file.h"
            File.WriteAllText(filePath, $"#include \"{fileName + ".h"}\"");
        }

        static void CreateHeaderFile(string fileName, string filePath) {
            filePath += fileName + ".h";
            string headerGuard = fileName.ToUpper() + "_H";
            // Create the file & add include guards
            File.WriteAllText(filePath, $"#ifndef {headerGuard} \n#define {headerGuard} \n#endif //{headerGuard}");
        }

        static void CreateMainFile(string filePath) {
            filePath += "main.c";
            File.WriteAllText(filePath, "int main(int argc, char *argv[]) {\n}");
        }
    }

    class CPP {
        public static void CreateFiles(string[] fileNames, string filePath, short suffix) {
            CreateMainFile(filePath, suffix);
            foreach (string fileName in fileNames) {
                CreateSourceFile(fileName, filePath, suffix);
                CreateHeaderFile(fileName, filePath, suffix);
            }
        }

        static void CreateSourceFile(string fileName, string filePath, short suffix) {
            filePath += fileName + (suffix == 1 ? ".cpp" : suffix == 2 ? ".cc" : ".cxx");
            // Create the file & add the header file
            File.WriteAllText(filePath, $"#include \"{fileName + ".h"}\"");
        }

        static void CreateHeaderFile(string fileName, string filePath, short suffix) {
            string headerSuffix = (suffix == 1 ? "hpp" : suffix == 2 ? "hh" : "hxx");
            filePath += fileName + "." + headerSuffix;
            string headerGuard = fileName.ToUpper() + "_" + headerSuffix.ToUpper();
            // Create the file & add include guards
            File.WriteAllText(filePath, $"#ifndef {headerGuard} \n#define {headerGuard} \n#endif //{headerGuard}");
        }

        static void CreateMainFile(string filePath, short suffix) {
            filePath += "main" + (suffix == 1 ? ".cpp" : suffix == 2 ? ".cc" : ".cxx");
            // Create & write main function template
            File.WriteAllText(filePath, "int main(int argc, char **argv) {\n}");
        }

    }
}