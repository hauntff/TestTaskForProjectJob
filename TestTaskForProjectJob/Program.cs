using ClosedXML.Excel;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace TestTaskForProjectJob
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\import_data.csv";
            string[] randomWords = { "EARTH", "MARS", "JUPITER", "VENUS", "SATURN" };
            Random random = new Random();
            List<string> rows = File.ReadAllLines(path)
                .ToList();

            for (int i = 0; i < rows.Count; i++)
            {
                if (i == 0)
                {
                    rows[i] = rows[i] + " | " + "FoodForWho";
                    continue;
                }

                rows[i] = rows[i] + " | " + randomWords[random.Next(0, randomWords.Length - 1)];
            }
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(string.Join("\r\n", rows));
            }



            Console.ReadKey();
        }
    }
}
