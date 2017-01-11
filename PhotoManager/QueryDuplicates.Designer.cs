namespace PhotoManager
{
    partial class QueryDuplicates
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
            this.lbDuplicates = new System.Windows.Forms.ListBox();
            this.lblDuplicates = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDuplicates
            // 
            this.lbDuplicates.FormattingEnabled = true;
            this.lbDuplicates.ItemHeight = 25;
            this.lbDuplicates.Location = new System.Drawing.Point(12, 46);
            this.lbDuplicates.Name = "lbDuplicates";
            this.lbDuplicates.Size = new System.Drawing.Size(539, 704);
            this.lbDuplicates.TabIndex = 0;
            // 
            // lblDuplicates
            // 
            this.lblDuplicates.AutoSize = true;
            this.lblDuplicates.Location = new System.Drawing.Point(12, 9);
            this.lblDuplicates.Name = "lblDuplicates";
            this.lblDuplicates.Size = new System.Drawing.Size(0, 25);
            this.lblDuplicates.TabIndex = 1;
            // 
            // QueryDuplicates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 761);
            this.Controls.Add(this.lblDuplicates);
            this.Controls.Add(this.lbDuplicates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "QueryDuplicates";
            this.Text = "QueryDuplicates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDuplicates;
        private System.Windows.Forms.Label lblDuplicates;
    }
}