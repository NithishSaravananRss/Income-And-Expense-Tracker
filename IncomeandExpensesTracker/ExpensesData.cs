using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeandExpensesTracker
{
    class ExpensesData
    {
        public int ID { set; get; }
        public string Category { set; get; }
        public string Item { set; get; }
        public string Cost { set; get; }
        public string Description { set; get; }
        public string DateExpense { set; get; }
        
        public List<ExpensesData> expensesListData()
        {
            List<ExpensesData> listdata = new List<ExpensesData>();

            using (SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();
                string selectData = "SELECT * FROM expenses";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ExpensesData eData = new ExpensesData();
                        eData.ID = (int)reader["id"];
                        eData.Category = reader["category"].ToString();
                        eData.Item = reader["item"].ToString();
                        eData.Cost = reader["cost"].ToString();
                        eData.Description = reader["description"].ToString();
                        eData.DateExpense = ((DateTime)reader["date_expense"]).ToString("dd-MM-yyyy");

                        listdata.Add(eData);
                    }
                }
            }
            return listdata;
        }
    }
}
