using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DB
    {
        //String cnStr = "Data Source=.;Initial Catalog=\"Quan Ly Nhan Su\";Integrated Security=True";
       private string cnStr = "Data Source=.;Initial Catalog=CoffeeShop;Integrated Security=True";
       SqlConnection cn ;
       public DB()
        {
            cn= new SqlConnection(cnStr);
        }
    }
}
