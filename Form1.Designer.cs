namespace WindowsFormsApp3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewButton = new System.Windows.Forms.Button();
            this.recordcountLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordcountButton = new System.Windows.Forms.Button();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.checkingconnectionLabel = new System.Windows.Forms.Label();
            this.dialogLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.employeeRadioButton = new System.Windows.Forms.RadioButton();
            this.customersRadioButton = new System.Windows.Forms.RadioButton();
            this.ordersRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(306, 320);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(389, 35);
            this.viewButton.TabIndex = 0;
            this.viewButton.Text = "View Database";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // recordcountLabel
            // 
            this.recordcountLabel.AutoSize = true;
            this.recordcountLabel.Location = new System.Drawing.Point(149, 331);
            this.recordcountLabel.Name = "recordcountLabel";
            this.recordcountLabel.Size = new System.Drawing.Size(0, 13);
            this.recordcountLabel.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(43, 43);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.Location = new System.Drawing.Point(42, 164);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.Size = new System.Drawing.Size(653, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // recordcountButton
            // 
            this.recordcountButton.Location = new System.Drawing.Point(42, 320);
            this.recordcountButton.Name = "recordcountButton";
            this.recordcountButton.Size = new System.Drawing.Size(101, 35);
            this.recordcountButton.TabIndex = 4;
            this.recordcountButton.Text = "Record Count";
            this.recordcountButton.UseVisualStyleBackColor = true;
            this.recordcountButton.Click += new System.EventHandler(this.recordcountButton_Click);
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(43, 97);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyTextBox.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(42, 123);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(101, 35);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // checkingconnectionLabel
            // 
            this.checkingconnectionLabel.AutoSize = true;
            this.checkingconnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkingconnectionLabel.Location = new System.Drawing.Point(571, 148);
            this.checkingconnectionLabel.Name = "checkingconnectionLabel";
            this.checkingconnectionLabel.Size = new System.Drawing.Size(124, 13);
            this.checkingconnectionLabel.TabIndex = 7;
            this.checkingconnectionLabel.Text = "Checking Connecion";
            this.checkingconnectionLabel.Click += new System.EventHandler(this.checkingconnectionLabel_Click);
            // 
            // dialogLabel
            // 
            this.dialogLabel.AutoSize = true;
            this.dialogLabel.Location = new System.Drawing.Point(641, 50);
            this.dialogLabel.Name = "dialogLabel";
            this.dialogLabel.Size = new System.Drawing.Size(0, 13);
            this.dialogLabel.TabIndex = 8;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(40, 81);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(82, 13);
            this.companyLabel.TabIndex = 9;
            this.companyLabel.Text = "Company Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(40, 27);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "ID";
            // 
            // employeeRadioButton
            // 
            this.employeeRadioButton.AutoSize = true;
            this.employeeRadioButton.Location = new System.Drawing.Point(306, 141);
            this.employeeRadioButton.Name = "employeeRadioButton";
            this.employeeRadioButton.Size = new System.Drawing.Size(71, 17);
            this.employeeRadioButton.TabIndex = 11;
            this.employeeRadioButton.TabStop = true;
            this.employeeRadioButton.Text = "Employee";
            this.employeeRadioButton.UseVisualStyleBackColor = true;
            this.employeeRadioButton.CheckedChanged += new System.EventHandler(this.employeeRadioButton_CheckedChanged);
            // 
            // customersRadioButton
            // 
            this.customersRadioButton.AutoSize = true;
            this.customersRadioButton.Location = new System.Drawing.Point(306, 95);
            this.customersRadioButton.Name = "customersRadioButton";
            this.customersRadioButton.Size = new System.Drawing.Size(74, 17);
            this.customersRadioButton.TabIndex = 12;
            this.customersRadioButton.TabStop = true;
            this.customersRadioButton.Text = "Customers";
            this.customersRadioButton.UseVisualStyleBackColor = true;
            // 
            // ordersRadioButton
            // 
            this.ordersRadioButton.AutoSize = true;
            this.ordersRadioButton.Location = new System.Drawing.Point(306, 118);
            this.ordersRadioButton.Name = "ordersRadioButton";
            this.ordersRadioButton.Size = new System.Drawing.Size(56, 17);
            this.ordersRadioButton.TabIndex = 13;
            this.ordersRadioButton.TabStop = true;
            this.ordersRadioButton.Text = "Orders";
            this.ordersRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 367);
            this.Controls.Add(this.ordersRadioButton);
            this.Controls.Add(this.customersRadioButton);
            this.Controls.Add(this.employeeRadioButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.dialogLabel);
            this.Controls.Add(this.checkingconnectionLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.recordcountButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.recordcountLabel);
            this.Controls.Add(this.viewButton);
            this.Name = "Form1";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label recordcountLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button recordcountButton;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label checkingconnectionLabel;
        private System.Windows.Forms.Label dialogLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.RadioButton employeeRadioButton;
        private System.Windows.Forms.RadioButton customersRadioButton;
        private System.Windows.Forms.RadioButton ordersRadioButton;
    }
}

