
namespace WindowsFormsApp1
{
    partial class ManufacturerForm
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
            this.lbl_product = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.btn_sendProduct = new System.Windows.Forms.Button();
            this.btn_warehouses = new System.Windows.Forms.Button();
            this.loggerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.erpTIRSANDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpTIRSANDataSet1 = new WindowsFormsApp1.erpTIRSANDataSet1();
            this.loggerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loggerTableAdapter = new WindowsFormsApp1.erpTIRSANDataSet1TableAdapters.loggerTableAdapter();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridViewMsg = new System.Windows.Forms.DataGridView();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.productswarehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_warehousesTableAdapter = new WindowsFormsApp1.erpTIRSANDataSet1TableAdapters.products_warehousesTableAdapter();
            this.warehousesTableAdapter = new WindowsFormsApp1.erpTIRSANDataSet1TableAdapters.warehousesTableAdapter();
            this.grp_box_Send = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_exit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.back_btn = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.man_name = new System.Windows.Forms.ToolStripMenuItem();
            this.manName_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.location_men_itm = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportScreen_btn = new System.Windows.Forms.Button();
            this.filterRequest = new System.Windows.Forms.Button();
            this.warehouse = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_deny = new System.Windows.Forms.Button();
            this.cmb_box_cus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.loggerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTIRSANDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTIRSANDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggerBindingSource)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productswarehousesBindingSource)).BeginInit();
            this.grp_box_Send.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(103, 15);
            this.lbl_product.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(78, 13);
            this.lbl_product.TabIndex = 1;
            this.lbl_product.Text = " Product Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(189, 15);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(76, 20);
            this.txt_name.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_name, "product Name\r\n");
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(189, 58);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(2);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(76, 20);
            this.txt_qty.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_qty, "quantity");
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(103, 61);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(29, 13);
            this.lbl_qty.TabIndex = 3;
            this.lbl_qty.Text = "QTY";
            // 
            // btn_sendProduct
            // 
            this.btn_sendProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sendProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sendProduct.Location = new System.Drawing.Point(254, 145);
            this.btn_sendProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sendProduct.Name = "btn_sendProduct";
            this.btn_sendProduct.Size = new System.Drawing.Size(110, 31);
            this.btn_sendProduct.TabIndex = 3;
            this.btn_sendProduct.Text = "&Send Product";
            this.btn_sendProduct.UseVisualStyleBackColor = true;
            this.btn_sendProduct.Click += new System.EventHandler(this.btn_sendProduct_Click);
            // 
            // btn_warehouses
            // 
            this.btn_warehouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_warehouses.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_warehouses.Location = new System.Drawing.Point(540, 149);
            this.btn_warehouses.Margin = new System.Windows.Forms.Padding(2);
            this.btn_warehouses.Name = "btn_warehouses";
            this.btn_warehouses.Size = new System.Drawing.Size(122, 51);
            this.btn_warehouses.TabIndex = 5;
            this.btn_warehouses.Text = "&Stock Information";
            this.btn_warehouses.UseVisualStyleBackColor = true;
            this.btn_warehouses.Click += new System.EventHandler(this.btn_warehouses_Click);
            // 
            // loggerBindingSource1
            // 
            this.loggerBindingSource1.DataMember = "logger";
            this.loggerBindingSource1.DataSource = this.erpTIRSANDataSet1BindingSource;
            // 
            // erpTIRSANDataSet1BindingSource
            // 
            this.erpTIRSANDataSet1BindingSource.DataSource = this.erpTIRSANDataSet1;
            this.erpTIRSANDataSet1BindingSource.Position = 0;
            // 
            // erpTIRSANDataSet1
            // 
            this.erpTIRSANDataSet1.DataSetName = "erpTIRSANDataSet1";
            this.erpTIRSANDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loggerBindingSource
            // 
            this.loggerBindingSource.DataMember = "logger";
            this.loggerBindingSource.DataSource = this.erpTIRSANDataSet1;
            // 
            // loggerTableAdapter
            // 
            this.loggerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dataGridViewMsg);
            this.groupBox.Location = new System.Drawing.Point(599, 346);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox.Size = new System.Drawing.Size(472, 155);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Requests";
            // 
            // dataGridViewMsg
            // 
            this.dataGridViewMsg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMsg.Location = new System.Drawing.Point(4, 17);
            this.dataGridViewMsg.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMsg.Name = "dataGridViewMsg";
            this.dataGridViewMsg.RowHeadersWidth = 51;
            this.dataGridViewMsg.RowTemplate.Height = 24;
            this.dataGridViewMsg.Size = new System.Drawing.Size(457, 124);
            this.dataGridViewMsg.TabIndex = 0;
            this.dataGridViewMsg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMsg_CellContentClick);
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "warehouses";
            this.warehousesBindingSource.DataSource = this.erpTIRSANDataSet1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewStock);
            this.groupBox1.Location = new System.Drawing.Point(18, 346);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(562, 145);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStock.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewStock.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.RowHeadersWidth = 51;
            this.dataGridViewStock.RowTemplate.Height = 24;
            this.dataGridViewStock.Size = new System.Drawing.Size(558, 128);
            this.dataGridViewStock.TabIndex = 0;
            // 
            // productswarehousesBindingSource
            // 
            this.productswarehousesBindingSource.DataMember = "products_warehouses";
            this.productswarehousesBindingSource.DataSource = this.erpTIRSANDataSet1;
            // 
            // products_warehousesTableAdapter
            // 
            this.products_warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // grp_box_Send
            // 
            this.grp_box_Send.Controls.Add(this.lbl_product);
            this.grp_box_Send.Controls.Add(this.txt_name);
            this.grp_box_Send.Controls.Add(this.lbl_qty);
            this.grp_box_Send.Controls.Add(this.txt_qty);
            this.grp_box_Send.Controls.Add(this.btn_sendProduct);
            this.grp_box_Send.Location = new System.Drawing.Point(39, 107);
            this.grp_box_Send.Margin = new System.Windows.Forms.Padding(2);
            this.grp_box_Send.Name = "grp_box_Send";
            this.grp_box_Send.Padding = new System.Windows.Forms.Padding(2);
            this.grp_box_Send.Size = new System.Drawing.Size(425, 191);
            this.grp_box_Send.TabIndex = 17;
            this.grp_box_Send.TabStop = false;
            this.grp_box_Send.Text = "Send Product";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 25);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_exit.Location = new System.Drawing.Point(540, 213);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(122, 30);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "&EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.back_btn.Location = new System.Drawing.Point(540, 261);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(122, 30);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "&BACK";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.man_name,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // man_name
            // 
            this.man_name.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manName_menu,
            this.location_men_itm});
            this.man_name.Name = "man_name";
            this.man_name.Size = new System.Drawing.Size(115, 20);
            this.man_name.Text = "Manufacturer Info";
            this.man_name.Click += new System.EventHandler(this.man_name_Click);
            // 
            // manName_menu
            // 
            this.manName_menu.Name = "manName_menu";
            this.manName_menu.Size = new System.Drawing.Size(180, 22);
            this.manName_menu.Text = "cus name";
            // 
            // location_men_itm
            // 
            this.location_men_itm.Name = "location_men_itm";
            this.location_men_itm.Size = new System.Drawing.Size(180, 22);
            this.location_men_itm.Text = "details";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // reportScreen_btn
            // 
            this.reportScreen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reportScreen_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.reportScreen_btn.Location = new System.Drawing.Point(540, 83);
            this.reportScreen_btn.Margin = new System.Windows.Forms.Padding(2);
            this.reportScreen_btn.Name = "reportScreen_btn";
            this.reportScreen_btn.Size = new System.Drawing.Size(122, 51);
            this.reportScreen_btn.TabIndex = 7;
            this.reportScreen_btn.Text = "&Reporting Screen";
            this.reportScreen_btn.UseVisualStyleBackColor = true;
            this.reportScreen_btn.Click += new System.EventHandler(this.reportScreen_btn_Click);
            // 
            // filterRequest
            // 
            this.filterRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filterRequest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.filterRequest.Location = new System.Drawing.Point(846, 267);
            this.filterRequest.Margin = new System.Windows.Forms.Padding(2);
            this.filterRequest.Name = "filterRequest";
            this.filterRequest.Size = new System.Drawing.Size(115, 31);
            this.filterRequest.TabIndex = 8;
            this.filterRequest.Text = "&See Request";
            this.filterRequest.UseVisualStyleBackColor = true;
            this.filterRequest.Click += new System.EventHandler(this.filterRequest_Click);
            // 
            // warehouse
            // 
            this.warehouse.AutoSize = true;
            this.warehouse.Location = new System.Drawing.Point(708, 216);
            this.warehouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warehouse.Name = "warehouse";
            this.warehouse.Size = new System.Drawing.Size(85, 13);
            this.warehouse.TabIndex = 4;
            this.warehouse.Text = "Customer Name:";
            // 
            // btn_Ok
            // 
            this.btn_Ok.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Ok.Location = new System.Drawing.Point(760, 509);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(59, 23);
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "&OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_deny
            // 
            this.btn_deny.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_deny.Location = new System.Drawing.Point(846, 509);
            this.btn_deny.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deny.Name = "btn_deny";
            this.btn_deny.Size = new System.Drawing.Size(62, 23);
            this.btn_deny.TabIndex = 8;
            this.btn_deny.Text = "&DENY";
            this.btn_deny.UseVisualStyleBackColor = true;
            this.btn_deny.Click += new System.EventHandler(this.btn_deny_Click);
            // 
            // cmb_box_cus
            // 
            this.cmb_box_cus.FormattingEnabled = true;
            this.cmb_box_cus.Items.AddRange(new object[] {
            "BENTLEY",
            "AXA",
            "porsche",
            "iveco",
            "tata",
            "KARSA",
            "furkan"});
            this.cmb_box_cus.Location = new System.Drawing.Point(846, 216);
            this.cmb_box_cus.Name = "cmb_box_cus";
            this.cmb_box_cus.Size = new System.Drawing.Size(121, 21);
            this.cmb_box_cus.TabIndex = 21;
            // 
            // ManufacturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 543);
            this.Controls.Add(this.cmb_box_cus);
            this.Controls.Add(this.btn_deny);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.warehouse);
            this.Controls.Add(this.filterRequest);
            this.Controls.Add(this.reportScreen_btn);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grp_box_Send);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btn_warehouses);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManufacturerForm";
            this.Text = "Manufacturer";
            ((System.ComponentModel.ISupportInitialize)(this.loggerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTIRSANDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTIRSANDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggerBindingSource)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productswarehousesBindingSource)).EndInit();
            this.grp_box_Send.ResumeLayout(false);
            this.grp_box_Send.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Button btn_sendProduct;
        private System.Windows.Forms.Button btn_warehouses;
        private erpTIRSANDataSet1 erpTIRSANDataSet1;
        private System.Windows.Forms.BindingSource loggerBindingSource;
        private erpTIRSANDataSet1TableAdapters.loggerTableAdapter loggerTableAdapter;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource productswarehousesBindingSource;
        private erpTIRSANDataSet1TableAdapters.products_warehousesTableAdapter products_warehousesTableAdapter;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private erpTIRSANDataSet1TableAdapters.warehousesTableAdapter warehousesTableAdapter;
        private System.Windows.Forms.GroupBox grp_box_Send;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.BindingSource loggerBindingSource1;
        private System.Windows.Forms.BindingSource erpTIRSANDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem man_name;
        private System.Windows.Forms.ToolStripMenuItem manName_menu;
        private System.Windows.Forms.ToolStripMenuItem location_men_itm;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button reportScreen_btn;
        private System.Windows.Forms.DataGridView dataGridViewMsg;
        private System.Windows.Forms.Button filterRequest;
        private System.Windows.Forms.Label warehouse;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_deny;
        private System.Windows.Forms.ComboBox cmb_box_cus;
    }
}