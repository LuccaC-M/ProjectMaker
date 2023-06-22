
namespace Project {
    class abstract Project {
        /* Main function it starts the projects by creating the main project directory first, then
         * it creates the src folder inside, and calls the CreateFiles function. */
        public static StartProject(string[] fileNames, string currentDirectory, string projectName) {
            System.IO.Directory.CreateDirectory(currentDirectory + $"/{projectName}/");
            System.IO.Directory.CreateDirectory(currentDirectory + $"/{projectName}/" + "src");
            this.CreateFiles(filenames, currentDirectory + $"/{projectName}/");
        }
        
        // Function should be inplemented by every child and should create the nessesary files for the project.
        public abstract static CreateFiles();
    }
}