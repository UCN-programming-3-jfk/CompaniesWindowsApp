
namespace CompaniesClient
{
    partial class CompanyForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkPublicCompany = new System.Windows.Forms.CheckBox();
            this.lblYearlyEarningsInUsDollars = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblNumberOfEmployees = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtNumberOfEmployees = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtYearlyEarningsInUsd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(482, 228);
            this.btnOk.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 33);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(379, 228);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkPublicCompany
            // 
            this.chkPublicCompany.AutoSize = true;
            this.chkPublicCompany.Location = new System.Drawing.Point(218, 195);
            this.chkPublicCompany.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
            this.chkPublicCompany.Name = "chkPublicCompany";
            this.chkPublicCompany.Size = new System.Drawing.Size(136, 24);
            this.chkPublicCompany.TabIndex = 4;
            this.chkPublicCompany.Text = "Public company";
            this.chkPublicCompany.UseVisualStyleBackColor = true;
            // 
            // lblYearlyEarningsInUsDollars
            // 
            this.lblYearlyEarningsInUsDollars.AutoSize = true;
            this.lblYearlyEarningsInUsDollars.Location = new System.Drawing.Point(10, 144);
            this.lblYearlyEarningsInUsDollars.Margin = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.lblYearlyEarningsInUsDollars.Name = "lblYearlyEarningsInUsDollars";
            this.lblYearlyEarningsInUsDollars.Size = new System.Drawing.Size(160, 20);
            this.lblYearlyEarningsInUsDollars.TabIndex = 2;
            this.lblYearlyEarningsInUsDollars.Text = "Yearly earnings in USD:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(10, 98);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(67, 20);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country: ";
            // 
            // lblNumberOfEmployees
            // 
            this.lblNumberOfEmployees.AutoSize = true;
            this.lblNumberOfEmployees.Location = new System.Drawing.Point(10, 51);
            this.lblNumberOfEmployees.Margin = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.lblNumberOfEmployees.Name = "lblNumberOfEmployees";
            this.lblNumberOfEmployees.Size = new System.Drawing.Size(160, 20);
            this.lblNumberOfEmployees.TabIndex = 4;
            this.lblNumberOfEmployees.Text = "Number of employees:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(10, 18);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(116, 20);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Company name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(218, 8);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(347, 27);
            this.txtCompanyName.TabIndex = 0;
            // 
            // txtNumberOfEmployees
            // 
            this.txtNumberOfEmployees.Location = new System.Drawing.Point(218, 51);
            this.txtNumberOfEmployees.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
            this.txtNumberOfEmployees.Name = "txtNumberOfEmployees";
            this.txtNumberOfEmployees.Size = new System.Drawing.Size(216, 27);
            this.txtNumberOfEmployees.TabIndex = 1;
            this.txtNumberOfEmployees.Text = "0";
            this.txtNumberOfEmployees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(218, 94);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(216, 27);
            this.txtCountry.TabIndex = 2;
            // 
            // txtYearlyEarningsInUsd
            // 
            this.txtYearlyEarningsInUsd.Location = new System.Drawing.Point(218, 142);
            this.txtYearlyEarningsInUsd.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
            this.txtYearlyEarningsInUsd.Name = "txtYearlyEarningsInUsd";
            this.txtYearlyEarningsInUsd.Size = new System.Drawing.Size(216, 27);
            this.txtYearlyEarningsInUsd.TabIndex = 3;
            this.txtYearlyEarningsInUsd.Text = "0";
            this.txtYearlyEarningsInUsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CompanyForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(592, 278);
            this.Controls.Add(this.txtYearlyEarningsInUsd);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtNumberOfEmployees);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.chkPublicCompany);
            this.Controls.Add(this.lblYearlyEarningsInUsDollars);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblNumberOfEmployees);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
            this.Name = "CompanyForm";
            this.Text = "Company editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkPublicCompany;
        private System.Windows.Forms.Label lblYearlyEarningsInUsDollars;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblNumberOfEmployees;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtNumberOfEmployees;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtYearlyEarningsInUsd;
    }
}