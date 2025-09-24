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
    public partial class RigsterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Desktop\IncomeandExpensesTracker\expense.mdf;Integrated Security=True;Connect Timeout=30");
        public RigsterForm()
        {
            InitializeComponent();
        }

        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (signup_usertextbox.Text == "" || signup_pwdtextbox.Text == "" || signup_conpwd_textbox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        // check if the username you want to register is already exist
                        string selectUsername = "SELECT * FROM users WHERE username = @usern";
                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", signup_usertextbox.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                string tempUsern = signup_usertextbox.Text.Substring(0, 1).ToUpper() + signup_usertextbox.Text.Substring(1);
                                MessageBox.Show(tempUsern + "is exsting already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (signup_pwdtextbox.Text.Length < 4)
                            {
                                MessageBox.Show("Invalid password , at least 4 Characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (signup_pwdtextbox.Text != signup_conpwd_textbox.Text)
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username,password,date_create) VALUES (@usern,@pass,@date)";

                                using (SqlCommand insertuser = new SqlCommand(insertData, connect))
                                {
                                    insertuser.Parameters.AddWithValue("@usern", signup_usertextbox.Text.Trim());
                                    insertuser.Parameters.AddWithValue("@pass", signup_pwdtextbox.Text.Trim());


                                    DateTime today = DateTime.Today; // to getnow date
                                    insertuser.Parameters.AddWithValue("@date", today);

                                    insertuser.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully !!...", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();

                                    this.Hide();


                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection : ex" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void login_showcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            signup_pwdtextbox.PasswordChar = signup_showcheckbox.Checked ? '\0' : '*';
            signup_conpwd_textbox.PasswordChar = signup_showcheckbox.Checked ? '\0' : '*';

        }

        private void login_pwdtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }
    }
}
