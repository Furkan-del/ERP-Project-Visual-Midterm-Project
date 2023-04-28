
namespace WindowsFormsApp1
{
    partial class ManufacturerInfoForm
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
            this.txt_man_name = new System.Windows.Forms.TextBox();
            this.txt_num_emp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_man_page = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_warehouse = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturer Name:";
            // 
            // txt_man_name
            // 
            this.txt_man_name.Location = new System.Drawing.Point(195, 88);
            this.txt_man_name.Name = "txt_man_name";
            this.txt_man_name.Size = new System.Drawing.Size(127, 22);
            this.txt_man_name.TabIndex = 1;
            // 
            // txt_num_emp
            // 
            this.txt_num_emp.Location = new System.Drawing.Point(198, 193);
            this.txt_num_emp.Name = "txt_num_emp";
            this.txt_num_emp.Size = new System.Drawing.Size(127, 22);
            this.txt_num_emp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Number Employee:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(195, 138);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(127, 22);
            this.txt_address.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(11, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_man_page
            // 
            this.btn_man_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_man_page.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_man_page.Location = new System.Drawing.Point(178, 278);
            this.btn_man_page.Name = "btn_man_page";
            this.btn_man_page.Size = new System.Drawing.Size(173, 54);
            this.btn_man_page.TabIndex = 7;
            this.btn_man_page.Text = "Manufacturer Page";
            this.btn_man_page.UseVisualStyleBackColor = true;
            this.btn_man_page.Click += new System.EventHandler(this.btn_man_page_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.btn_addProduct);
            this.groupBox1.Controls.Add(this.btn_warehouse);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_man_page);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_man_name);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_num_emp);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 458);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manufacturer Information";
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addProduct.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_addProduct.Location = new System.Drawing.Point(11, 352);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(140, 46);
            this.btn_addProduct.TabIndex = 9;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_warehouse
            // 
            this.btn_warehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_warehouse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_warehouse.Location = new System.Drawing.Point(371, 278);
            this.btn_warehouse.Name = "btn_warehouse";
            this.btn_warehouse.Size = new System.Drawing.Size(175, 54);
            this.btn_warehouse.TabIndex = 8;
            this.btn_warehouse.Text = "Add Warehouse";
            this.btn_warehouse.UseVisualStyleBackColor = true;
            this.btn_warehouse.Click += new System.EventHandler(this.btn_warehouse_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.exitButton.Location = new System.Drawing.Point(195, 352);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(138, 46);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ManufacturerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 503);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManufacturerInfoForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_man_name;
        private System.Windows.Forms.TextBox txt_num_emp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_man_page;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_warehouse;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button exitButton;
    }
}