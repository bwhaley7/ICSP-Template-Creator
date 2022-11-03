using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSP_Template_Creator
{
    internal class Template
    {
        public List<Template> temps = new List<Template> ();
        public List<string> ident = new List<string>();
        public string template;

        public Template() { }
        public Template(List<string> ident, string template)
        {
            this.ident = ident;
            this.template = template;
        }

        public void initTemps()
        {
            temps.Add(new Template(new List<string> { "SEER", "R410A", "FURNACE", "MINI SPLIT", "OIL FURNACE" }, "HVAC Equipment"));
            temps.Add(new Template(new List<string> { "MINI SPLIT WIRE", "OEM HVAC PARTS", "OIL FURNACE PARTS ACCY", "CONDENSATE DRAIN PANS", "ALLANSON TRANSFORMERS" }, "HVAC Supplies & Accessories"));
            temps.Add(new Template(new List<string> { "WATER COND" }, "Water Filters & Dispensers"));
            temps.Add(new Template(new List<string> { "AIR BRACE", "WMOB", "IMOB", "CULTURED MARBLE TOPS" }, "Starter Template"));
            temps.Add(new Template(new List<string> { "PLUMBING SUPPLY AND STOP" }, "Plumbing Hardware"));
            temps.Add(new Template(new List<string> { "ACME DRYER VENT" }, "Venting"));
            temps.Add(new Template(new List<string> { "ACME FURNACE PIPE" }, "Air Distribution"));
            temps.Add(new Template(new List<string> { "DRAIN PIPE" }, "Watering, Irrigation & Drainage"));
            temps.Add(new Template(new List<string> { "FLEX-TEX" }, "Clamping, Workholding & Positioning"));
            temps.Add(new Template(new List<string> { "PARS RUBBER GASKETS", "NON-ASBESTOS FLANGE" }, "Gaskets & Packing"));
            temps.Add(new Template(new List<string> { "BASINS" }, "Pumps"));

        }
    }
}
