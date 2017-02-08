namespace Izpit_form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioCountry = new System.Windows.Forms.RadioButton();
            this.radioCapital = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.textCapital = new System.Windows.Forms.TextBox();
            this.numericPopulation = new System.Windows.Forms.NumericUpDown();
            this.numericMin = new System.Windows.Forms.NumericUpDown();
            this.numericMax = new System.Windows.Forms.NumericUpDown();
            this.SearchCount = new System.Windows.Forms.TextBox();
            this.SearchCap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ListAllbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SearchCap);
            this.groupBox1.Controls.Add(this.SearchCount);
            this.groupBox1.Controls.Add(this.numericMax);
            this.groupBox1.Controls.Add(this.numericMin);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioCapital);
            this.groupBox1.Controls.Add(this.radioCountry);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListAllbutton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericPopulation);
            this.groupBox2.Controls.Add(this.textCapital);
            this.groupBox2.Controls.Add(this.textCountry);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioCountry
            // 
            this.radioCountry.AutoSize = true;
            this.radioCountry.Location = new System.Drawing.Point(6, 19);
            this.radioCountry.Name = "radioCountry";
            this.radioCountry.Size = new System.Drawing.Size(79, 17);
            this.radioCountry.TabIndex = 0;
            this.radioCountry.TabStop = true;
            this.radioCountry.Text = "By Country:";
            this.radioCountry.UseVisualStyleBackColor = true;
            this.radioCountry.CheckedChanged += new System.EventHandler(this.radioCountry_CheckedChanged);
            // 
            // radioCapital
            // 
            this.radioCapital.AutoSize = true;
            this.radioCapital.Location = new System.Drawing.Point(6, 53);
            this.radioCapital.Name = "radioCapital";
            this.radioCapital.Size = new System.Drawing.Size(75, 17);
            this.radioCapital.TabIndex = 1;
            this.radioCapital.TabStop = true;
            this.radioCapital.Text = "By Capital:";
            this.radioCapital.UseVisualStyleBackColor = true;
            this.radioCapital.CheckedChanged += new System.EventHandler(this.radioCapital_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 88);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(123, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "By Population range:";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 367);
            this.dataGridView1.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(6, 166);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(110, 24);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(6, 136);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(101, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add Country";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textCountry
            // 
            this.textCountry.Location = new System.Drawing.Point(93, 31);
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(137, 20);
            this.textCountry.TabIndex = 1;
            // 
            // textCapital
            // 
            this.textCapital.Location = new System.Drawing.Point(93, 69);
            this.textCapital.Name = "textCapital";
            this.textCapital.Size = new System.Drawing.Size(137, 20);
            this.textCapital.TabIndex = 2;
            // 
            // numericPopulation
            // 
            this.numericPopulation.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPopulation.Location = new System.Drawing.Point(116, 105);
            this.numericPopulation.Maximum = new decimal(new int[] {
            -1294967296,
            0,
            0,
            0});
            this.numericPopulation.Name = "numericPopulation";
            this.numericPopulation.Size = new System.Drawing.Size(114, 20);
            this.numericPopulation.TabIndex = 3;
            // 
            // numericMin
            // 
            this.numericMin.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericMin.Location = new System.Drawing.Point(6, 134);
            this.numericMin.Maximum = new decimal(new int[] {
            -1294967296,
            0,
            0,
            0});
            this.numericMin.Name = "numericMin";
            this.numericMin.Size = new System.Drawing.Size(92, 20);
            this.numericMin.TabIndex = 4;
            // 
            // numericMax
            // 
            this.numericMax.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericMax.Location = new System.Drawing.Point(162, 134);
            this.numericMax.Maximum = new decimal(new int[] {
            -1294967296,
            0,
            0,
            0});
            this.numericMax.Name = "numericMax";
            this.numericMax.Size = new System.Drawing.Size(92, 20);
            this.numericMax.TabIndex = 5;
            // 
            // SearchCount
            // 
            this.SearchCount.Location = new System.Drawing.Point(91, 19);
            this.SearchCount.Name = "SearchCount";
            this.SearchCount.Size = new System.Drawing.Size(181, 20);
            this.SearchCount.TabIndex = 6;
            // 
            // SearchCap
            // 
            this.SearchCap.Location = new System.Drawing.Point(87, 53);
            this.SearchCap.Name = "SearchCap";
            this.SearchCap.Size = new System.Drawing.Size(185, 20);
            this.SearchCap.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Minimum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Maximum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Country Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Capital Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Population Count;";
            // 
            // ListAllbutton
            // 
            this.ListAllbutton.Location = new System.Drawing.Point(116, 136);
            this.ListAllbutton.Name = "ListAllbutton";
            this.ListAllbutton.Size = new System.Drawing.Size(114, 23);
            this.ListAllbutton.TabIndex = 7;
            this.ListAllbutton.Text = "List All";
            this.ListAllbutton.UseVisualStyleBackColor = true;
            this.ListAllbutton.Click += new System.EventHandler(this.ListAllbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 391);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioCapital;
        private System.Windows.Forms.RadioButton radioCountry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchCap;
        private System.Windows.Forms.TextBox SearchCount;
        private System.Windows.Forms.NumericUpDown numericMax;
        private System.Windows.Forms.NumericUpDown numericMin;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.NumericUpDown numericPopulation;
        private System.Windows.Forms.TextBox textCapital;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ListAllbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

