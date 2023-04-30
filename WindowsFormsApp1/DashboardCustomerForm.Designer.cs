
namespace WindowsFormsApp1
{
    partial class DashboardCustomerForm
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
            this.btn_send = new System.Windows.Forms.Button();
            this.grpBox_customer = new System.Windows.Forms.GroupBox();
            this.to_man = new System.Windows.Forms.Label();
            this.txt_sender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpTIRSANDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erpTIRSANDataSet = new WindowsFormsApp1.erpTIRSANDataSet();
            this.productsTableAdapter = new WindowsFormsApp1.erpTIRSANDataSetTableAdapters.productsTableAdapter();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cus_menu_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.cusname = new System.Windows.Forms.ToolStripMenuItem();
            this.location_men_itm = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmb_box_man_name = new System.Windows.Forms.ComboBox();
            this.grpBox_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTIRSANDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTIRSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_send.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_send.Location = new System.Drawing.Point(412, 95);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(141, 50);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "&Send  Request";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // grpBox_customer
            // 
            this.grpBox_customer.Controls.Add(this.to_man);
            this.grpBox_customer.Controls.Add(this.cmb_box_man_name);
            this.grpBox_customer.Controls.Add(this.txt_sender);
            this.grpBox_customer.Controls.Add(this.label5);
            this.grpBox_customer.Controls.Add(this.txt_message);
            this.grpBox_customer.Controls.Add(this.label2);
            this.grpBox_customer.Controls.Add(this.label1);
            this.grpBox_customer.Location = new System.Drawing.Point(24, 43);
            this.grpBox_customer.Name = "grpBox_customer";
            this.grpBox_customer.Size = new System.Drawing.Size(272, 308);
            this.grpBox_customer.TabIndex = 16;
            this.grpBox_customer.TabStop = false;
            this.grpBox_customer.Text = "CustomerDashBoard";
            // 
            // to_man
            // 
            this.to_man.AutoSize = true;
            this.to_man.Location = new System.Drawing.Point(16, 172);
            this.to_man.Name = "to_man";
            this.to_man.Size = new System.Drawing.Size(25, 17);
            this.to_man.TabIndex = 25;
            this.to_man.Text = "To";
            // 
            // txt_sender
            // 
            this.txt_sender.Location = new System.Drawing.Point(126, 130);
            this.txt_sender.Name = "txt_sender";
            this.txt_sender.Size = new System.Drawing.Size(140, 22);
            this.txt_sender.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_sender, "sender name");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sender Name";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(126, 81);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(140, 22);
            this.txt_message.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_message, "requests");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Requests";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.erpTIRSANDataSetBindingSource;
            // 
            // erpTIRSANDataSetBindingSource
            // 
            this.erpTIRSANDataSetBindingSource.DataSource = this.erpTIRSANDataSet;
            this.erpTIRSANDataSetBindingSource.Position = 0;
            // 
            // erpTIRSANDataSet
            // 
            this.erpTIRSANDataSet.DataSetName = "erpTIRSANDataSet";
            this.erpTIRSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_list
            // 
            this.btn_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_list.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_list.Location = new System.Drawing.Point(412, 169);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(141, 50);
            this.btn_list.TabIndex = 4;
            this.btn_list.Text = "&List All Products";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_exit.Location = new System.Drawing.Point(412, 242);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(141, 41);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "&EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(304, 356);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(526, 150);
            this.dataGridViewCustomer.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cus_menu_strip,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(896, 28);
            this.menuStrip2.TabIndex = 19;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cus_menu_strip
            // 
            this.cus_menu_strip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cusname,
            this.location_men_itm});
            this.cus_menu_strip.Name = "cus_menu_strip";
            this.cus_menu_strip.Size = new System.Drawing.Size(76, 24);
            this.cus_menu_strip.Text = "Cus Info";
            this.cus_menu_strip.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // cusname
            // 
            this.cusname.Name = "cusname";
            this.cusname.Size = new System.Drawing.Size(154, 26);
            this.cusname.Text = "cus name";
            // 
            // location_men_itm
            // 
            this.location_men_itm.Name = "location_men_itm";
            this.location_men_itm.Size = new System.Drawing.Size(154, 26);
            this.location_men_itm.Text = "details";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // cmb_box_man_name
            // 
            this.cmb_box_man_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_box_man_name.FormattingEnabled = true;
            this.cmb_box_man_name.Items.AddRange(new object[] {
            "VESPA",
            "PROTON",
            "CITROEN",
            "TATA",
            "SKODA",
            "DACIA",
            "MERCEDES ",
            "LAMBO",
            "VIZZA"});
            this.cmb_box_man_name.Location = new System.Drawing.Point(126, 184);
            this.cmb_box_man_name.Name = "cmb_box_man_name";
            this.cmb_box_man_name.Size = new System.Drawing.Size(140, 24);
            this.cmb_box_man_name.TabIndex = 20;
            this.toolTip1.SetToolTip(this.cmb_box_man_name, "manufacturer name");
            // 
            // DashboardCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 538);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.grpBox_customer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardCustomerForm";
            this.Text = "DashboardCustomer";
            this.grpBox_customer.ResumeLayout(false);
            this.grpBox_customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTIRSANDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTIRSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.GroupBox grpBox_customer;
        private System.Windows.Forms.BindingSource erpTIRSANDataSetBindingSource;
        private erpTIRSANDataSet erpTIRSANDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private erpTIRSANDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.TextBox txt_sender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cus_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem cusname;
        private System.Windows.Forms.ToolStripMenuItem location_men_itm;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label to_man;
        private System.Windows.Forms.ComboBox cmb_box_man_name;
    }
}