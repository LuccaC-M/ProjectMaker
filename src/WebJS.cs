using System;
using System.IO;
using Project;


namespace WebJavascript {
    class JSNoFramework : Project{
        public override static void CreateFiles(string[] fileNames, string filePath) {
            CreateIndexFiles();
            foreach (string fileName in fileNames) {
                CreateJSFile(fileName, filePath + "src/");
                CreateHTMLFile(fileName, filePath + "src/");
                CreateCSSFile(fileName, filePath + "src/");
            }
        }
        public static void CreateJSFile(string fileName, string filePath) {
            // TODO
        }

        public static void CreateHTMLFile(string fileName, string filePath) {
            // TODO
        }

        public static void CreateCSSFile(string fileName, string filePath) {
            // TODO
        }
    }
}