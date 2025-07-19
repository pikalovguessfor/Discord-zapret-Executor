namespace Gui_implementation
{
    internal class sc_ProcessWork
    {

        public int ProcessExecute(string ProcessPath)
        {

            if (string.IsNullOrEmpty(ProcessPath))
            {
                return 1;
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo(ProcessPath);
            process.Start();


            return 0;
        }
        
    }

}
