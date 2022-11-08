namespace IOdemo
{
    partial class Form2
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
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(436, 65);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(89, 48);
            this.btnBinaryWrite.TabIndex = 0;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.Location = new System.Drawing.Point(450, 220);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(75, 40);
            this.btnJsonWrite.TabIndex = 1;
            this.btnJsonWrite.Text = "JSON Write";
            this.btnJsonWrite.UseVisualStyleBackColor = true;
            this.btnJsonWrite.Click += new System.EventHandler(this.btnJsonWrite_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(450, 140);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(75, 38);
            this.btnXmlWrite.TabIndex = 2;
            this.btnXmlWrite.Text = "XML Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(607, 65);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(89, 48);
            this.btnBinaryRead.TabIndex = 3;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(616, 140);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(80, 38);
            this.btnXmlRead.TabIndex = 4;
            this.btnXmlRead.Text = "XML Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Location = new System.Drawing.Point(607, 220);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(76, 40);
            this.btnJsonRead.TabIndex = 5;
            this.btnJsonRead.Text = "JSON Read";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            this.btnJsonRead.Click += new System.EventHandler(this.btnJsonRead_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(450, 300);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(82, 43);
            this.btnSoapWrite.TabIndex = 6;
            this.btnSoapWrite.Text = "SOAP Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(597, 300);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(86, 43);
            this.btnSoapRead.TabIndex = 7;
            this.btnSoapRead.Text = "SOAP Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(77, 81);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(83, 16);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Enter Emp Id";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(77, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 16);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Enter Emp Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(77, 220);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(111, 16);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "Enter Emp Salary";
            this.lblSalary.Click += new System.EventHandler(this.lblSalary_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(240, 81);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 11;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(240, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(240, 214);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 13;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.btnBinaryWrite);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnJsonWrite;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnJsonRead;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
    }
}