namespace Shop__invertory_
{
    partial class Payment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.itemIDInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.itemsLeftInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.totalPayment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.revenueBtn = new System.Windows.Forms.Button();
            this.DeleteCartBtn = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemInput
            // 
            this.itemInput.BackColor = System.Drawing.Color.Yellow;
            this.itemInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInput.Location = new System.Drawing.Point(118, 103);
            this.itemInput.Name = "itemInput";
            this.itemInput.Size = new System.Drawing.Size(159, 25);
            this.itemInput.TabIndex = 3;
            this.itemInput.TextChanged += new System.EventHandler(this.itemInput_TextChanged);
            this.itemInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity:";
            // 
            // quantityInput
            // 
            this.quantityInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityInput.Location = new System.Drawing.Point(118, 139);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(159, 25);
            this.quantityInput.TabIndex = 5;
            this.quantityInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantityInput_KeyDown);
            this.quantityInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityInput_KeyPress);
            // 
            // itemIDInput
            // 
            this.itemIDInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.itemIDInput.Enabled = false;
            this.itemIDInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIDInput.Location = new System.Drawing.Point(442, 100);
            this.itemIDInput.Name = "itemIDInput";
            this.itemIDInput.ReadOnly = true;
            this.itemIDInput.Size = new System.Drawing.Size(97, 25);
            this.itemIDInput.TabIndex = 7;
            this.itemIDInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceInput
            // 
            this.priceInput.Enabled = false;
            this.priceInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInput.ForeColor = System.Drawing.Color.Blue;
            this.priceInput.Location = new System.Drawing.Point(442, 139);
            this.priceInput.Name = "priceInput";
            this.priceInput.ReadOnly = true;
            this.priceInput.Size = new System.Drawing.Size(97, 25);
            this.priceInput.TabIndex = 8;
            this.priceInput.Text = "0.00";
            this.priceInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(638, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Items Left:";
            // 
            // nameInput
            // 
            this.nameInput.Enabled = false;
            this.nameInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(690, 100);
            this.nameInput.Name = "nameInput";
            this.nameInput.ReadOnly = true;
            this.nameInput.Size = new System.Drawing.Size(304, 25);
            this.nameInput.TabIndex = 13;
            // 
            // itemsLeftInput
            // 
            this.itemsLeftInput.Enabled = false;
            this.itemsLeftInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsLeftInput.Location = new System.Drawing.Point(690, 139);
            this.itemsLeftInput.Name = "itemsLeftInput";
            this.itemsLeftInput.ReadOnly = true;
            this.itemsLeftInput.Size = new System.Drawing.Size(76, 25);
            this.itemsLeftInput.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(251, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(543, 209);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // searchGridView
            // 
            this.searchGridView.AllowUserToAddRows = false;
            this.searchGridView.AllowUserToDeleteRows = false;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.searchGridView.GridColor = System.Drawing.Color.YellowGreen;
            this.searchGridView.Location = new System.Drawing.Point(117, 170);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.ReadOnly = true;
            this.searchGridView.RowHeadersVisible = false;
            this.searchGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.searchGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchGridView.Size = new System.Drawing.Size(504, 389);
            this.searchGridView.TabIndex = 17;
            this.searchGridView.Visible = false;
            this.searchGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchGridView_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalPayment
            // 
            this.totalPayment.AutoSize = true;
            this.totalPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayment.ForeColor = System.Drawing.Color.Blue;
            this.totalPayment.Location = new System.Drawing.Point(808, 453);
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalPayment.Size = new System.Drawing.Size(121, 65);
            this.totalPayment.TabIndex = 19;
            this.totalPayment.Text = "0.00";
            this.totalPayment.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Delete Cart";
            // 
            // revenueBtn
            // 
            this.revenueBtn.BackgroundImage = global::Shop__invertory_.Properties.Resources.arrow;
            this.revenueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.revenueBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.revenueBtn.Location = new System.Drawing.Point(584, 3);
            this.revenueBtn.Name = "revenueBtn";
            this.revenueBtn.Size = new System.Drawing.Size(77, 62);
            this.revenueBtn.TabIndex = 24;
            this.revenueBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.revenueBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.revenueBtn.UseVisualStyleBackColor = true;
            this.revenueBtn.Click += new System.EventHandler(this.revenueBtn_Click);
            // 
            // DeleteCartBtn
            // 
            this.DeleteCartBtn.BackgroundImage = global::Shop__invertory_.Properties.Resources.garbageCan;
            this.DeleteCartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteCartBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteCartBtn.Location = new System.Drawing.Point(487, 3);
            this.DeleteCartBtn.Name = "DeleteCartBtn";
            this.DeleteCartBtn.Size = new System.Drawing.Size(77, 62);
            this.DeleteCartBtn.TabIndex = 21;
            this.DeleteCartBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteCartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteCartBtn.UseVisualStyleBackColor = true;
            this.DeleteCartBtn.Click += new System.EventHandler(this.DeleteCartBtn_Click);
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.BackgroundImage = global::Shop__invertory_.Properties.Resources.dollar;
            this.PaymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PaymentBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PaymentBtn.Location = new System.Drawing.Point(392, 3);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(77, 62);
            this.PaymentBtn.TabIndex = 20;
            this.PaymentBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PaymentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Revenue";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.revenueBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeleteCartBtn);
            this.Controls.Add(this.PaymentBtn);
            this.Controls.Add(this.totalPayment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.itemsLeftInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.itemIDInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemInput);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1032, 546);
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.TextBox itemIDInput;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox itemsLeftInput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totalPayment;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button DeleteCartBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button revenueBtn;
        private System.Windows.Forms.Label label7;
    }
}
