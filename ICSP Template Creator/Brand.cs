using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSP_Template_Creator
{
    internal class Brand
    {
        public List<Brand> brands = new List<Brand>();
        public List<string> ident = new List<string>();
        public string brand;

        public Brand() { }
        public Brand(List<string> ident, string brand)
        {
            this.ident = ident;
            this.brand = brand;
        }

        public void initBrands()
        {
            brands.Add(new Brand(new List<string> { "3MFILT" }, "3M™ Aqua-Pure™"));
            brands.Add(new Brand(new List<string> { "ACRBRAK" }, "AIR BRACKETS"));
            brands.Add(new Brand(new List<string> { "ACCOR" }, "Accor®"));
            brands.Add(new Brand(new List<string> { "ACME" }, "ACME®"));
            brands.Add(new Brand(new List<string> { "ACRTOP" }, "Marble Vanity Tops"));
            brands.Add(new Brand(new List<string> { "ADS" }, "ADVANCED DRAINAGE SYSTEM"));
            brands.Add(new Brand(new List<string> { "AGIS" }, "GASKETS AND INSULATION"));
            brands.Add(new Brand(new List<string> { "AKINDU" }, "AK Industries"));
            brands.Add(new Brand(new List<string> { "ALLIED" }, "ALLIED™"));
        }
    }
}
