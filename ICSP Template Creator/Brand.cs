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
            brands.Add(new Brand(new List<string> { "DELTA" }, "DELTA®"));
            brands.Add(new Brand(new List<string> { "ELKAY" }, "Elkay®"));
            brands.Add(new Brand(new List<string> { "GERBRB" }, "Gerber®"));
            brands.Add(new Brand(new List<string> { "KOHFAU" }, "Kohler®"));
            brands.Add(new Brand(new List<string> { "LEGEND" }, "LEGEND"));
            brands.Add(new Brand(new List<string> { "WEILPA" }, "Weil-McLain®"));
            brands.Add(new Brand(new List<string> { "MOEN" }, "Moen®"));
            brands.Add(new Brand(new List<string> { "STERSD" }, "Sterling®"));
            brands.Add(new Brand(new List<string> { "TOPP" }, "TOPP"));
            brands.Add(new Brand(new List<string> { "WEBSTO" }, "Webstone"));
            brands.Add(new Brand(new List<string> { "AOSPAR" }, "AO Smith®"));
            brands.Add(new Brand(new List<string> { "DURAVI" }, "DURAVIT"));
            brands.Add(new Brand(new List<string> { "STERSS" }, "Sterling®"));
            brands.Add(new Brand(new List<string> { "GROHE" }, "GROHE"));
            brands.Add(new Brand(new List<string> { "KOHFIX" }, "Kohler®"));
            brands.Add(new Brand(new List<string> { "KOHPAR" }, "Kohler®"));
            brands.Add(new Brand(new List<string> { "SIOUX" }, "Sioux Chief"));
            brands.Add(new Brand(new List<string> { "LANCAS" }, "Lancaster Water Systems"));
            brands.Add(new Brand(new List<string> { "LUXAPA", "LUXACO", "LUXAIR" }, "Luxaire®"));
            brands.Add(new Brand(new List<string> { "MTITUB" }, "MTI Tubs"));
            brands.Add(new Brand(new List<string> { "GERBRF" }, "Gerber®"));
            brands.Add(new Brand(new List<string> { "STERVI" }, "Sterling®"));
            brands.Add(new Brand(new List<string> { "KALLIS" }, "KALLISTA"));
            brands.Add(new Brand(new List<string> { "AOSRES" }, "AO Smith®"));
            brands.Add(new Brand(new List<string> { "COM005" }, "EPC"));
            brands.Add(new Brand(new List<string> { "COM008" }, "Charlotte"));
            brands.Add(new Brand(new List<string> { "ROHL" }, "Rohl®"));
            brands.Add(new Brand(new List<string> { "ROHL" }, "Rohl®"));
            brands.Add(new Brand(new List<string> { "BEMIS" }, "Bemis®"));
            brands.Add(new Brand(new List<string> { "BOOTZ" }, "BOOTZ®"));
            brands.Add(new Brand(new List<string> { "FLEXCO" }, "Flexcon"));
            brands.Add(new Brand(new List<string> { "MOECSI" }, "Moen®"));
            brands.Add(new Brand(new List<string> { "GEBERI" }, "Gerberit"));
            brands.Add(new Brand(new List<string> { "ROBERN" }, "Robern®"));
            brands.Add(new Brand(new List<string> { "PEERLE" }, "Peerless®"));
            brands.Add(new Brand(new List<string> { "CENTRO" }, "Centrotherm Eco Systems"));
            brands.Add(new Brand(new List<string> { "BAINUL" }, "BainUltra"));
            brands.Add(new Brand(new List<string> { "NTINYT" }, "NTI"));
            brands.Add(new Brand(new List<string> { "ONSITE", "IPSCOR" }, "IPS®"));
            brands.Add(new Brand(new List<string> { "LSPPRO" }, "LSP™"));
            brands.Add(new Brand(new List<string> { "BLUEAN" }, "BLUE ANGEL®"));
            brands.Add(new Brand(new List<string> { "MILLRO" }, "Mill-Rose"));
            brands.Add(new Brand(new List<string> { "BONSAL" }, "Sakrete™"));
            brands.Add(new Brand(new List<string> { "GENFIL" }, "General Filters"));
            brands.Add(new Brand(new List<string> { "RWBECK" }, "RW BECKETT CORP"));
            brands.Add(new Brand(new List<string> { "MAINST" }, "Mainstream"));
            brands.Add(new Brand(new List<string> { "MILWTO" }, "Milwaukee®"));
            brands.Add(new Brand(new List<string> { "MANSCH" }, "Mansfield®"));
            brands.Add(new Brand(new List<string> { "RITCHI" }, "RITCHI"));
            brands.Add(new Brand(new List<string> { "AGIS" }, "AGIS"));
            brands.Add(new Brand(new List<string> { "WATTSR" }, "WATTS®"));
            brands.Add(new Brand(new List<string> { "GREENF" }, "Greenfield"));
        }
    }
}
