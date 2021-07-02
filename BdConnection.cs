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
        public static void GetData(DataGridView dataGrid, string tableName)
        {
            //Имя Базы данных - bd, пороля нет(в моем случае)
            string conectUrl = "server=localhost;user id=root;database=bd;allowuservariables=True;persistsecurityinfo=True";
            MySqlConnection conn = new MySqlConnection(conectUrl);
            try
            {
                conn.Open();
                //Реализация запросов к бд
                MySqlDataAdapter adapter = new MySqlDataAdapter($"SELECT * from {tableName}", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGrid.DataSource = table;

            }
            catch (Exception e)
            {

                MessageBox.Show("Что-то пошло не так", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
        public static void GetDataSQL(DataGridView dataGrid, string sqlQerry)
        {
            string conectUrl = "server=localhost;user=root;database=bd;password=";
            MySqlConnection conn = new MySqlConnection(conectUrl);
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQerry, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGrid.DataSource = table;
                var a = table.Rows;
                var c = table.Columns;
                var b = a;

            }
            catch (Exception e)
            {

                MessageBox.Show("Что-то пошло не так", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
        public static void SetStartupParams()
        {
            string conectUrl = "server=localhost;user=root;database=bd;password=";
            MySqlConnection conn = new MySqlConnection(conectUrl);
            try
            {
                conn.Open();
                var cmd = new MySqlCommand("update pharmitem set ExpirationDate = date_add(NOW(), interval round(rand() * (10 - 2) + 2) day)", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                MessageBox.Show("Что-то пошло не так", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
