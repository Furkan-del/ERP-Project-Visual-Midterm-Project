
namespace WindowsFormsApp1
{
    partial class ReportingScreenForm
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
            this.filter_txt_box = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.report_data_view = new System.Windows.Forms.DataGridView();
            this.dateFilter = new System.Windows.Forms.Button();
            this.date_time_begin = new System.Windows.Forms.DateTimePicker();
            this.date_time_deliver = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_and_warehouse_filt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.report_data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // filter_txt_box
            // 
            this.filter_txt_box.Location = new System.Drawing.Point(196, 18);
            this.filter_txt_box.Margin = new System.Windows.Forms.Padding(2);
            this.filter_txt_box.Name = "filter_txt_box";
            this.filter_txt_box.Size = new System.Drawing.Size(366, 20);
            this.filter_txt_box.TabIndex = 0;
            // 
            // filterButton
            // 
            this.filterButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.filterButton.Location = new System.Drawing.Point(300, 155);
            this.filterButton.Margin = new System.Windows.Forms.Padding(2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(106, 23);
            this.filterButton.TabIndex = 1;
            this.filterButton.Text = "&FILTER";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // report_data_view
            // 
            this.report_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report_data_view.Location = new System.Drawing.Point(26, 232);
            this.report_data_view.Margin = new System.Windows.Forms.Padding(2);
            this.report_data_view.Name = "report_data_view";
            this.report_data_view.RowHeadersWidth = 51;
            this.report_data_view.RowTemplate.Height = 24;
            this.report_data_view.Size = new System.Drawing.Size(554, 97);
            this.report_data_view.TabIndex = 2;
            // 
            // dateFilter
            // 
            this.dateFilter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dateFilter.Location = new System.Drawing.Point(20, 155);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(111, 23);
            this.dateFilter.TabIndex = 3;
            this.dateFilter.Text = "Date Filter";
            this.dateFilter.UseVisualStyleBackColor = true;
            this.dateFilter.Click += new System.EventHandler(this.dateFilter_Click);
            // 
            // date_time_begin
            // 
            this.date_time_begin.Location = new System.Drawing.Point(23, 68);
            this.date_time_begin.Name = "date_time_begin";
            this.date_time_begin.Size = new System.Drawing.Size(108, 20);
            this.date_time_begin.TabIndex = 4;
            // 
            // date_time_deliver
            // 
            this.date_time_deliver.Location = new System.Drawing.Point(20, 129);
            this.date_time_deliver.Name = "date_time_deliver";
            this.date_time_deliver.Size = new System.Drawing.Size(108, 20);
            this.date_time_deliver.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deliver Date:";
            // 
            // date_and_warehouse_filt
            // 
            this.date_and_warehouse_filt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.date_and_warehouse_filt.Location = new System.Drawing.Point(157, 155);
            this.date_and_warehouse_filt.Name = "date_and_warehouse_filt";
            this.date_and_warehouse_filt.Size = new System.Drawing.Size(124, 23);
            this.date_and_warehouse_filt.TabIndex = 8;
            this.date_and_warehouse_filt.Text = "Filter Together";
            this.date_and_warehouse_filt.UseVisualStyleBackColor = true;
            this.date_and_warehouse_filt.Click += new System.EventHandler(this.date_and_warehouse_filt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Warehouse Name:";
            // 
            // ReportingScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_and_warehouse_filt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_time_deliver);
            this.Controls.Add(this.date_time_begin);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.report_data_view);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filter_txt_box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportingScreenForm";
            this.Text = "ReportingScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.report_data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filter_txt_box;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.DataGridView report_data_view;
        private System.Windows.Forms.Button dateFilter;
        private System.Windows.Forms.DateTimePicker date_time_begin;
        private System.Windows.Forms.DateTimePicker date_time_deliver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button date_and_warehouse_filt;
        private System.Windows.Forms.Label label3;
    }
}