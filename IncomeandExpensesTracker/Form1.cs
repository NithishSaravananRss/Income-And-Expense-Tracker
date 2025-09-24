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
    public partial class Form1 : Form
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Desktop\IncomeandExpensesTracker\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            RigsterForm regForm = new RigsterForm();
            regForm.Show();

            this.Hide();
        }


        private void login_showcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            login_pwdtextbox.PasswordChar = login_showcheckbox.Checked ? '\0' : '*';
        }

        public static string username;

        private void login_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", login_usertextbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", login_pwdtextbox.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        username = login_usertextbox.Text;

                        MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainForm mForm = new MainForm();
                        mForm.Show();


                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username / password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
