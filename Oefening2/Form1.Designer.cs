namespace Oefening2
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
            this.resultLb1 = new System.Windows.Forms.Label();
            this.resultLb2 = new System.Windows.Forms.Label();
            this.resultLb3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLb1
            // 
            this.resultLb1.AutoSize = true;
            this.resultLb1.Location = new System.Drawing.Point(159, 40);
            this.resultLb1.Name = "resultLb1";
            this.resultLb1.Size = new System.Drawing.Size(89, 15);
            this.resultLb1.TabIndex = 0;
            this.resultLb1.Text = "12345 * 54321 =";
            this.resultLb1.Click += new System.EventHandler(this.resultLb1_Click);
            // 
            // resultLb2
            // 
            this.resultLb2.AutoSize = true;
            this.resultLb2.Location = new System.Drawing.Point(159, 88);
            this.resultLb2.Name = "resultLb2";
            this.resultLb2.Size = new System.Drawing.Size(92, 15);
            this.resultLb2.TabIndex = 1;
            this.resultLb2.Text = "22222 * 33333 = ";
            this.resultLb2.Click += new System.EventHandler(this.resultLb2_Click);
            // 
            // resultLb3
            // 
            this.resultLb3.AutoSize = true;
            this.resultLb3.Location = new System.Drawing.Point(159, 141);
            this.resultLb3.Name = "resultLb3";
            this.resultLb3.Size = new System.Drawing.Size(174, 15);
            this.resultLb3.TabIndex = 2;
            this.resultLb3.Text = "12345 * 54321 > 22222 * 33333 =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 283);
            this.Controls.Add(this.resultLb3);
            this.Controls.Add(this.resultLb2);
            this.Controls.Add(this.resultLb1);
            this.Name = "Form1";
            this.Text = "IsItBigger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label resultLb1;
        private Label resultLb2;
        private Label resultLb3;
    }
}