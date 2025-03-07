using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Interface
{
    class DB
    {
      MySqlConnection connection=new MySqlConnection("server=localhost;user=root;database=mydb;password=root;");
    }
}
