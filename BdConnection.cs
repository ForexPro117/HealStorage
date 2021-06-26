﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealStorage
{
    //Здесь получаем данные из бд
    class BdConnection
    {
        public static void GetData(DataGridView dataGrid,string tableName)
        {
            string conectUrl = "server=localhost;user=root;database=bd;password=";
            MySqlConnection conn = new MySqlConnection(conectUrl);
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter($"SELECT * from {tableName}", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGrid.DataSource = table;

            }
            catch (Exception e)
            {

                MessageBox.Show("Что-то пошло не так", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
    }
}
