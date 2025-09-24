
namespace IncomeandExpensesTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_userlabel = new System.Windows.Forms.Label();
            this.login_usertextbox = new System.Windows.Forms.TextBox();
            this.login_pwdtextbox = new System.Windows.Forms.TextBox();
            this.login_pwdlabel = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_showcheckbox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 427);
            this.panel1.TabIndex = 0;
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.signup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.signup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Location = new System.Drawing.Point(22, 361);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(275, 40);
            this.signup_btn.TabIndex = 8;
            this.signup_btn.Text = "SIGN UP";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(79, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "REGISTER HERE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income and Expenses Tracker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 464);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(670, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(17, 17);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "SIGN IN";
            // 
            // login_userlabel
            // 
            this.login_userlabel.AutoSize = true;
            this.login_userlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_userlabel.Location = new System.Drawing.Point(332, 148);
            this.login_userlabel.Name = "login_userlabel";
            this.login_userlabel.Size = new System.Drawing.Size(80, 19);
            this.login_userlabel.TabIndex = 3;
            this.login_userlabel.Text = "Username";
            // 
            // login_usertextbox
            // 
            this.login_usertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_usertextbox.Location = new System.Drawing.Point(336, 182);
            this.login_usertextbox.Name = "login_usertextbox";
            this.login_usertextbox.Size = new System.Drawing.Size(319, 29);
            this.login_usertextbox.TabIndex = 4;
            // 
            // login_pwdtextbox
            // 
            this.login_pwdtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pwdtextbox.Location = new System.Drawing.Point(336, 263);
            this.login_pwdtextbox.Name = "login_pwdtextbox";
            this.login_pwdtextbox.PasswordChar = '*';
            this.login_pwdtextbox.Size = new System.Drawing.Size(319, 29);
            this.login_pwdtextbox.TabIndex = 6;
            // 
            // login_pwdlabel
            // 
            this.login_pwdlabel.AutoSize = true;
            this.login_pwdlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pwdlabel.Location = new System.Drawing.Point(336, 229);
            this.login_pwdlabel.Name = "login_pwdlabel";
            this.login_pwdlabel.Size = new System.Drawing.Size(76, 19);
            this.login_pwdlabel.TabIndex = 5;
            this.login_pwdlabel.Text = "Password";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(336, 335);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(101, 40);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_showcheckbox
            // 
            this.login_showcheckbox.AutoSize = true;
            this.login_showcheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showcheckbox.Location = new System.Drawing.Point(522, 309);
            this.login_showcheckbox.Name = "login_showcheckbox";
            this.login_showcheckbox.Size = new System.Drawing.Size(123, 20);
            this.login_showcheckbox.TabIndex = 8;
            this.login_showcheckbox.Text = "Show Password";
            this.login_showcheckbox.UseVisualStyleBackColor = true;
            this.login_showcheckbox.CheckedChanged += new System.EventHandler(this.login_showcheckbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 427);
            this.Controls.Add(this.login_showcheckbox);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_pwdtextbox);
            this.Controls.Add(this.login_pwdlabel);
            this.Controls.Add(this.login_usertextbox);
            this.Controls.Add(this.login_userlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label login_userlabel;
        private System.Windows.Forms.TextBox login_usertextbox;
        private System.Windows.Forms.TextBox login_pwdtextbox;
        private System.Windows.Forms.Label login_pwdlabel;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.CheckBox login_showcheckbox;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label label6;
    }
}

