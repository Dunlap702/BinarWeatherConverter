using System;
using System.Collections.Generic;
using System.IO;

namespace BinarWeatherConverter.Models
{
    internal class FileReader
    {
        public static List<string[]> ReadAvationFile(string path)
        {
            List<string[]> whatIReturn = new();

            if (File.Exists(path))
            {
                using StreamReader sr = new(path);
                while (!sr.EndOfStream)
                {
                    var fullLineOfCodes = sr.ReadLine();

                    if (!string.IsNullOrEmpty(fullLineOfCodes))
                        whatIReturn.Add(fullLineOfCodes.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                }
                sr.Close();
            }
            return whatIReturn;
        }

        public static List<List<string>> ReadForecastFile(string path)
        {
            List<List<string>> whatIReturn = new();

            if (File.Exists(path))
            {
                using StreamReader sr = new(path);
                int count = 0;
                while (!sr.EndOfStream && count < 7)
                {
                    List<string> codeBlock = new();
                    for (int i = 0; i < 8; i++)
                    {
                        var lineOfCodes = sr.ReadLine();
                        codeBlock.Add(lineOfCodes);
                    }
                    count++;
                    whatIReturn.Add(codeBlock);
                }
                sr.Close();
            }
            return whatIReturn;
        }
    }
}
