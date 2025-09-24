using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IncomeandExpensesTracker
{

    public partial class IncomeForm : UserControl
    {

        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Desktop\IncomeandExpensesTracker\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public IncomeForm()
        {
            InitializeComponent();

            displayCategoryList();
            displayIncomeData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategoryList();
            displayIncomeData();

        }

        public void displayIncomeData()
        {
            IncomeData iData = new IncomeData();
            List<IncomeData> listData = iData.incomeListData();

            dataGridView1.DataSource = listData;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void displayCategoryList()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status=@status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Income");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    Income_category_combox.Items.Clear();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Income_category_combox.Items.Add(reader["category"].ToString());
                    }
                }
                connect.Close();
            }
        }

        private void income_addbtn_Click(object sender, EventArgs e)
        {
            if (Income_category_combox.SelectedIndex == -1 || income_item_textbox.Text == ""
                || income_income_textbox.Text == "" || income_desc_textbox.Text == "")
            {
                MessageBox.Show("Please fill all blanks fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO income (category,item,income,description,date_income,date_insert)" +
                        "VALUES(@cat,@item,@income,@desc,@date_in,@date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", Income_category_combox.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", income_item_textbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@income", income_income_textbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@desc", income_desc_textbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_in", income_date_box.Value);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added Successfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    connect.Close();
                }
            }
            displayIncomeData();
        }


        public void clearFields()
        {
            income_item_textbox.Text = "";
            Income_category_combox.SelectedIndex = -1;
            income_income_textbox.Text = "";
            income_desc_textbox.Text = "";
        }
        private void income_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void income_updatebtn_Click(object sender, EventArgs e)
        {

            if (Income_category_combox.SelectedIndex == -1 || income_item_textbox.Text == ""
                || income_income_textbox.Text == "" || income_desc_textbox.Text == "")
            {
                MessageBox.Show("Please select category first ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure you want Update ID:"+getID+"?","confirmation  Message"
                    ,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE  income SET category=@cat,item=@item,income=@income,description=@desc,date_income=@date_in WHERE id=@id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", Income_category_combox.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", income_item_textbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@income", income_income_textbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@desc", income_desc_textbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@date_in", income_date_box.Value);
                            cmd.Parameters.AddWithValue("@id", getID);


                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated Successfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        connect.Close();
                    }
                }
            }
            displayIncomeData();
        }

        private int getID = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                Income_category_combox.SelectedItem = row.Cells[1].Value.ToString();
                income_item_textbox.Text = row.Cells[2].Value.ToString();
                income_income_textbox.Text = row.Cells[3].Value.ToString();
                income_desc_textbox.Text = row.Cells[4].Value.ToString();
                income_date_box.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
        }

        private void income_deletebtn_Click(object sender, EventArgs e)
        {
            if (Income_category_combox.SelectedIndex == -1 || income_item_textbox.Text == ""
               || income_income_textbox.Text == "" || income_desc_textbox.Text == "")
            {
                MessageBox.Show("Please select category first ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want Delete ID:" + getID + "?", "confirmation  Message"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM income WHERE id=@id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);


                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted Successfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        connect.Close();
                    }
                }
            }
            displayIncomeData();
        }
    }
}