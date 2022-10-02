namespace Oefening5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ftb = new System.Windows.Forms.TextBox();
            this.Ctb = new System.Windows.Forms.TextBox();
            this.conv1 = new System.Windows.Forms.Button();
            this.conv2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit";
            // 
            // Ftb
            // 
            this.Ftb.Location = new System.Drawing.Point(237, 99);
            this.Ftb.Name = "Ftb";
            this.Ftb.Size = new System.Drawing.Size(100, 23);
            this.Ftb.TabIndex = 2;
            // 
            // Ctb
            // 
            this.Ctb.Location = new System.Drawing.Point(88, 99);
            this.Ctb.Name = "Ctb";
            this.Ctb.Size = new System.Drawing.Size(100, 23);
            this.Ctb.TabIndex = 3;
            // 
            // conv1
            // 
            this.conv1.Location = new System.Drawing.Point(99, 141);
            this.conv1.Name = "conv1";
            this.conv1.Size = new System.Drawing.Size(75, 23);
            this.conv1.TabIndex = 4;
            this.conv1.Text = "C° to F";
            this.conv1.UseVisualStyleBackColor = true;
            this.conv1.Click += new System.EventHandler(this.conv1_Click);
            // 
            // conv2
            // 
            this.conv2.Location = new System.Drawing.Point(254, 141);
            this.conv2.Name = "conv2";
            this.conv2.Size = new System.Drawing.Size(75, 23);
            this.conv2.TabIndex = 5;
            this.conv2.Text = "F to C°";
            this.conv2.UseVisualStyleBackColor = true;
            this.conv2.Click += new System.EventHandler(this.conv2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 269);
            this.Controls.Add(this.conv2);
            this.Controls.Add(this.conv1);
            this.Controls.Add(this.Ctb);
            this.Controls.Add(this.Ftb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Ftb;
        private TextBox Ctb;
        private Button conv1;
        private Button conv2;
    }
}