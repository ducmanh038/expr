namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacture = new Label();
            lbPrice = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            lbReleaseYear = new Label();
            cboManufacturer = new ComboBox();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(22, 40);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(22, 77);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 0;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacture
            // 
            lbManufacture.AutoSize = true;
            lbManufacture.Location = new Point(22, 120);
            lbManufacture.Name = "lbManufacture";
            lbManufacture.Size = new Size(75, 15);
            lbManufacture.TabIndex = 1;
            lbManufacture.Text = "Manufacture";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(22, 163);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "Price";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(114, 37);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(219, 23);
            txtCarID.TabIndex = 3;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(114, 77);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(219, 23);
            txtCarName.TabIndex = 4;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(22, 205);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(78, 15);
            lbReleaseYear.TabIndex = 5;
            lbReleaseYear.Text = "Released Year";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Huyndai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(114, 120);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(219, 23);
            cboManufacturer.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(114, 163);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(220, 23);
            txtPrice.TabIndex = 7;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(114, 205);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(220, 23);
            txtReleaseYear.TabIndex = 8;
            txtReleaseYear.Text = "0";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(114, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(258, 242);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 284);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(cboManufacturer);
            Controls.Add(lbReleaseYear);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacture);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacture;
        private Label lbPrice;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private Label lbReleaseYear;
        private ComboBox cboManufacturer;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private Button btnSave;
        private Button btnCancel;
    }
}
