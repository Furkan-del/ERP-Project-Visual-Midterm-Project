
namespace WindowsFormsApp1
{
    partial class WareHouseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_man = new System.Windows.Forms.Label();
            this.txt_man_name = new System.Windows.Forms.TextBox();
            this.txt_p_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_main_page = new System.Windows.Forms.Button();
            this.txtboloc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_number_warehouse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_man);
            this.groupBox1.Controls.Add(this.txt_man_name);
            this.groupBox1.Controls.Add(this.txt_p_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_enter);
            this.groupBox1.Controls.Add(this.btn_main_page);
            this.groupBox1.Controls.Add(this.txtboloc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_number_warehouse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Warehouse";
            // 
            // lbl_man
            // 
            this.lbl_man.AutoSize = true;
            this.lbl_man.Location = new System.Drawing.Point(6, 236);
            this.lbl_man.Name = "lbl_man";
            this.lbl_man.Size = new System.Drawing.Size(133, 17);
            this.lbl_man.TabIndex = 9;
            this.lbl_man.Text = "Manufacturer Name";
            // 
            // txt_man_name
            // 
            this.txt_man_name.Location = new System.Drawing.Point(190, 231);
            this.txt_man_name.Name = "txt_man_name";
            this.txt_man_name.Size = new System.Drawing.Size(115, 22);
            this.txt_man_name.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txt_man_name, "manufacturer name");
            // 
            // txt_p_name
            // 
            this.txt_p_name.Location = new System.Drawing.Point(190, 188);
            this.txt_p_name.Name = "txt_p_name";
            this.txt_p_name.Size = new System.Drawing.Size(115, 22);
            this.txt_p_name.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_p_name, "product name");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Name";
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_enter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_enter.Location = new System.Drawing.Point(26, 286);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(130, 52);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "&Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_main_page
            // 
            this.btn_main_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_main_page.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_main_page.Location = new System.Drawing.Point(179, 286);
            this.btn_main_page.Name = "btn_main_page";
            this.btn_main_page.Size = new System.Drawing.Size(135, 52);
            this.btn_main_page.TabIndex = 4;
            this.btn_main_page.Text = "&Main Page Manufacturer";
            this.btn_main_page.UseVisualStyleBackColor = true;
            this.btn_main_page.Click += new System.EventHandler(this.btn_main_page_Click);
            // 
            // txtboloc
            // 
            this.txtboloc.Location = new System.Drawing.Point(190, 127);
            this.txtboloc.Name = "txtboloc";
            this.txtboloc.Size = new System.Drawing.Size(121, 22);
            this.txtboloc.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtboloc, "location");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // txt_number_warehouse
            // 
            this.txt_number_warehouse.Location = new System.Drawing.Point(190, 78);
            this.txt_number_warehouse.Name = "txt_number_warehouse";
            this.txt_number_warehouse.Size = new System.Drawing.Size(121, 22);
            this.txt_number_warehouse.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_number_warehouse, "number of warehouse");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Warehouses";
            // 
            // WareHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "WareHouseForm";
            this.Text = "WareHouse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_main_page;
        private System.Windows.Forms.TextBox txtboloc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_number_warehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_p_name;
        private System.Windows.Forms.Label lbl_man;
        private System.Windows.Forms.TextBox txt_man_name;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}