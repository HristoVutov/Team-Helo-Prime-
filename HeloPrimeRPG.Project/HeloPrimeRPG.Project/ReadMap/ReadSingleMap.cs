using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using HeloPrimeRPG.Project.Menus;

namespace HeloPrimeRPG.Project.ReadMap
{
    public class ReadSingleMap
    {
        public void ReadMap(string path,string type,Map map)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    String line = sr.ReadToEnd();

                    string[] numberTextArr = line.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    string[] singleLineForGetLength = numberTextArr[0].Split(',');
                    var len = singleLineForGetLength.Length;

                    int[,] matrix = new int[numberTextArr.Length, len];

                    for (int i = 0; i < numberTextArr.Length; i++)
                    {
                        string[] singleLine = numberTextArr[i].Split(',');
                        int[] numbersLine = new int[singleLine.Length];

                        for (int j = 0; j < singleLine.Length; j++)
                        {
                            numbersLine[j] = int.Parse(singleLine[j]);
                        }

                        for (int k = 0; k < len; k++)
                        {
                            matrix[i, k] = numbersLine[k];
                        }
                    }

                    map.LoadMap(type, matrix);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The File could not be read:");
                Console.WriteLine(e.Message);

                Console.ReadLine();
            }
        }
    }
}
