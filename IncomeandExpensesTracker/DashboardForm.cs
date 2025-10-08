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
    public partial class DashboardForm : UserControl
    {
        public DashboardForm()
        {
            InitializeComponent();
           
            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();
            incomeTotalIncome();
            expensesTodayExpenses();
            expensesYesterdayExpenses();
            expenseThisMonth();
            expenseThisYear();
            expenseTotalYear();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();
            incomeTotalIncome();
            expensesTodayExpenses();
            expensesYesterdayExpenses();
            expenseThisMonth();
            expenseThisYear();
            expenseTotalYear();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        //Income
        public void incomeTodayIncome()
        {
            using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE date_income = @date_in";

                using(SqlCommand cmd = new SqlCommand(query,connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);
                        income_todaysincome.Text = todayCost.ToString("C");
                    }
                    else
                    {
                        income_todaysincome.Text = "0.00";
                    }
                }
            }
        }
        
        public void incomeYesterdayIncome()
        {
            using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE,date_income)=DATEADD(day,DATEDIFF(day,0,GETDATE()),-1)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);
                        income_yesterdaysincome.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        income_yesterdaysincome.Text = "0.00";
                    }
                }
            }
        }

        public void incomeThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >=@startMonth AND date_income <= @endMonth";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);
                        income_thismonthincome.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        income_thismonthincome.Text = "0.00";
                    }
                }
            }
        }

        public void incomeThisYear()
        {
            using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startyear = new DateTime(today.Year, 1, 1);
                DateTime endyear = startyear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >=@startyear AND date_income <= @endyear";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startyear", startyear);
                    cmd.Parameters.AddWithValue("@endyear", endyear);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);
                        income_thisyearincome.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        income_thisyearincome.Text = "0.00";
                    }
                }
            }
        }

        public void incomeTotalIncome()
        {
            using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);
                        income_totalincome.Text = totalCost.ToString("C");
                    }
                    else
                    {
                        income_totalincome.Text = "0.00";
                    }
                }
            }
        }

        // expenses
        public void expensesTodayExpenses()
        {
            using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense = @date_ex";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_ex", today);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);
                        expenses_todayexpenses.Text = todayCost.ToString("C");
                    }
                    else
                    {
                        expenses_todayexpenses.Text = "0.00";
                    }
                }
            }
        }
        
        public void expensesYesterdayExpenses()
        {
            using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses WHERE CONVERT(DATE,date_expense)=DATEADD(day,DATEDIFF(day,0,GETDATE()),-1)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);
                        expenses_yesterdaysexpenses.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        expenses_yesterdaysexpenses.Text = "0.00";
                    }
                }
            }
        }

        public void expenseThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >=@startMonth AND date_expense <= @endMonth";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);
                        expenses_thismonthexpenses.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        expenses_thismonthexpenses.Text = "0.00";
                    }
                }
            }
        }

        public void expenseThisYear()
        {
            using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startyear = new DateTime(today.Year, 1, 1);
                DateTime endyear = startyear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >=@startyear AND date_expense <= @endyear";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startyear", startyear);
                    cmd.Parameters.AddWithValue("@endyear", endyear);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);
                        expenses_thisyearexpenses.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        expenses_thisyearexpenses.Text = "0.00";
                    }
                }
            }
        }

        public void expenseTotalYear()
        {
            using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);
                        expenses_totalexpense.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        expenses_totalexpense.Text = "0.00";
                    }
                }
            }
        }

        private void income_yesterdaysincome_Click(object sender, EventArgs e)
        {

        }
    }
}
