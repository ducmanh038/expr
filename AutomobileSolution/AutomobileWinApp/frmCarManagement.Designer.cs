namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleasedYear = new Label();
            txtCarID = new TextBox();
            txtManufacturer = new TextBox();
            txtReleasedYear = new TextBox();
            txtPrice = new TextBox();
            txtCarName = new TextBox();
            dgvCarList = new DataGridView();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(48, 30);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(48, 69);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(48, 110);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(395, 30);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleasedYear
            // 
            lbReleasedYear.AutoSize = true;
            lbReleasedYear.Location = new Point(395, 72);
            lbReleasedYear.Name = "lbReleasedYear";
            lbReleasedYear.Size = new Size(78, 15);
            lbReleasedYear.TabIndex = 4;
            lbReleasedYear.Text = "Released Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(138, 30);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(222, 23);
            txtCarID.TabIndex = 5;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(138, 110);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(222, 23);
            txtManufacturer.TabIndex = 6;
            // 
            // txtReleasedYear
            // 
            txtReleasedYear.Location = new Point(490, 72);
            txtReleasedYear.Name = "txtReleasedYear";
            txtReleasedYear.Size = new Size(222, 23);
            txtReleasedYear.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(490, 27);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(222, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(138, 69);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(222, 23);
            txtCarName.TabIndex = 9;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(19, 218);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(779, 189);
            dgvCarList.TabIndex = 10;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(170, 177);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(363, 177);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(550, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(363, 413);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvCarList);
            Controls.Add(txtCarName);
            Controls.Add(txtPrice);
            Controls.Add(txtReleasedYear);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarID);
            Controls.Add(lbReleasedYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleasedYear;
        private TextBox txtCarID;
        private TextBox txtManufacturer;
        private TextBox txtReleasedYear;
        private TextBox txtPrice;
        private TextBox txtCarName;
        private DataGridView dgvCarList;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
    }
}