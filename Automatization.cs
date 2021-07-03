using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HealStorage
{
    class Automatization
    {
        private static Dictionary<string, int> item;
        internal static void BuyItemCustomer(DataTable sourceTable, RichTextBox textBox)
        {
            textBox.Text = "Cегодня купили:\n\n";
            Random rd = new Random();
            item = new Dictionary<string, int>();
            for (int i = 0; i < sourceTable.Rows.Count; i++)
            {
                if (rd.Next(100) > 70)
                {
                    //добавить удаление из бд
                    var key = sourceTable.Rows[i].ItemArray[1].ToString();
                    if (item.ContainsKey(key))
                    {
                        item[key]++;
                    }
                    else
                    {
                        item.Add(key, 1);
                    }

                }
            }
            var sortedDict = item.Select(item => item).OrderBy(item => item.Key);
            foreach (var text in sortedDict)
            {
                textBox.Text += text.Key + ": " + text.Value + "шт" + "\n";
            }
        }

        internal static void supplyingItem(DataTable sourceTable)
        {
            var tableTime = BdConnection.GetDataInTable("SELECT min(ExpirationDate) FROM pharmitem")
                  .Rows[0].ItemArray[0].ToString();
            string today = (DateTime.Today).AddDays(Form1.currentDay).ToString();

            if (today == tableTime)//если на складе есть товар с истекающим сроком годности
            {
                today= (DateTime.Today).AddDays(Form1.currentDay).ToString("yyyy-MM-dd");
                BdConnection.ExecuteScript($"DELETE FROM pharmitem WHERE ExpirationDate='{today}'");
            }


            //foreach (var row in sourceTable.Rows)//получение ко-во ост товаров на складе данного типа 
            //{
            //    //подсчет оставшегося товара конкретного типа на складе
            //    var productName = (row as DataRow).ItemArray[0].ToString();
            //    int itemInStorage = Convert.ToInt32((row as DataRow).ItemArray[2]);
            //    if (item.TryGetValue(productName, out int itemBuying))
            //    {

            //        itemInStorage = itemInStorage - itemBuying;//кол-во товара на складе после продажи

            //    }
            //}
        }
    }
}
