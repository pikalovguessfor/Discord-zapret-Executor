using System;
using System.IO;


namespace Solution
{

    public class DirectoryWalker
    {
        public int NumberOfZapr = 1;

        public string DiscordWithMask;
        public string ZapretWithMask;

        public string ScopeDir;
        public string CurrentDirStr;
        public string[] CurrentDir = new string[5000];
        
        private string WalkDirectoryes()
        {
            
            

            return " ";
        }

        DirectoryWalker()
        {
            
            this.DiscordWithMask = "Discord.exe";
            this.ZapretWithMask = "general(ALT" + NumberOfZapr.ToString() + ").bat";
            
        }
    }
}