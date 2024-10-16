namespace Shop__invertory_
{
    partial class PaymentChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.billCostTextBox = new System.Windows.Forms.TextBox();
            this.cashInputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardInputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Cost";
            // 
            // billCostTextBox
            // 
            this.billCostTextBox.Enabled = false;
            this.billCostTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billCostTextBox.ForeColor = System.Drawing.Color.Blue;
            this.billCostTextBox.Location = new System.Drawing.Point(74, 62);
            this.billCostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.billCostTextBox.Name = "billCostTextBox";
            this.billCostTextBox.ReadOnly = true;
            this.billCostTextBox.Size = new System.Drawing.Size(213, 33);
            this.billCostTextBox.TabIndex = 0;
            this.billCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cashInputTextBox
            // 
            this.cashInputTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashInputTextBox.ForeColor = System.Drawing.Color.Blue;
            this.cashInputTextBox.Location = new System.Drawing.Point(74, 140);
            this.cashInputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cashInputTextBox.Name = "cashInputTextBox";
            this.cashInputTextBox.Size = new System.Drawing.Size(213, 33);
            this.cashInputTextBox.TabIndex = 2;
            this.cashInputTextBox.Text = "0.00";
            this.cashInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cashInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashInputTextBox_KeyDown);
            this.cashInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cashInputTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cash Input";
            // 
            // changeTextBox
            // 
            this.changeTextBox.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTextBox.ForeColor = System.Drawing.Color.Blue;
            this.changeTextBox.Location = new System.Drawing.Point(74, 298);
            this.changeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.ReadOnly = true;
            this.changeTextBox.Size = new System.Drawing.Size(213, 54);
            this.changeTextBox.TabIndex = 6;
            this.changeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.changeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changeTextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Change";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Card Input";
            // 
            // cardInputTextBox
            // 
            this.cardInputTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardInputTextBox.ForeColor = System.Drawing.Color.Blue;
            this.cardInputTextBox.Location = new System.Drawing.Point(74, 220);
            this.cardInputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cardInputTextBox.Name = "cardInputTextBox";
            this.cardInputTextBox.Size = new System.Drawing.Size(213, 33);
            this.cardInputTextBox.TabIndex = 3;
            this.cardInputTextBox.Text = "0.00";
            this.cardInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cardInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardInputTextBox_KeyDown);
            this.cardInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardInputTextBox_KeyPress);
            // 
            // PaymentChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardInputTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.changeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cashInputTextBox);
            this.Controls.Add(this.billCostTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaymentChange";
            this.Text = "Payment Change";
            this.Load += new System.EventHandler(this.PaymentChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox billCostTextBox;
        private System.Windows.Forms.TextBox cashInputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox changeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cardInputTextBox;
    }
}