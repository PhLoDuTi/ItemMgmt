
namespace ItemMgmt
{
    partial class LoginWin
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
            this.printShip = new System.Windows.Forms.Button();
            this.printOrder = new System.Windows.Forms.Button();
            this.printMonthly = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printShip
            // 
            this.printShip.Location = new System.Drawing.Point(12, 80);
            this.printShip.Name = "printShip";
            this.printShip.Size = new System.Drawing.Size(133, 23);
            this.printShip.TabIndex = 1;
            this.printShip.Text = "View new shipments";
            this.printShip.UseVisualStyleBackColor = true;
            this.printShip.Click += new System.EventHandler(this.printShip_Click);
            // 
            // printOrder
            // 
            this.printOrder.Location = new System.Drawing.Point(12, 109);
            this.printOrder.Name = "printOrder";
            this.printOrder.Size = new System.Drawing.Size(133, 23);
            this.printOrder.TabIndex = 2;
            this.printOrder.Text = "View orders";
            this.printOrder.UseVisualStyleBackColor = true;
            this.printOrder.Click += new System.EventHandler(this.printOrder_Click);
            // 
            // printMonthly
            // 
            this.printMonthly.Location = new System.Drawing.Point(12, 138);
            this.printMonthly.Name = "printMonthly";
            this.printMonthly.Size = new System.Drawing.Size(133, 23);
            this.printMonthly.TabIndex = 3;
            this.printMonthly.Text = "Print out monthly report";
            this.printMonthly.UseVisualStyleBackColor = true;
            this.printMonthly.Click += new System.EventHandler(this.printMonthly_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeyDisplayString = "ALT+F4";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.ToolTipText = "Quit the program";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LoginWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 225);
            this.Controls.Add(this.printMonthly);
            this.Controls.Add(this.printOrder);
            this.Controls.Add(this.printShip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginWin";
            this.Text = "Goods Received";
            this.Load += new System.EventHandler(this.LoginWin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button printShip;
        private System.Windows.Forms.Button printOrder;
        private System.Windows.Forms.Button printMonthly;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

