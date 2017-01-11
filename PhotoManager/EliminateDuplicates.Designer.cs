namespace PhotoManager
{
    partial class EliminateDuplicates
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
            this.flpFileTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDestinationDirectory = new System.Windows.Forms.TextBox();
            this.btnEliminate = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Type To Keep:";
            // 
            // flpFileTypes
            // 
            this.flpFileTypes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFileTypes.Location = new System.Drawing.Point(13, 42);
            this.flpFileTypes.Name = "flpFileTypes";
            this.flpFileTypes.Size = new System.Drawing.Size(273, 269);
            this.flpFileTypes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Move Others To:";
            // 
            // tbDestinationDirectory
            // 
            this.tbDestinationDirectory.Location = new System.Drawing.Point(321, 42);
            this.tbDestinationDirectory.Name = "tbDestinationDirectory";
            this.tbDestinationDirectory.Size = new System.Drawing.Size(625, 31);
            this.tbDestinationDirectory.TabIndex = 3;
            // 
            // btnEliminate
            // 
            this.btnEliminate.Location = new System.Drawing.Point(558, 103);
            this.btnEliminate.Name = "btnEliminate";
            this.btnEliminate.Size = new System.Drawing.Size(231, 114);
            this.btnEliminate.TabIndex = 4;
            this.btnEliminate.Text = "Eliminate!";
            this.btnEliminate.UseVisualStyleBackColor = true;
            this.btnEliminate.Click += new System.EventHandler(this.btnEliminate_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(321, 103);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(231, 114);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // EliminateDuplicates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 318);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnEliminate);
            this.Controls.Add(this.tbDestinationDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpFileTypes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EliminateDuplicates";
            this.Text = "EliminateDuplicates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpFileTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDestinationDirectory;
        private System.Windows.Forms.Button btnEliminate;
        private System.Windows.Forms.Button btnQuery;
    }
}