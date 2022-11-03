using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ICSP_Template_Creator
{
    internal class Products
    {
        public List<Product> prods = new List<Product>();
        Template templates = new Template();
        Brand brands = new Brand();
        int pNum, comp = 0;
        string prodCat, brand = "";
        DateTime entered;
        public void readFromExcel(DateTime filterDate, string fileName, ProgressBar pbar)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            pbar.Maximum = xlRange.Rows.Count;
            pbar.Value = 0;
            for (int i = 2; i <= xlRange.Rows.Count; i++)
            {
                for (int j = 1; j <= xlRange.Columns.Count; j++)
                {
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        switch (j)
                        {
                            case 1:
                                pNum = Convert.ToInt32(xlRange.Cells[i, j].Value2);
                                break;
                            case 3:
                                brand = xlRange.Cells[i, j].Value2;
                                break;
                            case 8:
                                //MessageBox.Show(comp.ToString() + " : " + Convert.ToDateTime(xlRange.Cells[i, j].Text) + " : " + filterDate);
                                entered = Convert.ToDateTime(xlRange.Cells[i, j].Text);
                                break;
                            case 9:
                                prodCat = xlRange.Cells[i, j].Value2;
                                break;
                            default:
                                break;
                        }
                    }
                }
                comp = DateTime.Compare(entered, filterDate);
                if(comp > 0)
                    prods.Add(new Product(pNum, prodCat, brand, entered));
                pbar.Value += 1;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        public void writeToExcel()
        {
            //writeCategory();
            writeProduct();
        }

        public void writeCategory()
        {
            
        }

        public void writeProduct()
        {
            Excel.Application xlApp = new Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Add();
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            xlWorksheet.Cells[1, 1] = "Product Number";
            xlWorksheet.Cells[1, 2] = "Product Template";
            xlWorksheet.Cells[1, 3] = "Brand";
            int i = 2;
            foreach (Product p in prods)
            {
                for(int j = 1; j <= 3; j++)
                {
                    switch (j)
                    {
                        case 1:
                            xlWorksheet.Cells[i, j] = p.prodNum;
                            break;
                        case 2:
                            xlWorksheet.Cells[i, j] = p.template;
                            break;
                        case 3:
                            xlWorksheet.Cells[i, j] = p.brandCode;
                            break;
                        default:
                            xlWorksheet.Cells[i, j] = "Error";
                            break;
                    }
                }
                i++;
            }
            xlWorkbook.SaveAs2(@".\product_import", Excel.XlFileFormat.xlWorkbookNormal);
            xlWorkbook.Close();
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorksheet);
            Marshal.ReleaseComObject(xlWorkbook);
            Marshal.ReleaseComObject(xlApp);
        }

        public void assignValues()
        {
            templates.initTemps();
            brands.initBrands();

            foreach (Product p in prods)
            {
                decideTemplate(p);
                decideBrand(p);
            }
        }

        public void decideTemplate(Product prod)
        {
            foreach (Template t in templates.temps)
            {
                if (t.ident.Any(s => prod.prodCatDesc.Contains(s)))
                    prod.template = t.template;
            }
        }

        public void decideBrand(Product prod)
        {
            foreach (Brand b in brands.brands)
            {
                if (b.ident.Any(s => prod.brandCode.Contains(s)))
                    prod.brandCode = b.brand;
            }
        }
    }
}
