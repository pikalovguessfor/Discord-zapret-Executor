using System;
using System.IO;

namespace Gui_implementation
{
    internal class sc_FileWork
    {
        private string PathToFile;

        private void WriteIntoFile(string Text)
        {

            StreamWriter sw = new StreamWriter(this.PathToFile);

            sw.WriteLine(Text);
            sw.Close();

        }


        public sc_FileWork(string PathToTXT, string Text)
        {
            this.PathToFile = PathToTXT;

            WriteIntoFile(Text);
        }
    }
}
