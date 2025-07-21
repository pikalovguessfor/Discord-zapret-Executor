using System;

namespace Path_Auto_filler
{
    internal static class ClassTXTWork
    {

        public static void WriteInfoInFile(string filepath, string content)
        {

            StreamWriter streamWriter = new StreamWriter(filepath);
            streamWriter.WriteLine(content);
            streamWriter.Close();

        }

        public static string ReadInfoFromFile(string filepath)
        {
            string ResultStr = null;
            
            StreamReader streamReader = new StreamReader(filepath);
            ResultStr = streamReader.ReadToEnd();
            streamReader.Close();

            return ResultStr;
        }
    }
}
