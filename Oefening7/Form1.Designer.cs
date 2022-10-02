namespace Oefening7
{
    partial class Sum
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
            this.tbRes = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbRes
            // 
            this.tbRes.Enabled = false;
            this.tbRes.Location = new System.Drawing.Point(12, 152);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(274, 23);
            this.tbRes.TabIndex = 1;
            this.tbRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(127, 40);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(130, 23);
            this.tbNumber.TabIndex = 2;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(107, 90);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 197);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.label1);
            this.Name = "Sum";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbRes;
        private TextBox tbNumber;
        private Button btnCalc;
    }
}