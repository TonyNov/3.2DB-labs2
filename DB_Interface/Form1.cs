using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_Interface
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			string connStr = "server=localhost;user=root;database=mydb;password=root;";
			MySqlConnection conn = new MySqlConnection(connStr);
			conn.Open();
			string sql = "SELECT * FROM магазины";
			MySqlCommand command = new MySqlCommand(sql, conn);
			string name = command.ExecuteScalar().ToString();
			this.Text = name;
			conn.Close();
		}
	}
}
