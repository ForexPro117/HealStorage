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

        internal static void supplyingItem()
        {
            var tableTime = BdConnection.GetDataInTable("SELECT min(ExpirationDate) FROM pharmitem")
                  .Rows[0].ItemArray[0].ToString();
            string today = (DateTime.Today).AddDays(Form1.currentDay).ToString();

            if (today == tableTime)//если на складе есть товар с истекающим сроком годности удаляем его
            {
                today = (DateTime.Today).AddDays(Form1.currentDay).ToString("yyyy-MM-dd");
                BdConnection.ExecuteScript($"DELETE FROM pharmitem WHERE ExpirationDate='{today}'");
            }
            var itemCountTable = BdConnection.GetDataInTable("select Product as `Продукт`," +
                "count(Product) as 'Количество'from pharmitem group by Product");

            foreach (var row in itemCountTable.Rows)//получение ко-во ост товаров на складе одного названия
            {
                var itemCount = Convert.ToInt32((row as DataRow).ItemArray[1]);
                if (itemCount < 15)//надо добавить товар от поставщика к складу по выгодной цене
                {
                    var supItemTable = BdConnection.GetDataInTable("SELECT * FROM supplieritem");
                    int goodPrice = int.MaxValue;
                    int id = 0;
                    foreach (var product in supItemTable.Rows)
                    {
                        var prod = product as DataRow;
                        if (prod.ItemArray[3] == prod.ItemArray[0])
                            if (Convert.ToInt32(prod.ItemArray[4]) * (50 - itemCount) + Convert.ToInt32(prod.ItemArray[5]) < goodPrice)
                            {
                                id = Convert.ToInt32(prod.ItemArray[0]);
                                goodPrice = Convert.ToInt32(prod.ItemArray[4]) * (50 - itemCount) + Convert.ToInt32(prod.ItemArray[5]);
                            }
                    }
                }
                for (int i = 0; i < 50-itemCount; i++)
                {

                }
            }
        }
    }
}
