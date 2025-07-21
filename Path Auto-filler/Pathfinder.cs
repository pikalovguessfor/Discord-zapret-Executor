namespace Path_Auto_filler
{
    internal class Pathfinder
    {
        public string FilePath;

        private void SearchFile(string directory, string fileName)
        {
            try
            {
                // Ищем файл в текущей директории
                string[] files = Directory.GetFiles(directory, fileName);
                foreach (string file in files)
                {
                    Console.WriteLine($"Найден файл: {file}");
                    this.FilePath = file;
                    return; // Выходим после первого найденного файла
                }

                // Рекурсивно ищем в поддиректориях
                string[] subDirs = Directory.GetDirectories(directory);
                foreach (string dir in subDirs)
                {
                    SearchFile(dir, fileName);
                    if (!string.IsNullOrEmpty(this.FilePath))
                        return; // Если файл найден в поддиректории, выходим
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Пропускаем директории, к которым нет доступа
            }
            catch (PathTooLongException)
            {
                // Пропускаем пути, которые слишком длинные
            }
        }

        public Pathfinder(string filename)
        {
            Console.WriteLine($"Идет поиск файла {filename} на диске");
            FilePath = null; // Инициализируем как null

            // Получаем список всех дисков
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in allDrives)
            {
                if (drive.IsReady) // Проверяем, доступен ли диск
                {
                    Console.WriteLine($"Поиск на диске {drive.Name}...");
                    SearchFile(drive.RootDirectory.FullName, filename);
                    if (!string.IsNullOrEmpty(FilePath))
                        break; // Если файл найден, прекращаем поиск
                }
            }

            if (string.IsNullOrEmpty(FilePath))
            {
                Console.WriteLine($"Файл {filename} не найден");
            }
        }
    }
}