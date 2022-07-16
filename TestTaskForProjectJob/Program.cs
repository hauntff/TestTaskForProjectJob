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

            List<ImportDataModel> importDataModels = File
                .ReadAllLines(path)
                .Skip(1)
                .Select(x => ImportDataModel.FromCsv(x))
                .ToList();

            using (test_databaseContext db = new test_databaseContext())
            {
                List<PiBulkItem> PiBulkItems = new List<PiBulkItem>();
                foreach (var importDataModel in importDataModels)
                {
                    PiBulkItems.Add(new PiBulkItem
                    {
                        Category = importDataModel.Category,
                        Brand = importDataModel.Brand,
                        LastSold = importDataModel.Last_Sold_On,
                        SaleBegins = importDataModel.Begins,
                        SaleExpires = importDataModel.Expires,
                        SaleMax = importDataModel.Max,
                        SalePrice = importDataModel.Price,
                        CasePrice = importDataModel.CasePrice,
                        CaseSale = importDataModel.CaseSale,
                        CaseStartingDate = importDataModel.CBegins,
                        CaseEndingDate = importDataModel.CExpires,
                        CaseMaxAllowed = importDataModel.CMax,
                        UnitsPerPackage = importDataModel.Upp,
                        PackagePrice = importDataModel.PkgPrc,
                        Unit = importDataModel.Units.ToString(),
                        Posdepartment = importDataModel.Department,
                        Measure = importDataModel.Measure,
                        TaxCategory = importDataModel.Tax,
                        OnHand = importDataModel.OnHand,
                    });
                }

                db.PiBulkItems.AddRange(PiBulkItems);
                
                db.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}
