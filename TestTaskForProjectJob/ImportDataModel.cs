using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskForProjectJob
{
    public class ImportDataModel
    {
        #region Поля
        public string Category { get; set; }
        public string Desc { get; set; }
        public string Code { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public int? UPC { get; set; }
        public DateTime? Last_Sold_On { get; set; }
        public decimal? Price { get; set; }
        public decimal? Sale { get; set; }
        public DateTime? Begins { get; set; }
        public DateTime? Expires { get; set; }
        public int? Max { get; set; }
        public decimal? CasePrice { get; set; }
        public decimal? CaseSale { get; set; }
        public DateTime? CBegins { get; set; }
        public DateTime? CExpires { get; set; }
        public int? CMax { get; set; }
        public int? Upp { get; set; }
        public decimal? PkgPrc { get; set; }
        public int? SUpp { get; set; }
        public string Department { get; set; }
        public decimal? SPkgPrc { get; set; }
        public DateTime? PBegins { get; set; }
        public DateTime? PExpires { get; set; }
        public int? PMax { get; set; }
        public string Measure { get; set; }
        public decimal? Units { get; set; }
        public bool? FS { get; set; }
        public int? Tax { get; set; }
        public bool? Wic { get; set; }
        public string OnHand { get; set; }
        public string Season { get; set; }
        public string PrdRule { get; set; }
        public string Food_For_Who { get; set; }
        #endregion

        #region Methods
        public static ImportDataModel FromCsv(string row)
        {
            string[] values = row.Split('|');
            ImportDataModel importDataModel = new ImportDataModel();
            importDataModel.Category = values[0].ToString();
            importDataModel.Desc = values[1].ToString();
            importDataModel.Code = values[2].ToString();
            importDataModel.Brand = values[3].ToString();
            importDataModel.Size = values[4].ToString();
            importDataModel.UPC = values[5] == "" ? null : Convert.ToInt32(values[5]);
            importDataModel.Last_Sold_On = values[6] == "" ? null : DateTime.ParseExact(values[6], "d", new CultureInfo("en-US"), DateTimeStyles.None);
            importDataModel.Price = values[7] == "" ? null : Decimal.Parse(values[7].Replace("(", "").Replace("$", "").Replace(")", "").Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            importDataModel.Sale = values[8] == "" ? null : Decimal.Parse(values[8].Replace("(", "").Replace("$", "").Replace(")", "").Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            importDataModel.Begins = values[9] == "" ? null : DateTime.ParseExact(values[9], "d", new CultureInfo("en-US"), DateTimeStyles.None);
            importDataModel.Expires = values[10] == "" ? null : DateTime.ParseExact(values[10], "d", new CultureInfo("en-US"), DateTimeStyles.None);
            importDataModel.Max = values[11] == "" ? null : Convert.ToInt32(values[11]);
            importDataModel.CasePrice = values[12] == "" ? null : Decimal.Parse(values[12].Replace("(", "").Replace("$", "").Replace(")", "").Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            importDataModel.CaseSale = values[13] == "" ? null : Decimal.Parse(values[13].Replace("(", "").Replace("$", "").Replace(")", "").Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            importDataModel.CBegins = values[14] == "" ? null : DateTime.ParseExact(values[14], "d", new CultureInfo("en-US"), DateTimeStyles.None);
            importDataModel.CExpires = values[15] == "" ? null : DateTime.ParseExact(values[15], "d", new CultureInfo("en-US"), DateTimeStyles.None);
            importDataModel.CMax = values[16] == "" ? null : Convert.ToInt32(values[16]);
            importDataModel.Upp = values[17] == "" ? null : Convert.ToInt32(values[17]);
            importDataModel.PkgPrc = values[18] == "" ? null : Decimal.Parse(values[18].Replace("(", "").Replace("$", "").Replace(")", "").Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            importDataModel.SUpp = values[19] == "" ? null : Convert.ToInt32(values[19]);
            importDataModel.Department = values[20].ToString();
            importDataModel.SPkgPrc = values[21] == "" ? null : Decimal.Parse(values[21].Replace("(", "").Replace("$", "").Replace(")", "").Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            importDataModel.PBegins = values[22] == "" ? null : DateTime.ParseExact(values[22], "d", new CultureInfo("en-US"), DateTimeStyles.None);
            importDataModel.PExpires = values[23] == "" ? null : DateTime.ParseExact(values[23], "d", new CultureInfo("en-US"), DateTimeStyles.None);
            importDataModel.PMax = values[24] == "" ? null : Convert.ToInt32(values[24]);
            importDataModel.Measure = values[25].ToString();
            importDataModel.Units = values[26] == "" ? null : Decimal.Parse(values[26].Replace(",", ".").Replace("(", "").Replace("%", "").Replace(")", "").Replace(".00", "").Trim(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            importDataModel.FS = values[27] == "" ? null : bool.Parse(values[27]);
            importDataModel.Tax = values[28] == "" ? 0 : 1;
            importDataModel.Wic = values[29] == "" ? null : bool.Parse(values[29]);
            importDataModel.OnHand = values[30].Replace("(","").Replace(")","").ToString();
            importDataModel.Season = values[31].ToString();
            importDataModel.PrdRule = values[32].ToString();
            importDataModel.Food_For_Who = values[33].ToString();
            return importDataModel;
        }
        #endregion
        

    }
}
