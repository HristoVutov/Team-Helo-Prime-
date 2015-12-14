using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using HeloPrimeRPG.Project.Menus;

namespace HeloPrimeRPG.Project.ReadMap
{
    public class RaedMap
    {
        public void ReadMap(Map map)
        {
            string[] data = new string[2];
            data[0] = @"C:\Users\vutov\Documents\GitHub\Team-Helo-Prime-\Map-Files\StartLevel";
            foreach (string path in data)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                    ProcessFile(path,map);


                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessDirectory(path,map);
                }
                else
                {
                    //Contain errors.
                }
            }
        }


        public static void ProcessDirectory(string targetDirectory,Map map)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName, map);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory, map);
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path, Map map)
        {
            if (!path.EndsWith(".csv"))
            {
                return;
            }
            var singleMap = new ReadSingleMap();
            var typeSplit = path.Split('-');
            var type = typeSplit[typeSplit.Length - 1];
            type = type.Substring(0, type.Length - 4);
            singleMap.ReadMap(path, type, map);
            System.Console.WriteLine("Processed file '{0}'.", path);
        }
    }
}
