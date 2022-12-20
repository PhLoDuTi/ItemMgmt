
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
            this.components = new System.ComponentModel.Container();
            this.printShip = new System.Windows.Forms.Button();
            this.printOrder = new System.Windows.Forms.Button();
            this.printMonthly = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.shipTab = new System.Windows.Forms.TabPage();
            this.importDGV = new System.Windows.Forms.DataGridView();
            this.goodsMgntDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsMgntDataSet = new ItemMgmt.GoodsMgntDataSet();
            this.orderTab = new System.Windows.Forms.TabPage();
            this.ordersDGV = new System.Windows.Forms.DataGridView();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.monthDGV = new System.Windows.Forms.DataGridView();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.dateEndPick = new System.Windows.Forms.DateTimePicker();
            this.dateStartPick = new System.Windows.Forms.DateTimePicker();
            this.queryApplyImport = new System.Windows.Forms.Button();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsMgntDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryApplyOrders = new System.Windows.Forms.Button();
            this.applyQueryMonthly = new System.Windows.Forms.Button();
            this.orderSelect = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.shipTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsMgntDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsMgntDataSet)).BeginInit();
            this.orderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).BeginInit();
            this.reportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsMgntDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // printShip
            // 
            this.printShip.Location = new System.Drawing.Point(661, 429);
            this.printShip.Name = "printShip";
            this.printShip.Size = new System.Drawing.Size(68, 23);
            this.printShip.TabIndex = 1;
            this.printShip.Text = "Print";
            this.printShip.UseVisualStyleBackColor = true;
            this.printShip.Click += new System.EventHandler(this.printShip_Click);
            // 
            // printOrder
            // 
            this.printOrder.Location = new System.Drawing.Point(665, 433);
            this.printOrder.Name = "printOrder";
            this.printOrder.Size = new System.Drawing.Size(69, 23);
            this.printOrder.TabIndex = 2;
            this.printOrder.Text = "Print";
            this.printOrder.UseVisualStyleBackColor = true;
            this.printOrder.Click += new System.EventHandler(this.printOrder_Click);
            // 
            // printMonthly
            // 
            this.printMonthly.Location = new System.Drawing.Point(629, 429);
            this.printMonthly.Name = "printMonthly";
            this.printMonthly.Size = new System.Drawing.Size(100, 23);
            this.printMonthly.TabIndex = 3;
            this.printMonthly.Text = "Print";
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
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
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
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.shipTab);
            this.tabMenu.Controls.Add(this.orderTab);
            this.tabMenu.Controls.Add(this.reportTab);
            this.tabMenu.Location = new System.Drawing.Point(0, 27);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(745, 488);
            this.tabMenu.TabIndex = 5;
            // 
            // shipTab
            // 
            this.shipTab.Controls.Add(this.queryApplyImport);
            this.shipTab.Controls.Add(this.importDGV);
            this.shipTab.Controls.Add(this.printShip);
            this.shipTab.Location = new System.Drawing.Point(4, 22);
            this.shipTab.Name = "shipTab";
            this.shipTab.Padding = new System.Windows.Forms.Padding(3);
            this.shipTab.Size = new System.Drawing.Size(737, 462);
            this.shipTab.TabIndex = 0;
            this.shipTab.Text = "Imports";
            this.shipTab.UseVisualStyleBackColor = true;
            // 
            // importDGV
            // 
            this.importDGV.AutoGenerateColumns = false;
            this.importDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.importDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.importDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.itemAmountDataGridViewTextBoxColumn,
            this.shipmentDateDataGridViewTextBoxColumn});
            this.importDGV.DataMember = "OrderImport";
            this.importDGV.DataSource = this.goodsMgntDataSetBindingSource1;
            this.importDGV.Location = new System.Drawing.Point(7, 7);
            this.importDGV.Name = "importDGV";
            this.importDGV.Size = new System.Drawing.Size(722, 416);
            this.importDGV.TabIndex = 2;
            // 
            // goodsMgntDataSetBindingSource
            // 
            this.goodsMgntDataSetBindingSource.DataSource = this.goodsMgntDataSet;
            this.goodsMgntDataSetBindingSource.Position = 0;
            // 
            // goodsMgntDataSet
            // 
            this.goodsMgntDataSet.DataSetName = "GoodsMgntDataSet";
            this.goodsMgntDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTab
            // 
            this.orderTab.Controls.Add(this.orderSelect);
            this.orderTab.Controls.Add(this.queryApplyOrders);
            this.orderTab.Controls.Add(this.ordersDGV);
            this.orderTab.Controls.Add(this.printOrder);
            this.orderTab.Location = new System.Drawing.Point(4, 22);
            this.orderTab.Name = "orderTab";
            this.orderTab.Padding = new System.Windows.Forms.Padding(3);
            this.orderTab.Size = new System.Drawing.Size(737, 462);
            this.orderTab.TabIndex = 1;
            this.orderTab.Text = "Orders";
            this.orderTab.UseVisualStyleBackColor = true;
            this.orderTab.Click += new System.EventHandler(this.orderTab_Click);
            // 
            // ordersDGV
            // 
            this.ordersDGV.AutoGenerateColumns = false;
            this.ordersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.agentIDDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.orderItemDataGridViewTextBoxColumn,
            this.orderItemAmountDataGridViewTextBoxColumn,
            this.orderPriceDataGridViewTextBoxColumn});
            this.ordersDGV.DataMember = "OrderSell";
            this.ordersDGV.DataSource = this.goodsMgntDataSetBindingSource;
            this.ordersDGV.Location = new System.Drawing.Point(9, 7);
            this.ordersDGV.Name = "ordersDGV";
            this.ordersDGV.Size = new System.Drawing.Size(720, 420);
            this.ordersDGV.TabIndex = 3;
            // 
            // reportTab
            // 
            this.reportTab.Controls.Add(this.applyQueryMonthly);
            this.reportTab.Controls.Add(this.monthDGV);
            this.reportTab.Controls.Add(this.labelEnd);
            this.reportTab.Controls.Add(this.labelStart);
            this.reportTab.Controls.Add(this.dateEndPick);
            this.reportTab.Controls.Add(this.dateStartPick);
            this.reportTab.Controls.Add(this.printMonthly);
            this.reportTab.Location = new System.Drawing.Point(4, 22);
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Windows.Forms.Padding(3);
            this.reportTab.Size = new System.Drawing.Size(737, 462);
            this.reportTab.TabIndex = 2;
            this.reportTab.Text = "Montly Reports";
            this.reportTab.UseVisualStyleBackColor = true;
            // 
            // monthDGV
            // 
            this.monthDGV.AutoGenerateColumns = false;
            this.monthDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.monthDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.orderDateDataGridViewTextBoxColumn1,
            this.agentIDDataGridViewTextBoxColumn1,
            this.paymentMethodDataGridViewTextBoxColumn1,
            this.orderItemDataGridViewTextBoxColumn1,
            this.orderItemAmountDataGridViewTextBoxColumn1,
            this.orderPriceDataGridViewTextBoxColumn1});
            this.monthDGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.monthDGV.DataMember = "OrderSell";
            this.monthDGV.DataSource = this.goodsMgntDataSetBindingSource;
            this.monthDGV.Location = new System.Drawing.Point(11, 7);
            this.monthDGV.Name = "monthDGV";
            this.monthDGV.Size = new System.Drawing.Size(718, 416);
            this.monthDGV.TabIndex = 8;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(149, 434);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(26, 13);
            this.labelEnd.TabIndex = 7;
            this.labelEnd.Text = "End";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(8, 434);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(29, 13);
            this.labelStart.TabIndex = 6;
            this.labelStart.Text = "Start";
            // 
            // dateEndPick
            // 
            this.dateEndPick.CustomFormat = "MM/yyyy";
            this.dateEndPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEndPick.Location = new System.Drawing.Point(181, 432);
            this.dateEndPick.Name = "dateEndPick";
            this.dateEndPick.Size = new System.Drawing.Size(96, 20);
            this.dateEndPick.TabIndex = 5;
            // 
            // dateStartPick
            // 
            this.dateStartPick.CustomFormat = "MM/yyyy";
            this.dateStartPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartPick.Location = new System.Drawing.Point(43, 432);
            this.dateStartPick.Name = "dateStartPick";
            this.dateStartPick.Size = new System.Drawing.Size(96, 20);
            this.dateStartPick.TabIndex = 4;
            // 
            // queryApplyImport
            // 
            this.queryApplyImport.Location = new System.Drawing.Point(8, 429);
            this.queryApplyImport.Name = "queryApplyImport";
            this.queryApplyImport.Size = new System.Drawing.Size(91, 23);
            this.queryApplyImport.TabIndex = 3;
            this.queryApplyImport.Text = "Submit Query";
            this.queryApplyImport.UseVisualStyleBackColor = true;
            this.queryApplyImport.Click += new System.EventHandler(this.queryApplyImport_Click);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "itemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "itemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "itemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "itemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "itemPrice";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            // 
            // itemAmountDataGridViewTextBoxColumn
            // 
            this.itemAmountDataGridViewTextBoxColumn.DataPropertyName = "itemAmount";
            this.itemAmountDataGridViewTextBoxColumn.HeaderText = "itemAmount";
            this.itemAmountDataGridViewTextBoxColumn.Name = "itemAmountDataGridViewTextBoxColumn";
            // 
            // shipmentDateDataGridViewTextBoxColumn
            // 
            this.shipmentDateDataGridViewTextBoxColumn.DataPropertyName = "shipmentDate";
            this.shipmentDateDataGridViewTextBoxColumn.HeaderText = "shipmentDate";
            this.shipmentDateDataGridViewTextBoxColumn.Name = "shipmentDateDataGridViewTextBoxColumn";
            // 
            // goodsMgntDataSetBindingSource1
            // 
            this.goodsMgntDataSetBindingSource1.DataSource = this.goodsMgntDataSet;
            this.goodsMgntDataSetBindingSource1.Position = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // agentIDDataGridViewTextBoxColumn
            // 
            this.agentIDDataGridViewTextBoxColumn.DataPropertyName = "agentID";
            this.agentIDDataGridViewTextBoxColumn.HeaderText = "agentID";
            this.agentIDDataGridViewTextBoxColumn.Name = "agentIDDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "paymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "paymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            // 
            // orderItemDataGridViewTextBoxColumn
            // 
            this.orderItemDataGridViewTextBoxColumn.DataPropertyName = "orderItem";
            this.orderItemDataGridViewTextBoxColumn.HeaderText = "orderItem";
            this.orderItemDataGridViewTextBoxColumn.Name = "orderItemDataGridViewTextBoxColumn";
            // 
            // orderItemAmountDataGridViewTextBoxColumn
            // 
            this.orderItemAmountDataGridViewTextBoxColumn.DataPropertyName = "orderItemAmount";
            this.orderItemAmountDataGridViewTextBoxColumn.HeaderText = "orderItemAmount";
            this.orderItemAmountDataGridViewTextBoxColumn.Name = "orderItemAmountDataGridViewTextBoxColumn";
            // 
            // orderPriceDataGridViewTextBoxColumn
            // 
            this.orderPriceDataGridViewTextBoxColumn.DataPropertyName = "orderPrice";
            this.orderPriceDataGridViewTextBoxColumn.HeaderText = "orderPrice";
            this.orderPriceDataGridViewTextBoxColumn.Name = "orderPriceDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            // 
            // orderDateDataGridViewTextBoxColumn1
            // 
            this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "orderDate";
            this.orderDateDataGridViewTextBoxColumn1.HeaderText = "orderDate";
            this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
            // 
            // agentIDDataGridViewTextBoxColumn1
            // 
            this.agentIDDataGridViewTextBoxColumn1.DataPropertyName = "agentID";
            this.agentIDDataGridViewTextBoxColumn1.HeaderText = "agentID";
            this.agentIDDataGridViewTextBoxColumn1.Name = "agentIDDataGridViewTextBoxColumn1";
            // 
            // paymentMethodDataGridViewTextBoxColumn1
            // 
            this.paymentMethodDataGridViewTextBoxColumn1.DataPropertyName = "paymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn1.HeaderText = "paymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn1.Name = "paymentMethodDataGridViewTextBoxColumn1";
            // 
            // orderItemDataGridViewTextBoxColumn1
            // 
            this.orderItemDataGridViewTextBoxColumn1.DataPropertyName = "orderItem";
            this.orderItemDataGridViewTextBoxColumn1.HeaderText = "orderItem";
            this.orderItemDataGridViewTextBoxColumn1.Name = "orderItemDataGridViewTextBoxColumn1";
            // 
            // orderItemAmountDataGridViewTextBoxColumn1
            // 
            this.orderItemAmountDataGridViewTextBoxColumn1.DataPropertyName = "orderItemAmount";
            this.orderItemAmountDataGridViewTextBoxColumn1.HeaderText = "orderItemAmount";
            this.orderItemAmountDataGridViewTextBoxColumn1.Name = "orderItemAmountDataGridViewTextBoxColumn1";
            // 
            // orderPriceDataGridViewTextBoxColumn1
            // 
            this.orderPriceDataGridViewTextBoxColumn1.DataPropertyName = "orderPrice";
            this.orderPriceDataGridViewTextBoxColumn1.HeaderText = "orderPrice";
            this.orderPriceDataGridViewTextBoxColumn1.Name = "orderPriceDataGridViewTextBoxColumn1";
            // 
            // queryApplyOrders
            // 
            this.queryApplyOrders.Location = new System.Drawing.Point(516, 433);
            this.queryApplyOrders.Name = "queryApplyOrders";
            this.queryApplyOrders.Size = new System.Drawing.Size(91, 23);
            this.queryApplyOrders.TabIndex = 4;
            this.queryApplyOrders.Text = "Submit Query";
            this.queryApplyOrders.UseVisualStyleBackColor = true;
            this.queryApplyOrders.Click += new System.EventHandler(this.queryApplyOrders_Click);
            // 
            // applyQueryMonthly
            // 
            this.applyQueryMonthly.Location = new System.Drawing.Point(283, 432);
            this.applyQueryMonthly.Name = "applyQueryMonthly";
            this.applyQueryMonthly.Size = new System.Drawing.Size(91, 23);
            this.applyQueryMonthly.TabIndex = 9;
            this.applyQueryMonthly.Text = "Submit Query";
            this.applyQueryMonthly.UseVisualStyleBackColor = true;
            this.applyQueryMonthly.Click += new System.EventHandler(this.applyQueryMonthly_Click);
            // 
            // orderSelect
            // 
            this.orderSelect.FormattingEnabled = true;
            this.orderSelect.Location = new System.Drawing.Point(9, 435);
            this.orderSelect.Name = "orderSelect";
            this.orderSelect.Size = new System.Drawing.Size(121, 21);
            this.orderSelect.TabIndex = 5;
            this.orderSelect.Text = "Filter By Order ID";
            // 
            // LoginWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 513);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginWin";
            this.Text = "BFE General Goods Item Management Suite";
            this.Load += new System.EventHandler(this.LoginWin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.shipTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.importDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsMgntDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsMgntDataSet)).EndInit();
            this.orderTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).EndInit();
            this.reportTab.ResumeLayout(false);
            this.reportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsMgntDataSetBindingSource1)).EndInit();
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
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage shipTab;
        private System.Windows.Forms.TabPage orderTab;
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DateTimePicker dateEndPick;
        private System.Windows.Forms.DateTimePicker dateStartPick;
        private System.Windows.Forms.DataGridView monthDGV;
        private System.Windows.Forms.BindingSource goodsMgntDataSetBindingSource;
        private GoodsMgntDataSet goodsMgntDataSet;
        private System.Windows.Forms.DataGridView ordersDGV;
        private System.Windows.Forms.DataGridView importDGV;
        private System.Windows.Forms.Button queryApplyImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsMgntDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button queryApplyOrders;
        private System.Windows.Forms.Button applyQueryMonthly;
        private System.Windows.Forms.ComboBox orderSelect;
    }
}

