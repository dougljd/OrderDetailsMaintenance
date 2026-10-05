namespace OrderDetailsMaintenance
{
    partial class frmCustomerMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// true if managed resources should be disposed; otherwise, false.
        /// </param>

        // Jonathan Douglas
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

        // Jonathan Douglas
        private void InitializeComponent()
        {
            label1 = new Label();
            btnFind = new Button();
            btnExit = new Button();
            txtCustomerId = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            btnSave = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCountry = new TextBox();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 0;
            label1.Text = "Search by Customer ID:";

            // 
            // btnFind
            // 
            btnFind.Location = new Point(727, 58);
            btnFind.Margin = new Padding(4, 5, 4, 5);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(107, 38);
            btnFind.TabIndex = 5;
            btnFind.Text = "&Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;

            // 
            // btnExit
            // 
            btnExit.Location = new Point(579, 563);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 38);
            btnExit.TabIndex = 6;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;

            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(334, 58);
            txtCustomerId.Margin = new Padding(4, 5, 4, 5);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(353, 31);
            txtCustomerId.TabIndex = 7;

            // 
            // txtContact
            // 
            txtContact.Location = new Point(334, 208);
            txtContact.Margin = new Padding(4, 5, 4, 5);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(353, 31);
            txtContact.TabIndex = 9;

            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(334, 302);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(353, 31);
            txtAddress.TabIndex = 10;

            // 
            // txtCity
            // 
            txtCity.Location = new Point(334, 380);
            txtCity.Margin = new Padding(4, 5, 4, 5);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(353, 31);
            txtCity.TabIndex = 11;

            // 
            // btnSave
            // 
            btnSave.Location = new Point(391, 563);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 37);
            btnSave.TabIndex = 12;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 213);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 14;
            label3.Text = "Contact:";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 307);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 15;
            label4.Text = "Ship Address:";

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 385);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 16;
            label5.Text = "Ship City:";

            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 473);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 17;
            label6.Text = "Ship Country:";

            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(334, 465);
            txtCountry.Margin = new Padding(4, 5, 4, 5);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(353, 31);
            txtCountry.TabIndex = 18;

            // 
            // frmCustomerMaintenance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(txtCountry);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtCustomerId);
            Controls.Add(btnExit);
            Controls.Add(btnFind);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCustomerMaintenance";
            Text = "Jonathan Douglas's Customer Maintenance";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFind;
        private Button btnExit;
        private TextBox txtCustomerId;
        private TextBox txtContact;
        private TextBox txtAddress;
        private TextBox txtCity;
        private Button btnSave;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCountry;
    }
}