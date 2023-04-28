
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(137, 18);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(102, 17);
            this.lbl_product.TabIndex = 1;
            this.lbl_product.Text = " Product Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(252, 18);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_name, "product Name\r\n");
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(252, 72);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 22);
            this.txt_qty.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_qty, "quantity");
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(137, 75);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(37, 17);
            this.lbl_qty.TabIndex = 3;
            this.lbl_qty.Text = "QTY";
            // 
            // btn_sendProduct
            // 
            this.btn_sendProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sendProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sendProduct.Location = new System.Drawing.Point(338, 178);
            this.btn_sendProduct.Name = "btn_sendProduct";
            this.btn_sendProduct.Size = new System.Drawing.Size(147, 38);
            this.btn_sendProduct.TabIndex = 3;
            this.btn_sendProduct.Text = "Send Product";
            this.btn_sendProduct.UseVisualStyleBackColor = true;
            this.btn_sendProduct.Click += new System.EventHandler(this.btn_sendProduct_Click);
            // 
            // btn_warehouses
            // 
            this.btn_warehouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_warehouses.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_warehouses.Location = new System.Drawing.Point(722, 158);
            this.btn_warehouses.Name = "btn_warehouses";
            this.btn_warehouses.Size = new System.Drawing.Size(162, 63);
            this.btn_warehouses.TabIndex = 5;
            this.btn_warehouses.Text = "Stock Information";
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
            this.groupBox.Location = new System.Drawing.Point(820, 426);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(578, 173);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Messages";
            // 
            // dataGridViewMsg
            // 
            this.dataGridViewMsg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMsg.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewMsg.Name = "dataGridViewMsg";
            this.dataGridViewMsg.RowHeadersWidth = 51;
            this.dataGridViewMsg.RowTemplate.Height = 24;
            this.dataGridViewMsg.Size = new System.Drawing.Size(572, 152);
            this.dataGridViewMsg.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(24, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 179);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStock.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.RowHeadersWidth = 51;
            this.dataGridViewStock.RowTemplate.Height = 24;
            this.dataGridViewStock.Size = new System.Drawing.Size(743, 158);
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
            this.grp_box_Send.Location = new System.Drawing.Point(38, 39);
            this.grp_box_Send.Name = "grp_box_Send";
            this.grp_box_Send.Size = new System.Drawing.Size(567, 235);
            this.grp_box_Send.TabIndex = 17;
            this.grp_box_Send.TabStop = false;
            this.grp_box_Send.Text = "Send Product";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(664, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_exit.Location = new System.Drawing.Point(722, 237);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(162, 37);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ManufacturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 668);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grp_box_Send);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btn_warehouses);
            this.Controls.Add(this.label1);
            this.Name = "ManufacturerForm";
            this.Text = "ManufacturerForm";
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
        private System.Windows.Forms.DataGridView dataGridViewMsg;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}