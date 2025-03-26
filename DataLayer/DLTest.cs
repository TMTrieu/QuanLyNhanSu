using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DLTest
    {


        public DataTable tbTest()
        {
            /*string sql = " SELECT COUNT (Username) from Users where UserName = '" + U + "' and Password='" + P + "'";
        string cnStr = "Data Source=TRIEU-TRAN;Initial Catalog=CoffeeShop;Integrated Security=True;";

        SqlConnection cn = new SqlConnection(cnStr);
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.CommandType = CommandType.Text;
     
            cn.Open();
        var result = (int)cmd.ExecuteScalar();
        cn.Close();
        return (result > 0);*/
            //string cnStr = "Data Source=.;Initial Catalog=CoffeeShop;Integrated Security=True";
        string cnStr = "Data Source=.;Initial Catalog=\"Quan Ly Nhan Su\";Integrated Security=True";
        SqlConnection db = new SqlConnection(cnStr);

        DataTable dt = new DataTable();

        SqlCommand cmd = new SqlCommand("select * from dbo.DANTOC", db);


        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        adapter.Fill(dt);       
            return dt;
        }
    }
}
