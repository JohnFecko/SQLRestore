namespace SQLRestore
{
    partial class c
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
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(13, 47);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(13, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(303, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(94, 47);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(10, 5);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(48, 13);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "File Path";
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(11, 90);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(84, 13);
            this.lblDatabaseName.TabIndex = 6;
            this.lblDatabaseName.Text = "Database Name";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatabaseName.Location = new System.Drawing.Point(14, 106);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(303, 20);
            this.txtDatabaseName.TabIndex = 5;
            // 
            // c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 216);
            this.Controls.Add(this.lblDatabaseName);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "c";
            this.Text = "SQL Restore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

