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
			// создаём объект для подключения к БД
			MySqlConnection conn = new MySqlConnection(connStr);
			// устанавливаем соединение с БД
			conn.Open();
			// запрос
			string sql = "SELECT * FROM магазины";
			// объект для выполнения SQL-запроса
			MySqlCommand command = new MySqlCommand(sql, conn);
			// выполняем запрос и получаем ответ
			string name = command.ExecuteScalar().ToString();
			// выводим ответ в консоль
			Console.WriteLine(name);
			// закрываем соединение с БД
			conn.Close();
		}
	}
}
