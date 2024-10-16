namespace Shop__invertory_
{
    partial class AddItems
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopInvertoryDBDataSet1 = new Shop__invertory_.shopInvertoryDBDataSet1();
            this.shopInvertoryDBDataSet = new Shop__invertory_.shopInvertoryDBDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Shop__invertory_.shopInvertoryDBDataSetTableAdapters.productsTableAdapter();
            this.productsTableAdapter1 = new Shop__invertory_.shopInvertoryDBDataSet1TableAdapters.productsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInvertoryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInvertoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Item";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(60, 83);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(52, 21);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(64, 107);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(160, 29);
            this.nameInput.TabIndex = 2;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(60, 159);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(70, 21);
            this.quantityLbl.TabIndex = 3;
            this.quantityLbl.Text = "Quantity";
            // 
            // quantityInput
            // 
            this.quantityInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityInput.Location = new System.Drawing.Point(64, 183);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(160, 29);
            this.quantityInput.TabIndex = 4;
            this.quantityInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityInput_KeyPress);
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(60, 306);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(73, 21);
            this.categoryLbl.TabIndex = 7;
            this.categoryLbl.Text = "Category";
            // 
            // priceInput
            // 
            this.priceInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInput.Location = new System.Drawing.Point(64, 254);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(160, 29);
            this.priceInput.TabIndex = 6;
            this.priceInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceInput_KeyPress);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(60, 230);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(44, 21);
            this.priceLbl.TabIndex = 5;
            this.priceLbl.Text = "Price";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(64, 388);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(160, 35);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(64, 330);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(160, 29);
            this.categoryComboBox.TabIndex = 10;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "products";
            this.productsBindingSource1.DataSource = this.shopInvertoryDBDataSet1;
            // 
            // shopInvertoryDBDataSet1
            // 
            this.shopInvertoryDBDataSet1.DataSetName = "shopInvertoryDBDataSet1";
            this.shopInvertoryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopInvertoryDBDataSet
            // 
            this.shopInvertoryDBDataSet.DataSetName = "shopInvertoryDBDataSet";
            this.shopInvertoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.shopInvertoryDBDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 455);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddItems";
            this.Load += new System.EventHandler(this.AddItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInvertoryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopInvertoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private shopInvertoryDBDataSet shopInvertoryDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private shopInvertoryDBDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private shopInvertoryDBDataSet1 shopInvertoryDBDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private shopInvertoryDBDataSet1TableAdapters.productsTableAdapter productsTableAdapter1;
    }
}