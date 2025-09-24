
namespace IncomeandExpensesTracker
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.expenses_btn = new System.Windows.Forms.Button();
            this.income_btn = new System.Windows.Forms.Button();
            this.addcategory_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.getusername = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.incomeForm1 = new IncomeandExpensesTracker.IncomeForm();
            this.categoryForm1 = new IncomeandExpensesTracker.CategoryForm();
            this.expensesForm1 = new IncomeandExpensesTracker.ExpensesForm();
            this.dashboardForm1 = new IncomeandExpensesTracker.DashboardForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 45);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Income and Expenses Tracker";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1255, 16);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(17, 17);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.expenses_btn);
            this.panel2.Controls.Add(this.income_btn);
            this.panel2.Controls.Add(this.addcategory_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.getusername);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 655);
            this.panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(26, 487);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(145, 35);
            this.logout_btn.TabIndex = 7;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // expenses_btn
            // 
            this.expenses_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.expenses_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_btn.ForeColor = System.Drawing.Color.White;
            this.expenses_btn.Location = new System.Drawing.Point(26, 334);
            this.expenses_btn.Name = "expenses_btn";
            this.expenses_btn.Size = new System.Drawing.Size(145, 35);
            this.expenses_btn.TabIndex = 6;
            this.expenses_btn.Text = "Expenses";
            this.expenses_btn.UseVisualStyleBackColor = false;
            this.expenses_btn.Click += new System.EventHandler(this.expenses_btn_Click);
            // 
            // income_btn
            // 
            this.income_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_btn.ForeColor = System.Drawing.Color.White;
            this.income_btn.Location = new System.Drawing.Point(26, 277);
            this.income_btn.Name = "income_btn";
            this.income_btn.Size = new System.Drawing.Size(145, 35);
            this.income_btn.TabIndex = 5;
            this.income_btn.Text = "Income";
            this.income_btn.UseVisualStyleBackColor = false;
            this.income_btn.Click += new System.EventHandler(this.income_btn_Click);
            // 
            // addcategory_btn
            // 
            this.addcategory_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.addcategory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcategory_btn.ForeColor = System.Drawing.Color.White;
            this.addcategory_btn.Location = new System.Drawing.Point(26, 214);
            this.addcategory_btn.Name = "addcategory_btn";
            this.addcategory_btn.Size = new System.Drawing.Size(145, 35);
            this.addcategory_btn.TabIndex = 4;
            this.addcategory_btn.Text = "Add Category";
            this.addcategory_btn.UseVisualStyleBackColor = false;
            this.addcategory_btn.Click += new System.EventHandler(this.addcategory_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Location = new System.Drawing.Point(26, 157);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(145, 35);
            this.dashboard_btn.TabIndex = 3;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // getusername
            // 
            this.getusername.AutoSize = true;
            this.getusername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getusername.ForeColor = System.Drawing.Color.White;
            this.getusername.Location = new System.Drawing.Point(13, 112);
            this.getusername.Name = "getusername";
            this.getusername.Size = new System.Drawing.Size(78, 19);
            this.getusername.TabIndex = 1;
            this.getusername.Text = "Welcome,";
            this.getusername.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(44, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 73);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // incomeForm1
            // 
            this.incomeForm1.Location = new System.Drawing.Point(269, 74);
            this.incomeForm1.Name = "incomeForm1";
            this.incomeForm1.Size = new System.Drawing.Size(973, 582);
            this.incomeForm1.TabIndex = 2;
            // 
            // categoryForm1
            // 
            this.categoryForm1.Location = new System.Drawing.Point(284, 84);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(943, 604);
            this.categoryForm1.TabIndex = 3;
            // 
            // expensesForm1
            // 
            this.expensesForm1.Location = new System.Drawing.Point(284, 93);
            this.expensesForm1.Name = "expensesForm1";
            this.expensesForm1.Size = new System.Drawing.Size(943, 583);
            this.expensesForm1.TabIndex = 4;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(254, 60);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1003, 628);
            this.dashboardForm1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1284, 700);
            this.Controls.Add(this.dashboardForm1);
            this.Controls.Add(this.expensesForm1);
            this.Controls.Add(this.categoryForm1);
            this.Controls.Add(this.incomeForm1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label getusername;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button expenses_btn;
        private System.Windows.Forms.Button income_btn;
        private System.Windows.Forms.Button addcategory_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private IncomeForm incomeForm1;
        private CategoryForm categoryForm1;
        private ExpensesForm expensesForm1;
        private DashboardForm dashboardForm1;
    }
}