namespace ICSP_Template_Creator
{
    public partial class Form1 : Form
    {
        Products prodList = new Products();
        public Form1()
        {
            InitializeComponent();
        }

        private void importExcel_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Select Excel File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xlsx",
                Filter = "excel files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,
                ShowReadOnly = true,
            };
            if(ofd.ShowDialog() == DialogResult.OK)
                prodList.readFromExcel(Convert.ToDateTime(datePicker.Value), ofd.FileName, progressBar1);
            if (prodList.prods.Count > 0)
            {
                foreach (Product prod in prodList.prods)
                {
                    dataGridView1.Rows.Add(prod.prodNum, prod.brandCode, prod.enterDate, prod.prodCatDesc);
                }
            }
            numProdObjects.Text = "Product Objects: " + prodList.prods.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            dataGridView1.Rows.Clear();
            prodList.prods.Clear();
            numProdObjects.Text = "Product Objects: " + prodList.prods.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prodList.assignValues();
            dataGridView1.Rows.Clear();
            if (prodList.prods.Count > 0)
            {
                foreach (Product prod in prodList.prods)
                {
                    dataGridView1.Rows.Add(prod.prodNum, prod.brandCode, prod.enterDate, prod.prodCatDesc);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prodList.writeToExcel();
        }
    }
}