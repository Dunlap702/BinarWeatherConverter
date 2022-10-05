using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarWeatherConverter.Models
{
    internal class FileReader
    {
        public static List<string[]> ReadFile(string path)
        {
            List<string[]> whatIReturn = new();

            if (File.Exists(path))
            {
                using StreamReader sr = new(path);
                while (!sr.EndOfStream)
                {
                    var fullLineOfCodes = sr.ReadLine();

                    if (!string.IsNullOrEmpty(fullLineOfCodes))
                        whatIReturn.Add(fullLineOfCodes.Split(' ', StringSplitOptions.RemoveEmptyEntries) );
                }
                sr.Close();
            }
            return whatIReturn;
        }

    }
}
