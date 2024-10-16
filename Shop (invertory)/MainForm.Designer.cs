namespace Shop__invertory_
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magacineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.payment1 = new Shop__invertory_.Payment();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.invertoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Payment";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // invertoryToolStripMenuItem
            // 
            this.invertoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magacineToolStripMenuItem,
            this.addNewItemsToolStripMenuItem,
            this.addNewCategoryToolStripMenuItem1});
            this.invertoryToolStripMenuItem.Name = "invertoryToolStripMenuItem";
            this.invertoryToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.invertoryToolStripMenuItem.Text = "Invertory";
            // 
            // magacineToolStripMenuItem
            // 
            this.magacineToolStripMenuItem.Name = "magacineToolStripMenuItem";
            this.magacineToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.magacineToolStripMenuItem.Text = "Magacine";
            this.magacineToolStripMenuItem.Click += new System.EventHandler(this.magacineToolStripMenuItem_Click);
            // 
            // addNewItemsToolStripMenuItem
            // 
            this.addNewItemsToolStripMenuItem.Name = "addNewItemsToolStripMenuItem";
            this.addNewItemsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addNewItemsToolStripMenuItem.Text = "Add New Items";
            this.addNewItemsToolStripMenuItem.Click += new System.EventHandler(this.addNewItemsToolStripMenuItem_Click);
            // 
            // addNewCategoryToolStripMenuItem1
            // 
            this.addNewCategoryToolStripMenuItem1.Name = "addNewCategoryToolStripMenuItem1";
            this.addNewCategoryToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.addNewCategoryToolStripMenuItem1.Text = "Add New Category";
            this.addNewCategoryToolStripMenuItem1.Click += new System.EventHandler(this.addNewCategoryToolStripMenuItem1_Click);
            // 
            // payment1
            // 
            this.payment1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.payment1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment1.Location = new System.Drawing.Point(0, 27);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(1032, 546);
            this.payment1.TabIndex = 1;
            this.payment1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1032, 573);
            this.Controls.Add(this.payment1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Invertory Menagment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem invertoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magacineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoryToolStripMenuItem1;
        private Payment payment1;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
    }
}