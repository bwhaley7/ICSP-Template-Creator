using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSP_Template_Creator
{
    internal class Product
    {
        public int prodNum { get; set; }
        public string prodCatDesc { get; set; } 
        public string brandCode { get; set; } 
        public string cat1 { get; set; } 
        public string cat2 { get; set; }
        public string template { get; set; }
        public DateTime enterDate;

        public Product()
        {
            prodNum = 0;
            prodCatDesc = "";
            brandCode = "";
            cat1 = "";
            cat2 = "";
            template = "";
        }

        public Product(int pNum, string prodCat, string brand, DateTime entered)
        {
            prodNum = pNum;
            prodCatDesc = prodCat;
            brandCode = brand;
            enterDate = entered;
            cat1 = "";
            cat2 = "";
            template = "";
        }

    }
}
