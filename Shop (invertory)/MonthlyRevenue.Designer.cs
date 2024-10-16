namespace Shop__invertory_
{
    partial class MonthlyRevenue
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
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toTimePicker = new System.Windows.Forms.DateTimePicker();
            this.monthFromToBtn = new System.Windows.Forms.Button();
            this.mothlyRevenueLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTimePicker.Location = new System.Drawing.Point(96, 41);
            this.fromTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.Size = new System.Drawing.Size(242, 25);
            this.fromTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "FROM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "TO";
            // 
            // toTimePicker
            // 
            this.toTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTimePicker.Location = new System.Drawing.Point(96, 76);
            this.toTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toTimePicker.Name = "toTimePicker";
            this.toTimePicker.Size = new System.Drawing.Size(242, 25);
            this.toTimePicker.TabIndex = 2;
            // 
            // monthFromToBtn
            // 
            this.monthFromToBtn.Location = new System.Drawing.Point(138, 109);
            this.monthFromToBtn.Name = "monthFromToBtn";
            this.monthFromToBtn.Size = new System.Drawing.Size(101, 35);
            this.monthFromToBtn.TabIndex = 4;
            this.monthFromToBtn.Text = "Calculate";
            this.monthFromToBtn.UseVisualStyleBackColor = true;
            this.monthFromToBtn.Click += new System.EventHandler(this.monthFromToBtn_Click);
            // 
            // mothlyRevenueLbl
            // 
            this.mothlyRevenueLbl.AutoSize = true;
            this.mothlyRevenueLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mothlyRevenueLbl.Location = new System.Drawing.Point(146, 172);
            this.mothlyRevenueLbl.Name = "mothlyRevenueLbl";
            this.mothlyRevenueLbl.Size = new System.Drawing.Size(0, 30);
            this.mothlyRevenueLbl.TabIndex = 5;
            // 
            // MonthlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 232);
            this.Controls.Add(this.mothlyRevenueLbl);
            this.Controls.Add(this.monthFromToBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromTimePicker);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MonthlyRevenue";
            this.Text = "Monthly Revenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toTimePicker;
        private System.Windows.Forms.Button monthFromToBtn;
        private System.Windows.Forms.Label mothlyRevenueLbl;
    }
}