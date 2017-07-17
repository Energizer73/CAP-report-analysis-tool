namespace CAP_report_analysis_tool
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadIdeal = new System.Windows.Forms.Button();
            this.buttonLoadCurrent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonLoadIdeal
            // 
            this.buttonLoadIdeal.Location = new System.Drawing.Point(70, 83);
            this.buttonLoadIdeal.Name = "buttonLoadIdeal";
            this.buttonLoadIdeal.Size = new System.Drawing.Size(166, 23);
            this.buttonLoadIdeal.TabIndex = 0;
            this.buttonLoadIdeal.Text = "buttonLoadIdeal";
            this.buttonLoadIdeal.UseVisualStyleBackColor = true;
            this.buttonLoadIdeal.Click += new System.EventHandler(this.buttonLoadIdeal_Click);
            // 
            // buttonLoadCurrent
            // 
            this.buttonLoadCurrent.Location = new System.Drawing.Point(362, 82);
            this.buttonLoadCurrent.Name = "buttonLoadCurrent";
            this.buttonLoadCurrent.Size = new System.Drawing.Size(148, 23);
            this.buttonLoadCurrent.TabIndex = 1;
            this.buttonLoadCurrent.Text = "LoadCurrent";
            this.buttonLoadCurrent.UseVisualStyleBackColor = true;
            this.buttonLoadCurrent.Click += new System.EventHandler(this.buttonLoadCurrent_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLoadCurrent);
            this.Controls.Add(this.buttonLoadIdeal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonLoadIdeal;
        private System.Windows.Forms.Button buttonLoadCurrent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}

