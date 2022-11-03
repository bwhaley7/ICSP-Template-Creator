namespace ICSP_Template_Creator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.importExcel = new System.Windows.Forms.Button();
            this.numProdObjects = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // importExcel
            // 
            this.importExcel.Location = new System.Drawing.Point(12, 415);
            this.importExcel.Name = "importExcel";
            this.importExcel.Size = new System.Drawing.Size(104, 23);
            this.importExcel.TabIndex = 0;
            this.importExcel.Text = "Import Excel";
            this.importExcel.UseVisualStyleBackColor = true;
            this.importExcel.Click += new System.EventHandler(this.importExcel_Click);
            // 
            // numProdObjects
            // 
            this.numProdObjects.AutoSize = true;
            this.numProdObjects.Location = new System.Drawing.Point(12, 347);
            this.numProdObjects.Name = "numProdObjects";
            this.numProdObjects.Size = new System.Drawing.Size(95, 15);
            this.numProdObjects.TabIndex = 1;
            this.numProdObjects.Text = "Product Objects:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(122, 415);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 23);
            this.datePicker.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodNum,
            this.brand,
            this.entered,
            this.prodCat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(444, 303);
            this.dataGridView1.TabIndex = 3;
            // 
            // prodNum
            // 
            this.prodNum.HeaderText = "Product Number";
            this.prodNum.Name = "prodNum";
            this.prodNum.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // entered
            // 
            this.entered.HeaderText = "Enter Date";
            this.entered.Name = "entered";
            this.entered.ReadOnly = true;
            // 
            // prodCat
            // 
            this.prodCat.HeaderText = "Product Cat";
            this.prodCat.Name = "prodCat";
            this.prodCat.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 321);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(444, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Assign";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.numProdObjects);
            this.Controls.Add(this.importExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ICSP Template Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button importExcel;
        private Label numProdObjects;
        private DateTimePicker datePicker;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn prodNum;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn entered;
        private DataGridViewTextBoxColumn prodCat;
        private Button button2;
        private ProgressBar progressBar1;
        private Button button1;
        private Button button3;
    }
}