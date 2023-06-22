
namespace Project {
    class abstract Project {
        public static StartProject(string[] fileNames, string currentDirectory, string projectName) {
            System.IO.Directory.CreateDirectory(currentDirectory + $"/{projectName}/");
            System.IO.Directory.CreateDirectory(currentDirectory + $"/{projectName}/" + "src");
            this.CreateFiles(filenames, currentDirectory + $"/{projectName}/");
        }
        public abstract static CreateFiles();
    }
}