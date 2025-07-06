using System;
using System.IO;

namespace PForm_path_fill
{
    static class FileWrite
    {

        public static void WriteInfoInTXT_Script(String Path, String Info)
        {

                   
            File.OpenWrite(Path);
            File.WriteAllText(Path ,Info);

           
        }

    }
}
