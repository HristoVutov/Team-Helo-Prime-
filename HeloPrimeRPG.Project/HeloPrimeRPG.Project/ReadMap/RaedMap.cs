using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HeloPrimeRPG.Project.ReadMap
{
    public class RaedMap
    {
        public void ReadMap()
        {
            string[] data = new string[2];
            data[0] = @"C:\HelloPrimeFolder";
            foreach (string path in data)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                    ProcessFile(path);


                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessDirectory(path);
                }
                else
                {
                    //Contain errors.
                }
            }
        }


        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            var singleMap = new ReadSingleMap();
            singleMap.ReadSingleMap(path);
            //System.Console.WriteLine("Processed file '{0}'.", path);
        }
    }
}
