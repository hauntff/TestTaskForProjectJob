using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskForProjectJob
{
    public class ImportDataModel
    {
        public string Category { get; set; }
        public string Desc { get; set; }
        public int Code { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public int UPC { get; set; }
        public DateTime Last_Sold_On { get; set; }
        public decimal Price { get; set; }
        public decimal Sale { get; set; }
        public DateTime Begins { get; set; }
        public DateTime Expires { get; set; }
        public int Max { get; set; }
        public decimal CasePrice { get; set; }
        public decimal CaseSale { get; set; }
        public DateTime CBegins { get; set; }
        public DateTime CExpires { get; set; }
        public int CMax { get; set; }
        public int Upp { get; set; }
        public decimal PkgPrc { get; set; }
        public int SUpp { get; set; }
        public string Department { get; set; }
        public decimal SPkgPrc { get; set; }
        public DateTime PBegins { get; set; }
        public DateTime PExpires { get; set; }
        public int PMax { get; set; }
        public string Measure { get; set; }
        public decimal Units { get; set; }
        public bool FS { get; set; }
        public bool Tax { get; set; }
        public bool Wic { get; set; }
        public string OnHand { get; set; }
        public string Season { get; set; }
        public string PrdRule { get; set; }
        public string Food_For_Who { get; set; }
        
        public static ImportDataModel FromCsv(string row)
        {
            string[] values = row.Split('|');
        }
    }
}
