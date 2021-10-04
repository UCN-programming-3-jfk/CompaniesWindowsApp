
namespace CompaniesClient
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstCompanies = new System.Windows.Forms.ListBox();
            this.btnNewCompany = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.chkPublicCompany = new System.Windows.Forms.CheckBox();
            this.lblYearlyEarningsInUsDollars = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblNumberOfEmployees = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(29, 15, 29, 15);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstCompanies);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnNewCompany);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel2.Controls.Add(this.chkPublicCompany);
            this.splitContainer1.Panel2.Controls.Add(this.lblYearlyEarningsInUsDollars);
            this.splitContainer1.Panel2.Controls.Add(this.lblCountry);
            this.splitContainer1.Panel2.Controls.Add(this.lblNumberOfEmployees);
            this.splitContainer1.Panel2.Controls.Add(this.lblCompanyName);
            this.splitContainer1.Size = new System.Drawing.Size(656, 374);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstCompanies
            // 
            this.lstCompanies.DisplayMember = "Name";
            this.lstCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCompanies.FormattingEnabled = true;
            this.lstCompanies.ItemHeight = 25;
            this.lstCompanies.Location = new System.Drawing.Point(0, 0);
            this.lstCompanies.Margin = new System.Windows.Forms.Padding(29, 15, 29, 15);
            this.lstCompanies.Name = "lstCompanies";
            this.lstCompanies.Size = new System.Drawing.Size(209, 374);
            this.lstCompanies.TabIndex = 0;
            this.lstCompanies.SelectedIndexChanged += new System.EventHandler(this.lstCompanies_SelectedIndexChanged);
            this.lstCompanies.DoubleClick += new System.EventHandler(this.lstCompanies_DoubleClick);
            // 
            // btnNewCompany
            // 
            this.btnNewCompany.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewCompany.Location = new System.Drawing.Point(242, 251);
            this.btnNewCompany.Margin = new System.Windows.Forms.Padding(22, 9, 22, 9);
            this.btnNewCompany.Name = "btnNewCompany";
            this.btnNewCompany.Size = new System.Drawing.Size(80, 33);
            this.btnNewCompany.TabIndex = 2;
            this.btnNewCompany.Text = "&New";
            this.btnNewCompany.UseVisualStyleBackColor = true;
            this.btnNewCompany.Click += new System.EventHandler(this.btnNewCompany_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(144, 251);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(22, 9, 22, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(36, 251);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(22, 9, 22, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 33);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // chkPublicCompany
            // 
            this.chkPublicCompany.AutoSize = true;
            this.chkPublicCompany.Enabled = false;
            this.chkPublicCompany.Location = new System.Drawing.Point(22, 190);
            this.chkPublicCompany.Margin = new System.Windows.Forms.Padding(22, 9, 22, 9);
            this.chkPublicCompany.Name = "chkPublicCompany";
            this.chkPublicCompany.Size = new System.Drawing.Size(165, 29);
            this.chkPublicCompany.TabIndex = 1;
            this.chkPublicCompany.Text = "Public company";
            this.chkPublicCompany.UseVisualStyleBackColor = true;
            // 
            // lblYearlyEarningsInUsDollars
            // 
            this.lblYearlyEarningsInUsDollars.AutoSize = true;
            this.lblYearlyEarningsInUsDollars.Location = new System.Drawing.Point(22, 142);
            this.lblYearlyEarningsInUsDollars.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.lblYearlyEarningsInUsDollars.Name = "lblYearlyEarningsInUsDollars";
            this.lblYearlyEarningsInUsDollars.Size = new System.Drawing.Size(206, 25);
            this.lblYearlyEarningsInUsDollars.TabIndex = 0;
            this.lblYearlyEarningsInUsDollars.Text = "Yearly earnings in USD:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(22, 94);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(88, 25);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country: ";
            // 
            // lblNumberOfEmployees
            // 
            this.lblNumberOfEmployees.AutoSize = true;
            this.lblNumberOfEmployees.Location = new System.Drawing.Point(22, 48);
            this.lblNumberOfEmployees.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.lblNumberOfEmployees.Name = "lblNumberOfEmployees";
            this.lblNumberOfEmployees.Size = new System.Drawing.Size(202, 25);
            this.lblNumberOfEmployees.TabIndex = 0;
            this.lblNumberOfEmployees.Text = "Number of employees:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(22, 13);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(148, 25);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(656, 374);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(29, 15, 29, 15);
            this.Name = "MainForm";
            this.Text = "Companies client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstCompanies;
        private System.Windows.Forms.Label lblYearlyEarningsInUsDollars;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblNumberOfEmployees;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox chkPublicCompany;
        private System.Windows.Forms.Button btnNewCompany;
    }
}

