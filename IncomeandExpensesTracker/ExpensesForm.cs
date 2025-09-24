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
    public partial class ExpensesForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Desktop\IncomeandExpensesTracker\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public ExpensesForm()
        {
            InitializeComponent();

            displayCategoryList();
            displayExpensesData();

        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategoryList();
            displayExpensesData();

        }

        public void displayExpensesData()
        {
            ExpensesData eData = new ExpensesData();
            List<ExpensesData> listData = eData.expensesListData();

            dataGridView11.DataSource = listData;
        }

        public void displayCategoryList()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status=@status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Expenses");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    expenses_category_combox.Items.Clear();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        expenses_category_combox.Items.Add(reader["category"].ToString());
                    }
                }
                connect.Close();
            }
        }

        private void expenses_addbtn_Click(object sender, EventArgs e)
        {
            if (expenses_category_combox.SelectedIndex == -1 || expenses_item_textbox.Text == ""
               || expenses_cost_textbox.Text == "" || expenses_desc_textbox.Text == "")
            {
                MessageBox.Show("Please fill all blanks fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO expenses (category,item,cost,description,date_expense,date_insert)" +
                        "VALUES(@cat,@item,@cost,@desc,@date_ex,@date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", expenses_category_combox.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", expenses_item_textbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@cost", expenses_cost_textbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@desc", expenses_desc_textbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_ex", expenses_date_box.Value);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added Successfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    connect.Close();
                }
            }
            displayExpensesData();

        }
        public void clearFields()
        {
            expenses_item_textbox.Text = "";
            expenses_category_combox.SelectedIndex = -1;
            expenses_cost_textbox.Text = "";
            expenses_desc_textbox.Text = "";
        }

        private void expenses_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void expenses_updatebtn_Click(object sender, EventArgs e)
        {
            if (expenses_category_combox.SelectedIndex == -1 || expenses_item_textbox.Text == ""
                || expenses_cost_textbox.Text == "" || expenses_desc_textbox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("Are you sure you want Update ID:" + getID + "?", "confirmation  Message"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE  expense SET category= @cat , item =@item" +
                            ",income=@income,description=@desc,date_income=@date_in WHERE id=@id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", expenses_category_combox.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", expenses_item_textbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@cost", expenses_cost_textbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@desc", expenses_desc_textbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@date_ex", expenses_date_box.Value);
                            cmd.Parameters.AddWithValue("@id", getID);


                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated Successfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        connect.Close();
                    }
                }
            }
                 displayExpensesData();
        }
       

        private void expenses_deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want Deleted ID:" + getID + "?", "confirmation  Message"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string deleteData = "DELETE FROM expenses WHERE id=@id";

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
            displayExpensesData();
        }


        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView11.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                expenses_category_combox.SelectedItem = row.Cells[1].Value.ToString();
                expenses_item_textbox.Text = row.Cells[2].Value.ToString();
                expenses_cost_textbox.Text = row.Cells[3].Value.ToString();
                expenses_desc_textbox.Text = row.Cells[4].Value.ToString();
                expenses_date_box.Value = Convert.ToDateTime(row.Cells[5].Value);

            }
        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView11.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                expenses_category_combox.SelectedItem = row.Cells[1].Value.ToString();
                expenses_item_textbox.Text = row.Cells[2].Value.ToString();
                expenses_cost_textbox.Text = row.Cells[3].Value.ToString();
                expenses_desc_textbox.Text = row.Cells[4].Value.ToString();
                expenses_date_box.Value = Convert.ToDateTime(row.Cells[5].Value);

            }
        }
    }
}
