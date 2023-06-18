
namespace WindowsFormsApp1
{
    partial class CustomerAddForm
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
            this.txt_cus_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_emp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_cstmr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cus_name
            // 
            this.txt_cus_name.Location = new System.Drawing.Point(151, 60);
            this.txt_cus_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_cus_name.Name = "txt_cus_name";
            this.txt_cus_name.Size = new System.Drawing.Size(76, 20);
            this.txt_cus_name.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_cus_name, "customer name");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Number Employee:";
            // 
            // txt_emp
            // 
            this.txt_emp.Location = new System.Drawing.Point(151, 137);
            this.txt_emp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_emp.Name = "txt_emp";
            this.txt_emp.Size = new System.Drawing.Size(76, 20);
            this.txt_emp.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_emp, "total number of employee");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(151, 94);
            this.txt_address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(76, 20);
            this.txt_address.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_address, "address");
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_enter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_enter.Location = new System.Drawing.Point(21, 192);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(117, 47);
            this.btn_enter.TabIndex = 3;
            this.btn_enter.Text = "&Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click_1);
            // 
            // btn_cstmr
            // 
            this.btn_cstmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cstmr.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_cstmr.Location = new System.Drawing.Point(161, 193);
            this.btn_cstmr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cstmr.Name = "btn_cstmr";
            this.btn_cstmr.Size = new System.Drawing.Size(136, 47);
            this.btn_cstmr.TabIndex = 4;
            this.btn_cstmr.Text = "&Customer Main Page";
            this.btn_cstmr.UseVisualStyleBackColor = true;
            this.btn_cstmr.Click += new System.EventHandler(this.btn_cstmr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cus_name);
            this.groupBox1.Controls.Add(this.btn_enter);
            this.groupBox1.Controls.Add(this.btn_cstmr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_emp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Location = new System.Drawing.Point(26, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(412, 286);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Customer";
            // 
            // CustomerAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerAddForm";
            this.Text = "CustomerAddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cus_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_emp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_cstmr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}