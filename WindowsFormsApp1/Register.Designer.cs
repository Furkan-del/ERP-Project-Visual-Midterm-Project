
namespace WindowsFormsApp1
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.ttpLiteral = new System.Windows.Forms.ToolTip(this.components);
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.Label();
            this.reg_button = new System.Windows.Forms.Button();
            this.dateTimePckr = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.link_lbl = new System.Windows.Forms.LinkLabel();
            this.log_lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(226, 175);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(111, 22);
            this.txt_password.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_password, "password");
            this.ttpLiteral.SetToolTip(this.txt_password, "Password");
            // 
            // txt_email
            // 
            this.txt_email.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_email.Location = new System.Drawing.Point(226, 131);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(111, 22);
            this.txt_email.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_email, "email");
            this.ttpLiteral.SetToolTip(this.txt_email, "User\'sEmail\r\n\r\n");
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(225, 216);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(112, 22);
            this.txt_role.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txt_role, "role");
            this.ttpLiteral.SetToolTip(this.txt_role, "password");
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(137, 88);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(137, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.AutoSize = true;
            this.emailTxtBox.Location = new System.Drawing.Point(140, 131);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(42, 17);
            this.emailTxtBox.TabIndex = 7;
            this.emailTxtBox.Text = "Email";
            // 
            // reg_button
            // 
            this.reg_button.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reg_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.reg_button.Location = new System.Drawing.Point(226, 266);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(111, 42);
            this.reg_button.TabIndex = 8;
            this.reg_button.Text = "&Register";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // dateTimePckr
            // 
            this.dateTimePckr.Location = new System.Drawing.Point(8, 12);
            this.dateTimePckr.Name = "dateTimePckr";
            this.dateTimePckr.Size = new System.Drawing.Size(202, 22);
            this.dateTimePckr.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(486, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 205);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Location = new System.Drawing.Point(137, 221);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(37, 17);
            this.lbl_Role.TabIndex = 17;
            this.lbl_Role.Text = "Role";
            // 
            // link_lbl
            // 
            this.link_lbl.AutoSize = true;
            this.link_lbl.Location = new System.Drawing.Point(334, 331);
            this.link_lbl.Name = "link_lbl";
            this.link_lbl.Size = new System.Drawing.Size(120, 17);
            this.link_lbl.TabIndex = 19;
            this.link_lbl.TabStop = true;
            this.link_lbl.Text = "go to Log In Page";
            this.link_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_LinkClicked);
            // 
            // log_lbl
            // 
            this.log_lbl.AutoSize = true;
            this.log_lbl.Location = new System.Drawing.Point(150, 331);
            this.log_lbl.Name = "log_lbl";
            this.log_lbl.Size = new System.Drawing.Size(186, 17);
            this.log_lbl.TabIndex = 20;
            this.log_lbl.Text = "If you are already registered";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(226, 88);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(111, 22);
            this.txt_userName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_userName, "username");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(386, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "&EXIT";
            this.toolTip1.SetToolTip(this.button1, "Exit");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.log_lbl);
            this.Controls.Add(this.link_lbl);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePckr);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txt_password);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ttpLiteral.SetToolTip(this, "Customer Name");
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ttpLiteral;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label emailTxtBox;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.DateTimePicker dateTimePckr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.LinkLabel link_lbl;
        private System.Windows.Forms.Label log_lbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Button button1;
    }
}