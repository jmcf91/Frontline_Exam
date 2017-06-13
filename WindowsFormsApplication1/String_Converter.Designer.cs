namespace WindowsFormsApplication1
{
    partial class String_Converter
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.lstBxResults = new System.Windows.Forms.ListBox();
            this.lblString = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(177, 92);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 28);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lstBxResults
            // 
            this.lstBxResults.FormattingEnabled = true;
            this.lstBxResults.Location = new System.Drawing.Point(126, 126);
            this.lstBxResults.Name = "lstBxResults";
            this.lstBxResults.Size = new System.Drawing.Size(179, 121);
            this.lstBxResults.TabIndex = 1;
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(56, 54);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(351, 13);
            this.lblString.TabIndex = 2;
            this.lblString.Text = "\"(id,created,employee(id,firstname,employeeType(id), lastname),location)\"";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(161, 41);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(108, 13);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Click Print to convert:";
            // 
            // String_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 283);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.lstBxResults);
            this.Controls.Add(this.btnPrint);
            this.Name = "String_Converter";
            this.Text = "String Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListBox lstBxResults;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblInstructions;
    }
}

