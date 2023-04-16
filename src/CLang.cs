using System;
using System.IO;

namespace C {
    class CLang {
        public static bool CreateFiles(string fileName) {
            string filePath = Directory.GetCurrentDirectory() + '/';
            return CreateSourceFile(fileName, filePath);
        }

        static bool CreateSourceFile(string fileName, string filePath) {
            filePath += fileName + ".c";
            // Create & Write to file     #include "the_name_of_the_file.h"
            File.WriteAllText(filePath, $"#include \"{fileName + ".h"}\"");
            return File.Exists(filePath);
        }
    }
}