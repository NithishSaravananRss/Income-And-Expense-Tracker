
namespace IncomeandExpensesTracker
{
    partial class ExpensesForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.expenses_clearbtn = new System.Windows.Forms.Button();
            this.expenses_deletebtn = new System.Windows.Forms.Button();
            this.expenses_updatebtn = new System.Windows.Forms.Button();
            this.expenses_addbtn = new System.Windows.Forms.Button();
            this.expenses_date_box = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expenses_desc_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.expenses_cost_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.expenses_item_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.expenses_category_combox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView11
            // 
            this.dataGridView11.AllowUserToAddRows = false;
            this.dataGridView11.AllowUserToDeleteRows = false;
            this.dataGridView11.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView11.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView11.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView11.EnableHeadersVisualStyles = false;
            this.dataGridView11.Location = new System.Drawing.Point(18, 46);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView11.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView11.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView11.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView11.Size = new System.Drawing.Size(758, 201);
            this.dataGridView11.TabIndex = 15;
            this.dataGridView11.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView11.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView11_CellContentClick);
            // 
            // expenses_clearbtn
            // 
            this.expenses_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.expenses_clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expenses_clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expenses_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses_clearbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_clearbtn.ForeColor = System.Drawing.Color.White;
            this.expenses_clearbtn.Location = new System.Drawing.Point(602, 197);
            this.expenses_clearbtn.Name = "expenses_clearbtn";
            this.expenses_clearbtn.Size = new System.Drawing.Size(76, 36);
            this.expenses_clearbtn.TabIndex = 14;
            this.expenses_clearbtn.Text = "Clear";
            this.expenses_clearbtn.UseVisualStyleBackColor = false;
            this.expenses_clearbtn.Click += new System.EventHandler(this.expenses_clearbtn_Click);
            // 
            // expenses_deletebtn
            // 
            this.expenses_deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.expenses_deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expenses_deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expenses_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses_deletebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_deletebtn.ForeColor = System.Drawing.Color.White;
            this.expenses_deletebtn.Location = new System.Drawing.Point(417, 197);
            this.expenses_deletebtn.Name = "expenses_deletebtn";
            this.expenses_deletebtn.Size = new System.Drawing.Size(81, 36);
            this.expenses_deletebtn.TabIndex = 13;
            this.expenses_deletebtn.Text = "Delete";
            this.expenses_deletebtn.UseVisualStyleBackColor = false;
            this.expenses_deletebtn.Click += new System.EventHandler(this.expenses_deletebtn_Click);
            // 
            // expenses_updatebtn
            // 
            this.expenses_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.expenses_updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expenses_updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expenses_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses_updatebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_updatebtn.ForeColor = System.Drawing.Color.White;
            this.expenses_updatebtn.Location = new System.Drawing.Point(196, 197);
            this.expenses_updatebtn.Name = "expenses_updatebtn";
            this.expenses_updatebtn.Size = new System.Drawing.Size(82, 36);
            this.expenses_updatebtn.TabIndex = 12;
            this.expenses_updatebtn.Text = "Update";
            this.expenses_updatebtn.UseVisualStyleBackColor = false;
            this.expenses_updatebtn.Click += new System.EventHandler(this.expenses_updatebtn_Click);
            // 
            // expenses_addbtn
            // 
            this.expenses_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.expenses_addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expenses_addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.expenses_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses_addbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_addbtn.ForeColor = System.Drawing.Color.White;
            this.expenses_addbtn.Location = new System.Drawing.Point(53, 197);
            this.expenses_addbtn.Name = "expenses_addbtn";
            this.expenses_addbtn.Size = new System.Drawing.Size(82, 36);
            this.expenses_addbtn.TabIndex = 11;
            this.expenses_addbtn.Text = "Add";
            this.expenses_addbtn.UseVisualStyleBackColor = false;
            this.expenses_addbtn.Click += new System.EventHandler(this.expenses_addbtn_Click);
            // 
            // expenses_date_box
            // 
            this.expenses_date_box.Location = new System.Drawing.Point(438, 119);
            this.expenses_date_box.Name = "expenses_date_box";
            this.expenses_date_box.Size = new System.Drawing.Size(240, 20);
            this.expenses_date_box.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(388, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expenses List";
            // 
            // expenses_desc_textbox
            // 
            this.expenses_desc_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_desc_textbox.Location = new System.Drawing.Point(433, 31);
            this.expenses_desc_textbox.Multiline = true;
            this.expenses_desc_textbox.Name = "expenses_desc_textbox";
            this.expenses_desc_textbox.Size = new System.Drawing.Size(245, 63);
            this.expenses_desc_textbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(351, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description:";
            // 
            // expenses_cost_textbox
            // 
            this.expenses_cost_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_cost_textbox.Location = new System.Drawing.Point(85, 118);
            this.expenses_cost_textbox.Name = "expenses_cost_textbox";
            this.expenses_cost_textbox.Size = new System.Drawing.Size(133, 22);
            this.expenses_cost_textbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cost:";
            // 
            // expenses_item_textbox
            // 
            this.expenses_item_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_item_textbox.Location = new System.Drawing.Point(85, 72);
            this.expenses_item_textbox.Name = "expenses_item_textbox";
            this.expenses_item_textbox.Size = new System.Drawing.Size(133, 22);
            this.expenses_item_textbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item:";
            // 
            // expenses_category_combox
            // 
            this.expenses_category_combox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_category_combox.FormattingEnabled = true;
            this.expenses_category_combox.Location = new System.Drawing.Point(85, 23);
            this.expenses_category_combox.Name = "expenses_category_combox";
            this.expenses_category_combox.Size = new System.Drawing.Size(133, 24);
            this.expenses_category_combox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.expenses_clearbtn);
            this.panel2.Controls.Add(this.expenses_deletebtn);
            this.panel2.Controls.Add(this.expenses_updatebtn);
            this.panel2.Controls.Add(this.expenses_addbtn);
            this.panel2.Controls.Add(this.expenses_date_box);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.expenses_desc_textbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.expenses_cost_textbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.expenses_item_textbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.expenses_category_combox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(25, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 255);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(25, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 265);
            this.panel1.TabIndex = 13;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExpensesForm";
            this.Size = new System.Drawing.Size(845, 587);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.Button expenses_clearbtn;
        private System.Windows.Forms.Button expenses_deletebtn;
        private System.Windows.Forms.Button expenses_updatebtn;
        private System.Windows.Forms.Button expenses_addbtn;
        private System.Windows.Forms.DateTimePicker expenses_date_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expenses_desc_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox expenses_cost_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expenses_item_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox expenses_category_combox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
