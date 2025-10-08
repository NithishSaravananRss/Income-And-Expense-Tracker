using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeandExpensesTracker
{
    class categoryData
    {
        public int ID { set; get; }//0

        public string Category { set; get; }//1

        public string Type { set; get; }//2

        public string Status { set; get; }//3

        public string Date { set; get; }//4

        public List<categoryData> categoryListData()
        {
            List<categoryData> listData = new List<categoryData>();

            using(SqlConnection connect = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";

                using(SqlCommand cmd = new SqlCommand(selectData,connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        categoryData cData = new categoryData();

                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Type = reader["type"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.Date = ((DateTime)reader["date_insert"]).ToString("dd-MM-yyyy");

                        listData.Add(cData);
                    }
                }
            }
            return listData;
        }
    }
}
