using System;
using System.IO;
using System.Collections.Generic;


namespace Solution
{

    public class DirectoryWalker
    {

        public string FinalPath;
        public string CurrentPath;
        
    private string FindFile(string filename)
        {
            
            string FileName;
            string CurrentDirectory;
            string[] FilesTree = new string[5000];
            
            string FinalPath = "";
            
            const string DiscC = "C:\\";
            const string DiscD = "D:\\";
            const string DiscE = "E:\\";
            const string DiscF = "F:\\";
            
            bool fileFound = false;
            bool DiscCNotContains = false;
            bool DiscDNotContains = false;
            bool DiscENotContains = false;
            bool DiscFNotContains = false;
            
            while (!fileFound)
            {
                
                if (!DiscCNotContains)
                {
                    
                    CurrentDirectory = DiscC;

                    
                    
                }
                else if (!DiscDNotContains)
                {
                    
                    CurrentDirectory = DiscD;
                    
                    
                    
                }
                else if (!DiscENotContains)
                {
                    
                    CurrentDirectory = DiscE;
                    
                    
                    
                }
                else if (!DiscFNotContains)
                {
                    
                    CurrentDirectory = DiscF;
                    
                    
                    
                }
                else
                {

                    return " ";

                }
                
            }
            
            return FinalPath;
        }
        
        public DirectoryWalker(string filename)
        {
            this.FileName = filename;
            this.FinalPath = FindFile(this.FileName);
        }
        
    }
}