namespace Oefening4
{
    partial class SalesTaxCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemBx1 = new System.Windows.Forms.TextBox();
            this.itemBx4 = new System.Windows.Forms.TextBox();
            this.itemBx3 = new System.Windows.Forms.TextBox();
            this.itemBx2 = new System.Windows.Forms.TextBox();
            this.q1 = new System.Windows.Forms.NumericUpDown();
            this.q2 = new System.Windows.Forms.NumericUpDown();
            this.q3 = new System.Windows.Forms.NumericUpDown();
            this.q4 = new System.Windows.Forms.NumericUpDown();
            this.PE1 = new System.Windows.Forms.TextBox();
            this.PE4 = new System.Windows.Forms.TextBox();
            this.PE3 = new System.Windows.Forms.TextBox();
            this.PE2 = new System.Windows.Forms.TextBox();
            this.EP4 = new System.Windows.Forms.TextBox();
            this.EP3 = new System.Windows.Forms.TextBox();
            this.EP2 = new System.Windows.Forms.TextBox();
            this.EP1 = new System.Windows.Forms.TextBox();
            this.Subt = new System.Windows.Forms.TextBox();
            this.Ship = new System.Windows.Forms.TextBox();
            this.SalT = new System.Windows.Forms.TextBox();
            this.TaxR = new System.Windows.Forms.TextBox();
            this.GT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.q1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price Each";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ext. Price";
            // 
            // itemBx1
            // 
            this.itemBx1.Location = new System.Drawing.Point(56, 85);
            this.itemBx1.Name = "itemBx1";
            this.itemBx1.Size = new System.Drawing.Size(100, 23);
            this.itemBx1.TabIndex = 4;
            // 
            // itemBx4
            // 
            this.itemBx4.Location = new System.Drawing.Point(56, 172);
            this.itemBx4.Name = "itemBx4";
            this.itemBx4.Size = new System.Drawing.Size(100, 23);
            this.itemBx4.TabIndex = 5;
            this.itemBx4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // itemBx3
            // 
            this.itemBx3.Location = new System.Drawing.Point(56, 143);
            this.itemBx3.Name = "itemBx3";
            this.itemBx3.Size = new System.Drawing.Size(100, 23);
            this.itemBx3.TabIndex = 6;
            // 
            // itemBx2
            // 
            this.itemBx2.Location = new System.Drawing.Point(56, 114);
            this.itemBx2.Name = "itemBx2";
            this.itemBx2.Size = new System.Drawing.Size(100, 23);
            this.itemBx2.TabIndex = 7;
            // 
            // q1
            // 
            this.q1.Location = new System.Drawing.Point(197, 85);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(43, 23);
            this.q1.TabIndex = 8;
            this.q1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // q2
            // 
            this.q2.Location = new System.Drawing.Point(197, 115);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(43, 23);
            this.q2.TabIndex = 9;
            // 
            // q3
            // 
            this.q3.Location = new System.Drawing.Point(197, 144);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(43, 23);
            this.q3.TabIndex = 10;
            // 
            // q4
            // 
            this.q4.Location = new System.Drawing.Point(197, 173);
            this.q4.Name = "q4";
            this.q4.Size = new System.Drawing.Size(43, 23);
            this.q4.TabIndex = 11;
            // 
            // PE1
            // 
            this.PE1.Location = new System.Drawing.Point(292, 85);
            this.PE1.Name = "PE1";
            this.PE1.Size = new System.Drawing.Size(65, 23);
            this.PE1.TabIndex = 12;
            this.PE1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PE4
            // 
            this.PE4.Location = new System.Drawing.Point(292, 173);
            this.PE4.Name = "PE4";
            this.PE4.Size = new System.Drawing.Size(65, 23);
            this.PE4.TabIndex = 13;
            this.PE4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PE3
            // 
            this.PE3.Location = new System.Drawing.Point(292, 144);
            this.PE3.Name = "PE3";
            this.PE3.Size = new System.Drawing.Size(65, 23);
            this.PE3.TabIndex = 14;
            this.PE3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PE2
            // 
            this.PE2.Location = new System.Drawing.Point(292, 115);
            this.PE2.Name = "PE2";
            this.PE2.Size = new System.Drawing.Size(65, 23);
            this.PE2.TabIndex = 15;
            this.PE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EP4
            // 
            this.EP4.Enabled = false;
            this.EP4.Location = new System.Drawing.Point(411, 173);
            this.EP4.Name = "EP4";
            this.EP4.Size = new System.Drawing.Size(65, 23);
            this.EP4.TabIndex = 16;
            this.EP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EP3
            // 
            this.EP3.Enabled = false;
            this.EP3.Location = new System.Drawing.Point(411, 144);
            this.EP3.Name = "EP3";
            this.EP3.Size = new System.Drawing.Size(65, 23);
            this.EP3.TabIndex = 17;
            this.EP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EP2
            // 
            this.EP2.Enabled = false;
            this.EP2.Location = new System.Drawing.Point(411, 115);
            this.EP2.Name = "EP2";
            this.EP2.Size = new System.Drawing.Size(65, 23);
            this.EP2.TabIndex = 18;
            this.EP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EP1
            // 
            this.EP1.Enabled = false;
            this.EP1.Location = new System.Drawing.Point(411, 85);
            this.EP1.Name = "EP1";
            this.EP1.Size = new System.Drawing.Size(65, 23);
            this.EP1.TabIndex = 19;
            this.EP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Subt
            // 
            this.Subt.Enabled = false;
            this.Subt.Location = new System.Drawing.Point(411, 270);
            this.Subt.Name = "Subt";
            this.Subt.Size = new System.Drawing.Size(65, 23);
            this.Subt.TabIndex = 20;
            this.Subt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Ship
            // 
            this.Ship.Location = new System.Drawing.Point(411, 357);
            this.Ship.Name = "Ship";
            this.Ship.Size = new System.Drawing.Size(65, 23);
            this.Ship.TabIndex = 21;
            this.Ship.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SalT
            // 
            this.SalT.Enabled = false;
            this.SalT.Location = new System.Drawing.Point(411, 328);
            this.SalT.Name = "SalT";
            this.SalT.Size = new System.Drawing.Size(65, 23);
            this.SalT.TabIndex = 22;
            this.SalT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TaxR
            // 
            this.TaxR.Location = new System.Drawing.Point(411, 299);
            this.TaxR.Name = "TaxR";
            this.TaxR.Size = new System.Drawing.Size(65, 23);
            this.TaxR.TabIndex = 23;
            this.TaxR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GT
            // 
            this.GT.Enabled = false;
            this.GT.Location = new System.Drawing.Point(411, 386);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(65, 23);
            this.GT.TabIndex = 24;
            this.GT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Subtotal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tax Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Sales Tax";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Shipping";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Grand Total";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(123, 328);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 30;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // SalesTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 604);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GT);
            this.Controls.Add(this.TaxR);
            this.Controls.Add(this.SalT);
            this.Controls.Add(this.Ship);
            this.Controls.Add(this.Subt);
            this.Controls.Add(this.EP1);
            this.Controls.Add(this.EP2);
            this.Controls.Add(this.EP3);
            this.Controls.Add(this.EP4);
            this.Controls.Add(this.PE2);
            this.Controls.Add(this.PE3);
            this.Controls.Add(this.PE4);
            this.Controls.Add(this.PE1);
            this.Controls.Add(this.q4);
            this.Controls.Add(this.q3);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.itemBx2);
            this.Controls.Add(this.itemBx3);
            this.Controls.Add(this.itemBx4);
            this.Controls.Add(this.itemBx1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalesTaxCalculator";
            this.Text = "SalesTaxCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.q1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox itemBx1;
        private TextBox itemBx4;
        private TextBox itemBx3;
        private TextBox itemBx2;
        private NumericUpDown q1;
        private NumericUpDown q2;
        private NumericUpDown q3;
        private NumericUpDown q4;
        private TextBox PE1;
        private TextBox PE4;
        private TextBox PE3;
        private TextBox PE2;
        private TextBox EP4;
        private TextBox EP3;
        private TextBox EP2;
        private TextBox EP1;
        private TextBox Subt;
        private TextBox Ship;
        private TextBox SalT;
        private TextBox TaxR;
        private TextBox GT;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button CalcBtn;
    }
}