using System;
using System.IO;

namespace Path_Auto_filler
{
    internal class Pathfinder
    {

        public string FilePath;


        private static void SearchFile(string directory, string fileName)
        {
            try
            {
                // Ищем файл в текущей директории
                string[] files = Directory.GetFiles(directory, fileName);
                foreach (string file in files)
                {
                    Console.WriteLine($"Найден файл: {file}");
                }

                // Рекурсивно ищем в поддиректориях
                string[] subDirs = Directory.GetDirectories(directory);
                foreach (string dir in subDirs)
                {
                    SearchFile(dir, fileName);
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

            Console.WriteLine("Идет поиск файла на диске ", filename);

            // Получаем список всех дисков
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in allDrives)
            {
                if (drive.IsReady) // Проверяем, доступен ли диск
                {
                    Console.WriteLine($"Поиск на диске {drive.Name}...");
                    SearchFile(drive.RootDirectory.FullName, filename);
                }
            }

        }
    }
}
