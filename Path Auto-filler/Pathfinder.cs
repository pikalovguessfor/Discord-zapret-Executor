namespace Path_Auto_filler
{
    internal class Pathfinder
    {
        public string FilePath;

        private void SearchFile(string directory, string fileName)
        {
            try
            {
                // Trying to find file in current directory
                string[] files = Directory.GetFiles(directory, fileName);
                foreach (string file in files)
                {
                    Console.WriteLine($"Найден файл: {file}");
                    this.FilePath = file;
                    return; // Exit after first found file
                }

                // Рекурсивно ищем в поддиректориях
                string[] subDirs = Directory.GetDirectories(directory);
                foreach (string dir in subDirs)
                {
                    SearchFile(dir, fileName);
                    if (!string.IsNullOrEmpty(this.FilePath))
                        return; // If the file is found in the subdirectory, exit
                }
            }
            catch (UnauthorizedAccessException)
            {
                //Skipping directories that are not accessible
            }
            catch (PathTooLongException)
            {
                //We skip paths that are too long
            }
        }

        public Pathfinder(string filename)
        {
            Console.WriteLine($"Идет поиск файла {filename} на диске");
            FilePath = null; // Инициализируем как null

            // Get a list of all disks
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in allDrives)
            {
                if (drive.IsReady) // Checking if the disk is accessible
                {
                    Console.WriteLine($"Поиск на диске {drive.Name}...");
                    SearchFile(drive.RootDirectory.FullName, filename);
                    if (!string.IsNullOrEmpty(FilePath))
                        break; //If the file is found, stop searching
                }
            }

            if (string.IsNullOrEmpty(FilePath))
            {
                Console.WriteLine($"Файл {filename} не найден");
            }
        }
    }
}