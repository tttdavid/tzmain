namespace tzclean
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.editName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editPhone = new System.Windows.Forms.TextBox();
            this.edit2Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editAddress = new System.Windows.Forms.TextBox();
            this.editAddButton = new System.Windows.Forms.Button();
            this.editCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editName
            // 
            this.editName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editName.Location = new System.Drawing.Point(25, 47);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(129, 31);
            this.editName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "სახელი";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "გვარი";
            // 
            // editPhone
            // 
            this.editPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPhone.Location = new System.Drawing.Point(25, 129);
            this.editPhone.Name = "editPhone";
            this.editPhone.Size = new System.Drawing.Size(281, 31);
            this.editPhone.TabIndex = 5;
            // 
            // edit2Name
            // 
            this.edit2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit2Name.Location = new System.Drawing.Point(177, 47);
            this.edit2Name.Name = "edit2Name";
            this.edit2Name.Size = new System.Drawing.Size(129, 31);
            this.edit2Name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "ტელეფონის ნომერი";
            // 
            // editDate
            // 
            this.editDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.editDate.Location = new System.Drawing.Point(25, 210);
            this.editDate.Name = "editDate";
            this.editDate.Size = new System.Drawing.Size(129, 26);
            this.editDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "დაბ. თარიღი";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "სქესი";
            // 
            // editGender
            // 
            this.editGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGender.FormattingEnabled = true;
            this.editGender.Items.AddRange(new object[] {
            "მამრობითი",
            "მდედრობითი"});
            this.editGender.Location = new System.Drawing.Point(177, 208);
            this.editGender.Name = "editGender";
            this.editGender.Size = new System.Drawing.Size(129, 28);
            this.editGender.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "მისამართი";
            // 
            // editAddress
            // 
            this.editAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAddress.Location = new System.Drawing.Point(25, 284);
            this.editAddress.Multiline = true;
            this.editAddress.Name = "editAddress";
            this.editAddress.Size = new System.Drawing.Size(281, 32);
            this.editAddress.TabIndex = 13;
            // 
            // editAddButton
            // 
            this.editAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAddButton.Image = ((System.Drawing.Image)(resources.GetObject("editAddButton.Image")));
            this.editAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editAddButton.Location = new System.Drawing.Point(25, 345);
            this.editAddButton.Name = "editAddButton";
            this.editAddButton.Size = new System.Drawing.Size(113, 33);
            this.editAddButton.TabIndex = 15;
            this.editAddButton.Text = "დამატება";
            this.editAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editAddButton.UseVisualStyleBackColor = true;
            this.editAddButton.Click += new System.EventHandler(this.editAddButton_Click);
            // 
            // editCancelButton
            // 
            this.editCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCancelButton.Image = ((System.Drawing.Image)(resources.GetObject("editCancelButton.Image")));
            this.editCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editCancelButton.Location = new System.Drawing.Point(196, 345);
            this.editCancelButton.Name = "editCancelButton";
            this.editCancelButton.Size = new System.Drawing.Size(102, 33);
            this.editCancelButton.TabIndex = 16;
            this.editCancelButton.Text = "გაუქმება";
            this.editCancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editCancelButton.UseVisualStyleBackColor = true;
            this.editCancelButton.Click += new System.EventHandler(this.editCancelButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 401);
            this.Controls.Add(this.editCancelButton);
            this.Controls.Add(this.editAddButton);
            this.Controls.Add(this.editAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edit2Name);
            this.Controls.Add(this.editPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.Text = "პაციენტის რედაქტირება";
            this.Load += new System.EventHandler(this.LoadPatient);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editPhone;
        private System.Windows.Forms.TextBox edit2Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker editDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox editGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox editAddress;
        private System.Windows.Forms.Button editAddButton;
        private System.Windows.Forms.Button editCancelButton;
    }
}