using System;
using System.IO;

namespace C {
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
            // Create & Write to file     #include "the_name_of_the_file.h"
            File.WriteAllText(filePath, $"#ifndef {fileName + "_H"} \n#define {fileName + "_H"} \n#endif //{fileName + "_H"}");
            return File.Exists(filePath);
        }

    }
}