
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
            this.btnOk.Location = new System.Drawing.Point(405, 248);
            this.btnOk.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 50);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(213, 248);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkPublicCompany
            // 
            this.chkPublicCompany.AutoSize = true;
            this.chkPublicCompany.Enabled = false;
            this.chkPublicCompany.Location = new System.Drawing.Point(8, 201);
            this.chkPublicCompany.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            this.chkPublicCompany.Name = "chkPublicCompany";
            this.chkPublicCompany.Size = new System.Drawing.Size(112, 19);
            this.chkPublicCompany.TabIndex = 6;
            this.chkPublicCompany.Text = "Public company";
            this.chkPublicCompany.UseVisualStyleBackColor = true;
            // 
            // lblYearlyEarningsInUsDollars
            // 
            this.lblYearlyEarningsInUsDollars.AutoSize = true;
            this.lblYearlyEarningsInUsDollars.Location = new System.Drawing.Point(8, 156);
            this.lblYearlyEarningsInUsDollars.Margin = new System.Windows.Forms.Padding(36, 0, 36, 0);
            this.lblYearlyEarningsInUsDollars.Name = "lblYearlyEarningsInUsDollars";
            this.lblYearlyEarningsInUsDollars.Size = new System.Drawing.Size(127, 15);
            this.lblYearlyEarningsInUsDollars.TabIndex = 2;
            this.lblYearlyEarningsInUsDollars.Text = "Yearly earnings in USD:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(8, 107);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(36, 0, 36, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(56, 15);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country: ";
            // 
            // lblNumberOfEmployees
            // 
            this.lblNumberOfEmployees.AutoSize = true;
            this.lblNumberOfEmployees.Location = new System.Drawing.Point(8, 60);
            this.lblNumberOfEmployees.Margin = new System.Windows.Forms.Padding(36, 0, 36, 0);
            this.lblNumberOfEmployees.Name = "lblNumberOfEmployees";
            this.lblNumberOfEmployees.Size = new System.Drawing.Size(128, 15);
            this.lblNumberOfEmployees.TabIndex = 4;
            this.lblNumberOfEmployees.Text = "Number of employees:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(8, 15);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(36, 0, 36, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(95, 15);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Company name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(175, 7);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(400, 23);
            this.txtCompanyName.TabIndex = 7;
            // 
            // txtNumberOfEmployees
            // 
            this.txtNumberOfEmployees.Location = new System.Drawing.Point(175, 60);
            this.txtNumberOfEmployees.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            this.txtNumberOfEmployees.Name = "txtNumberOfEmployees";
            this.txtNumberOfEmployees.Size = new System.Drawing.Size(173, 23);
            this.txtNumberOfEmployees.TabIndex = 7;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(175, 104);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(173, 23);
            this.txtCountry.TabIndex = 7;
            // 
            // txtYearlyEarningsInUsd
            // 
            this.txtYearlyEarningsInUsd.Location = new System.Drawing.Point(175, 155);
            this.txtYearlyEarningsInUsd.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
            this.txtYearlyEarningsInUsd.Name = "txtYearlyEarningsInUsd";
            this.txtYearlyEarningsInUsd.Size = new System.Drawing.Size(173, 23);
            this.txtYearlyEarningsInUsd.TabIndex = 7;
            // 
            // CompanyForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(595, 314);
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
            this.Margin = new System.Windows.Forms.Padding(36, 14, 36, 14);
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