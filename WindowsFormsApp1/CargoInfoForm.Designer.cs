
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dataGridViewCargo = new System.Windows.Forms.DataGridView();
            this.btn_list = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btn_accept_arr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCargo
            // 
            this.dataGridViewCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargo.Location = new System.Drawing.Point(15, 99);
            this.dataGridViewCargo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCargo.Name = "dataGridViewCargo";
            this.dataGridViewCargo.RowHeadersWidth = 51;
            this.dataGridViewCargo.RowTemplate.Height = 24;
            this.dataGridViewCargo.Size = new System.Drawing.Size(546, 116);
            this.dataGridViewCargo.TabIndex = 0;
            // 
            // btn_list
            // 
            this.btn_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_list.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_list.Location = new System.Drawing.Point(470, 235);
            this.btn_list.Margin = new System.Windows.Forms.Padding(2);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(106, 32);
            this.btn_list.TabIndex = 1;
            this.btn_list.Text = "LIST ALL";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 235);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(322, 15);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Here you can see your order information and some details";
            // 
            // btn_accept_arr
            // 
            this.btn_accept_arr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_accept_arr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_accept_arr.Location = new System.Drawing.Point(340, 235);
            this.btn_accept_arr.Name = "btn_accept_arr";
            this.btn_accept_arr.Size = new System.Drawing.Size(114, 32);
            this.btn_accept_arr.TabIndex = 3;
            this.btn_accept_arr.Text = "APPROVE";
            this.btn_accept_arr.UseVisualStyleBackColor = true;
            this.btn_accept_arr.Click += new System.EventHandler(this.btn_accept_arr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_accept_arr);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.dataGridViewCargo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "CargoInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCargo;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btn_accept_arr;
    }
}