using System;
using System.IO;

namespace Cfiles {
    class CLang {
        public static bool CreateFiles(string fileName) {
            string filePath = Directory.GetCurrentDirectory() + '/';
            return CreateSourceFile(fileName, filePath) && CreateHeaderFile(fileName, filePath);
        }

        static bool CreateSourceFile(string fileName, string filePath) {
            filePath += fileName + ".c";
            // Create & Write to file     #include "the_name_of_the_file.h"
            File.WriteAllText(filePath, $"#include \"{fileName + ".h"}\"");
            return File.Exists(filePath);
        }

        static bool CreateHeaderFile(string fileName, string filePath) {
            filePath += fileName + ".h";
            fileName = fileName.ToUpper();
            // Create the file & add include guards
            File.WriteAllText(filePath, $"#ifndef {fileName + "_H"} \n#define {fileName + "_H"} \n#endif //{fileName + "_H"}");
            return File.Exists(filePath);
        }

    }
}

namespace CPPfiles {
    class CPP {
        public static void CreateFiles(string[] fileNames, string filePath, short suffix) {
            foreach (string fileName in fileNames) {
                CreateSourceFile(fileName, filePath, suffix);
                CreateHeaderFile(fileName, filePath, suffix);
            }
        }

        static bool CreateSourceFile(string fileName, string filePath, short suffix) {
            filePath += fileName + (suffix == 1 ? ".cpp" : suffix == 2 ? ".cc" : ".cxx");
            // Create the file & add the header file
            File.WriteAllText(filePath, $"#include <{fileName + ".h"}>");
            return File.Exists(filePath);
        }

        static bool CreateHeaderFile(string fileName, string filePath, short suffix) {
            filePath += fileName + (suffix == 1 ? ".hpp" : suffix == 2 ? ".hh" : ".hxx");
            fileName = fileName.ToUpper();
            // Create the file & add include guards
            File.WriteAllText(filePath, $"#ifndef {fileName + "_H"} \n#define {fileName + "_H"} \n#endif //{fileName + "_H"}");
            return File.Exists(filePath);
        }

    }
}