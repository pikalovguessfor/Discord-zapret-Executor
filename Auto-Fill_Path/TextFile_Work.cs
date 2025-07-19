using System;
using System.IO;

namespace Solution
{

    public static class TextFile_Work
    {

        public static void WriteInFile(string path, string content)
        {

            if (string.IsNullOrEmpty(content))
            {

                StreamWriter sw = new StreamWriter(path);
                sw.Write("Error: file cant be find");
                sw.Close();

                return;

            }

            StreamWriter Sw = new StreamWriter(path);
            Sw.WriteLine(content);
            Sw.Close();
        }

        public static string WriteOutFile(string path)
        {

            string content;

            StreamReader Sw = new StreamReader(path);
            content = Sw.ReadToEnd();
            Sw.Close();

            return content;
        }

    }
}