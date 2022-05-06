namespace WindowsFormsApp1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWordResult = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(234, 83);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWordResult
            // 
            this.btnWordResult.Location = new System.Drawing.Point(110, 83);
            this.btnWordResult.Name = "btnWordResult";
            this.btnWordResult.Size = new System.Drawing.Size(103, 23);
            this.btnWordResult.TabIndex = 1;
            this.btnWordResult.Text = "How Many Words";
            this.btnWordResult.UseVisualStyleBackColor = true;
            this.btnWordResult.Click += new System.EventHandler(this.btnWordResult_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(24, 40);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(285, 20);
            this.txtString.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 205);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnWordResult);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWordResult;
        private System.Windows.Forms.TextBox txtString;
    }
}

