namespace PhotoManager
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCurrentWorkingDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminateDuplicates = new System.Windows.Forms.Button();
            this.btnSetWorkingDirectory = new System.Windows.Forms.Button();
            this.btnClearWorkingDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Working Directory";
            // 
            // tbCurrentWorkingDirectory
            // 
            this.tbCurrentWorkingDirectory.Location = new System.Drawing.Point(17, 38);
            this.tbCurrentWorkingDirectory.Name = "tbCurrentWorkingDirectory";
            this.tbCurrentWorkingDirectory.ReadOnly = true;
            this.tbCurrentWorkingDirectory.Size = new System.Drawing.Size(752, 31);
            this.tbCurrentWorkingDirectory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operations";
            // 
            // btnEliminateDuplicates
            // 
            this.btnEliminateDuplicates.Enabled = false;
            this.btnEliminateDuplicates.Location = new System.Drawing.Point(17, 227);
            this.btnEliminateDuplicates.Name = "btnEliminateDuplicates";
            this.btnEliminateDuplicates.Size = new System.Drawing.Size(199, 73);
            this.btnEliminateDuplicates.TabIndex = 4;
            this.btnEliminateDuplicates.Text = "Eliminate Duplicates";
            this.btnEliminateDuplicates.UseVisualStyleBackColor = true;
            this.btnEliminateDuplicates.Click += new System.EventHandler(this.btnEliminateDuplicates_Click);
            // 
            // btnSetWorkingDirectory
            // 
            this.btnSetWorkingDirectory.Location = new System.Drawing.Point(17, 85);
            this.btnSetWorkingDirectory.Name = "btnSetWorkingDirectory";
            this.btnSetWorkingDirectory.Size = new System.Drawing.Size(155, 66);
            this.btnSetWorkingDirectory.TabIndex = 5;
            this.btnSetWorkingDirectory.Text = "Set";
            this.btnSetWorkingDirectory.UseVisualStyleBackColor = true;
            this.btnSetWorkingDirectory.Click += new System.EventHandler(this.btnSetWorkingDirectory_Click);
            // 
            // btnClearWorkingDirectory
            // 
            this.btnClearWorkingDirectory.Location = new System.Drawing.Point(178, 85);
            this.btnClearWorkingDirectory.Name = "btnClearWorkingDirectory";
            this.btnClearWorkingDirectory.Size = new System.Drawing.Size(155, 66);
            this.btnClearWorkingDirectory.TabIndex = 5;
            this.btnClearWorkingDirectory.Text = "Clear";
            this.btnClearWorkingDirectory.UseVisualStyleBackColor = true;
            this.btnClearWorkingDirectory.Click += new System.EventHandler(this.btnClearWorkingDirectory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 312);
            this.Controls.Add(this.btnClearWorkingDirectory);
            this.Controls.Add(this.btnSetWorkingDirectory);
            this.Controls.Add(this.btnEliminateDuplicates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCurrentWorkingDirectory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PhotoManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCurrentWorkingDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminateDuplicates;
        private System.Windows.Forms.Button btnSetWorkingDirectory;
        private System.Windows.Forms.Button btnClearWorkingDirectory;
    }
}

