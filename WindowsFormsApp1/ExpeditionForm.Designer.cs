
namespace WindowsFormsApp1
{
    partial class ExpeditionForm
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
            this.est_lbl_arrival_date = new System.Windows.Forms.Label();
            this.lbl_act_arr_date = new System.Windows.Forms.Label();
            this.lbl_act_dep_date = new System.Windows.Forms.Label();
            this.lbl_est_dep = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.est_arr_date_picker = new System.Windows.Forms.DateTimePicker();
            this.act_departure_date = new System.Windows.Forms.DateTimePicker();
            this.est_dep_date = new System.Windows.Forms.DateTimePicker();
            this.act_arr_date_picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_box_from = new System.Windows.Forms.TextBox();
            this.txt_parcel_amount = new System.Windows.Forms.TextBox();
            this.txt_cargo_name = new System.Windows.Forms.TextBox();
            this.txt_box_to = new System.Windows.Forms.TextBox();
            this.txt_total_cargo_volume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_total_cargo_weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_cus_name = new System.Windows.Forms.ComboBox();
            this.lbl_q = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_ware_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // est_lbl_arrival_date
            // 
            this.est_lbl_arrival_date.AutoSize = true;
            this.est_lbl_arrival_date.Location = new System.Drawing.Point(41, 22);
            this.est_lbl_arrival_date.Name = "est_lbl_arrival_date";
            this.est_lbl_arrival_date.Size = new System.Drawing.Size(108, 13);
            this.est_lbl_arrival_date.TabIndex = 0;
            this.est_lbl_arrival_date.Text = "EstimatedArrivalDate:";
            // 
            // lbl_act_arr_date
            // 
            this.lbl_act_arr_date.AutoSize = true;
            this.lbl_act_arr_date.Location = new System.Drawing.Point(41, 71);
            this.lbl_act_arr_date.Name = "lbl_act_arr_date";
            this.lbl_act_arr_date.Size = new System.Drawing.Size(92, 13);
            this.lbl_act_arr_date.TabIndex = 1;
            this.lbl_act_arr_date.Text = "ActualArrivalDate:";
            // 
            // lbl_act_dep_date
            // 
            this.lbl_act_dep_date.AutoSize = true;
            this.lbl_act_dep_date.Location = new System.Drawing.Point(41, 158);
            this.lbl_act_dep_date.Name = "lbl_act_dep_date";
            this.lbl_act_dep_date.Size = new System.Drawing.Size(110, 13);
            this.lbl_act_dep_date.TabIndex = 2;
            this.lbl_act_dep_date.Text = "ActualDepartureDate:";
            // 
            // lbl_est_dep
            // 
            this.lbl_est_dep.AutoSize = true;
            this.lbl_est_dep.Location = new System.Drawing.Point(41, 120);
            this.lbl_est_dep.Name = "lbl_est_dep";
            this.lbl_est_dep.Size = new System.Drawing.Size(120, 13);
            this.lbl_est_dep.TabIndex = 3;
            this.lbl_est_dep.Text = "EstimateDepartureDate:";
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.edit_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.edit_btn.Location = new System.Drawing.Point(499, 381);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(99, 31);
            this.edit_btn.TabIndex = 8;
            this.edit_btn.Text = "ACCEPT";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // est_arr_date_picker
            // 
            this.est_arr_date_picker.Location = new System.Drawing.Point(178, 22);
            this.est_arr_date_picker.Name = "est_arr_date_picker";
            this.est_arr_date_picker.Size = new System.Drawing.Size(139, 20);
            this.est_arr_date_picker.TabIndex = 9;
            // 
            // act_departure_date
            // 
            this.act_departure_date.Location = new System.Drawing.Point(178, 152);
            this.act_departure_date.Name = "act_departure_date";
            this.act_departure_date.Size = new System.Drawing.Size(139, 20);
            this.act_departure_date.TabIndex = 10;
            // 
            // est_dep_date
            // 
            this.est_dep_date.Location = new System.Drawing.Point(178, 114);
            this.est_dep_date.Name = "est_dep_date";
            this.est_dep_date.Size = new System.Drawing.Size(139, 20);
            this.est_dep_date.TabIndex = 11;
            // 
            // act_arr_date_picker
            // 
            this.act_arr_date_picker.Location = new System.Drawing.Point(178, 71);
            this.act_arr_date_picker.Name = "act_arr_date_picker";
            this.act_arr_date_picker.Size = new System.Drawing.Size(139, 20);
            this.act_arr_date_picker.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cargo ParcelAmount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cargo Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "From";
            // 
            // txt_box_from
            // 
            this.txt_box_from.Location = new System.Drawing.Point(178, 194);
            this.txt_box_from.Name = "txt_box_from";
            this.txt_box_from.Size = new System.Drawing.Size(139, 20);
            this.txt_box_from.TabIndex = 17;
            // 
            // txt_parcel_amount
            // 
            this.txt_parcel_amount.Location = new System.Drawing.Point(178, 284);
            this.txt_parcel_amount.Name = "txt_parcel_amount";
            this.txt_parcel_amount.Size = new System.Drawing.Size(139, 20);
            this.txt_parcel_amount.TabIndex = 18;
            // 
            // txt_cargo_name
            // 
            this.txt_cargo_name.Location = new System.Drawing.Point(178, 253);
            this.txt_cargo_name.Name = "txt_cargo_name";
            this.txt_cargo_name.Size = new System.Drawing.Size(139, 20);
            this.txt_cargo_name.TabIndex = 19;
            // 
            // txt_box_to
            // 
            this.txt_box_to.Location = new System.Drawing.Point(178, 226);
            this.txt_box_to.Name = "txt_box_to";
            this.txt_box_to.Size = new System.Drawing.Size(139, 20);
            this.txt_box_to.TabIndex = 20;
            // 
            // txt_total_cargo_volume
            // 
            this.txt_total_cargo_volume.Location = new System.Drawing.Point(178, 347);
            this.txt_total_cargo_volume.Name = "txt_total_cargo_volume";
            this.txt_total_cargo_volume.Size = new System.Drawing.Size(139, 20);
            this.txt_total_cargo_volume.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total Cargo Volume";
            // 
            // txt_total_cargo_weight
            // 
            this.txt_total_cargo_weight.Location = new System.Drawing.Point(178, 314);
            this.txt_total_cargo_weight.Name = "txt_total_cargo_weight";
            this.txt_total_cargo_weight.Size = new System.Drawing.Size(139, 20);
            this.txt_total_cargo_weight.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total Cargo Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(178, 378);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(139, 20);
            this.txt_status.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Customer Name";
            // 
            // comboBox_cus_name
            // 
            this.comboBox_cus_name.FormattingEnabled = true;
            this.comboBox_cus_name.Items.AddRange(new object[] {
            "furkan",
            "porsche",
            "iveco",
            "tata",
            "BENTLEY",
            "AXA ",
            "KARSA"});
            this.comboBox_cus_name.Location = new System.Drawing.Point(178, 407);
            this.comboBox_cus_name.Name = "comboBox_cus_name";
            this.comboBox_cus_name.Size = new System.Drawing.Size(139, 21);
            this.comboBox_cus_name.TabIndex = 28;
            // 
            // lbl_q
            // 
            this.lbl_q.AutoSize = true;
            this.lbl_q.Location = new System.Drawing.Point(352, 22);
            this.lbl_q.Name = "lbl_q";
            this.lbl_q.Size = new System.Drawing.Size(52, 13);
            this.lbl_q.TabIndex = 29;
            this.lbl_q.Text = "Quantity :";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(428, 22);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(139, 20);
            this.txt_quantity.TabIndex = 30;
            // 
            // txt_ware_name
            // 
            this.txt_ware_name.Location = new System.Drawing.Point(428, 61);
            this.txt_ware_name.Name = "txt_ware_name";
            this.txt_ware_name.Size = new System.Drawing.Size(139, 20);
            this.txt_ware_name.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Warehouse Name :";
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(428, 100);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(139, 20);
            this.txt_product.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Product Name :";
            // 
            // backButton
            // 
            this.backButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.backButton.Location = new System.Drawing.Point(635, 381);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 31);
            this.backButton.TabIndex = 35;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ExpeditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.txt_ware_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lbl_q);
            this.Controls.Add(this.comboBox_cus_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_total_cargo_weight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_total_cargo_volume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_box_to);
            this.Controls.Add(this.txt_cargo_name);
            this.Controls.Add(this.txt_parcel_amount);
            this.Controls.Add(this.txt_box_from);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.act_arr_date_picker);
            this.Controls.Add(this.est_dep_date);
            this.Controls.Add(this.act_departure_date);
            this.Controls.Add(this.est_arr_date_picker);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.lbl_est_dep);
            this.Controls.Add(this.lbl_act_dep_date);
            this.Controls.Add(this.lbl_act_arr_date);
            this.Controls.Add(this.est_lbl_arrival_date);
            this.Name = "ExpeditionForm";
            this.Text = "ExpeditionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label est_lbl_arrival_date;
        private System.Windows.Forms.Label lbl_act_arr_date;
        private System.Windows.Forms.Label lbl_act_dep_date;
        private System.Windows.Forms.Label lbl_est_dep;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.DateTimePicker est_arr_date_picker;
        private System.Windows.Forms.DateTimePicker act_departure_date;
        private System.Windows.Forms.DateTimePicker est_dep_date;
        private System.Windows.Forms.DateTimePicker act_arr_date_picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_box_from;
        private System.Windows.Forms.TextBox txt_parcel_amount;
        private System.Windows.Forms.TextBox txt_cargo_name;
        private System.Windows.Forms.TextBox txt_box_to;
        private System.Windows.Forms.TextBox txt_total_cargo_volume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_total_cargo_weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_cus_name;
        private System.Windows.Forms.Label lbl_q;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_ware_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button backButton;
    }
}