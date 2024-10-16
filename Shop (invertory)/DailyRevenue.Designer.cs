namespace Shop__invertory_
{
    partial class DailyRevenue
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
            this.dailyRevenueLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dailyRevenueLbl
            // 
            this.dailyRevenueLbl.AutoSize = true;
            this.dailyRevenueLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyRevenueLbl.Location = new System.Drawing.Point(106, 52);
            this.dailyRevenueLbl.Name = "dailyRevenueLbl";
            this.dailyRevenueLbl.Size = new System.Drawing.Size(0, 30);
            this.dailyRevenueLbl.TabIndex = 0;
            // 
            // DailyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 133);
            this.Controls.Add(this.dailyRevenueLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DailyRevenue";
            this.Text = "Daily Revenue";
            this.Load += new System.EventHandler(this.DailyRevenue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dailyRevenueLbl;
    }
}