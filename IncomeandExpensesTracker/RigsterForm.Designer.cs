
namespace IncomeandExpensesTracker
{
    partial class RigsterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RigsterForm));
            this.close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signin_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_showcheckbox = new System.Windows.Forms.CheckBox();
            this.signup_register_btn = new System.Windows.Forms.Button();
            this.signup_pwdtextbox = new System.Windows.Forms.TextBox();
            this.signup_pwdlabel = new System.Windows.Forms.Label();
            this.signup_usertextbox = new System.Windows.Forms.TextBox();
            this.signup_userlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_conpwd_textbox = new System.Windows.Forms.TextBox();
            this.signup_conpwd_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.White;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(660, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(17, 17);
            this.close.TabIndex = 10;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.signin_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 427);
            this.panel1.TabIndex = 9;
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.signin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.signin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_btn.ForeColor = System.Drawing.Color.White;
            this.signin_btn.Location = new System.Drawing.Point(22, 335);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(275, 40);
            this.signin_btn.TabIndex = 8;
            this.signin_btn.Text = "SIGN IN";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(79, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "SIGN IN HERE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income and Expenses Tracker";
            // 
            // signup_showcheckbox
            // 
            this.signup_showcheckbox.AutoSize = true;
            this.signup_showcheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_showcheckbox.Location = new System.Drawing.Point(528, 314);
            this.signup_showcheckbox.Name = "signup_showcheckbox";
            this.signup_showcheckbox.Size = new System.Drawing.Size(123, 20);
            this.signup_showcheckbox.TabIndex = 17;
            this.signup_showcheckbox.Text = "Show Password";
            this.signup_showcheckbox.UseVisualStyleBackColor = true;
            this.signup_showcheckbox.CheckedChanged += new System.EventHandler(this.login_showcheckbox_CheckedChanged);
            // 
            // signup_register_btn
            // 
            this.signup_register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.signup_register_btn.FlatAppearance.BorderSize = 0;
            this.signup_register_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.signup_register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.signup_register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_register_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_register_btn.ForeColor = System.Drawing.Color.White;
            this.signup_register_btn.Location = new System.Drawing.Point(439, 351);
            this.signup_register_btn.Name = "signup_register_btn";
            this.signup_register_btn.Size = new System.Drawing.Size(101, 40);
            this.signup_register_btn.TabIndex = 16;
            this.signup_register_btn.Text = "SIGN UP";
            this.signup_register_btn.UseVisualStyleBackColor = false;
            this.signup_register_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // signup_pwdtextbox
            // 
            this.signup_pwdtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_pwdtextbox.Location = new System.Drawing.Point(332, 182);
            this.signup_pwdtextbox.Name = "signup_pwdtextbox";
            this.signup_pwdtextbox.PasswordChar = '*';
            this.signup_pwdtextbox.Size = new System.Drawing.Size(319, 29);
            this.signup_pwdtextbox.TabIndex = 15;
            this.signup_pwdtextbox.TextChanged += new System.EventHandler(this.login_pwdtextbox_TextChanged);
            // 
            // signup_pwdlabel
            // 
            this.signup_pwdlabel.AutoSize = true;
            this.signup_pwdlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_pwdlabel.Location = new System.Drawing.Point(328, 151);
            this.signup_pwdlabel.Name = "signup_pwdlabel";
            this.signup_pwdlabel.Size = new System.Drawing.Size(76, 19);
            this.signup_pwdlabel.TabIndex = 14;
            this.signup_pwdlabel.Text = "Password";
            // 
            // signup_usertextbox
            // 
            this.signup_usertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_usertextbox.Location = new System.Drawing.Point(333, 109);
            this.signup_usertextbox.Name = "signup_usertextbox";
            this.signup_usertextbox.Size = new System.Drawing.Size(319, 29);
            this.signup_usertextbox.TabIndex = 13;
            // 
            // signup_userlabel
            // 
            this.signup_userlabel.AutoSize = true;
            this.signup_userlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_userlabel.Location = new System.Drawing.Point(325, 70);
            this.signup_userlabel.Name = "signup_userlabel";
            this.signup_userlabel.Size = new System.Drawing.Size(80, 19);
            this.signup_userlabel.TabIndex = 12;
            this.signup_userlabel.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "SIGN UP";
            // 
            // signup_conpwd_textbox
            // 
            this.signup_conpwd_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_conpwd_textbox.Location = new System.Drawing.Point(333, 269);
            this.signup_conpwd_textbox.Name = "signup_conpwd_textbox";
            this.signup_conpwd_textbox.PasswordChar = '*';
            this.signup_conpwd_textbox.Size = new System.Drawing.Size(319, 29);
            this.signup_conpwd_textbox.TabIndex = 19;
            // 
            // signup_conpwd_label
            // 
            this.signup_conpwd_label.AutoSize = true;
            this.signup_conpwd_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_conpwd_label.Location = new System.Drawing.Point(329, 231);
            this.signup_conpwd_label.Name = "signup_conpwd_label";
            this.signup_conpwd_label.Size = new System.Drawing.Size(138, 19);
            this.signup_conpwd_label.TabIndex = 18;
            this.signup_conpwd_label.Text = "Confirm Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 442);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RigsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 427);
            this.Controls.Add(this.signup_conpwd_textbox);
            this.Controls.Add(this.signup_conpwd_label);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signup_showcheckbox);
            this.Controls.Add(this.signup_register_btn);
            this.Controls.Add(this.signup_pwdtextbox);
            this.Controls.Add(this.signup_pwdlabel);
            this.Controls.Add(this.signup_usertextbox);
            this.Controls.Add(this.signup_userlabel);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RigsterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RigsterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox signup_showcheckbox;
        private System.Windows.Forms.Button signup_register_btn;
        private System.Windows.Forms.TextBox signup_pwdtextbox;
        private System.Windows.Forms.Label signup_pwdlabel;
        private System.Windows.Forms.TextBox signup_usertextbox;
        private System.Windows.Forms.Label signup_userlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_conpwd_textbox;
        private System.Windows.Forms.Label signup_conpwd_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}