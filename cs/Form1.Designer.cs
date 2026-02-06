namespace cs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;

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
            lblName = new Label();
            txtName = new TextBox();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            btnAdd = new Button();
            btnShowAll = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            lstProducts = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nome:";
            // 
            // txtName
            // 
            txtName.Location = new Point(70, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 50);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Prezzo:";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(70, 48);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(300, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Aggiungi";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(300, 46);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(100, 30);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Mostra Tutti";
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 95);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(108, 15);
            lblSearch.TabIndex = 6;
            lblSearch.Text = "Cerca Nome (U/D):";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(120, 92);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 23);
            txtSearch.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(300, 90);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Modifica";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(420, 90);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Cancella";
            btnDelete.Click += btnDelete_Click;
            // 
            // lstProducts
            // 
            lstProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstProducts.ItemHeight = 15;
            lstProducts.Location = new Point(12, 140);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(760, 274);
            lstProducts.TabIndex = 10;
            lstProducts.DoubleClick += lstProducts_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(btnAdd);
            Controls.Add(btnShowAll);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(lstProducts);
            Name = "Form1";
            Text = "Gestione Prodotti";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
