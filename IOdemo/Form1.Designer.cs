namespace IOdemo
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(462, 241);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(326, 241);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(326, 300);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(75, 48);
            this.btnCreateDirectory.TabIndex = 2;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(462, 300);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(75, 48);
            this.btnCreateFile.TabIndex = 3;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(337, 41);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(83, 16);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "Enter Emp Id";
            this.lblid.Click += new System.EventHandler(this.lblid_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(337, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Enter Emp Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(337, 144);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(123, 16);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Enter Emp Location";
            this.lblLocation.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(462, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(462, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(462, 138);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
    }
}

