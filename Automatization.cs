using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealStorage
{
    class Automatization
    {
        public static Dictionary<string, int> item;
        public static void BuyItemCustomer(DataTable sourceTable, RichTextBox textBox)
        {
            textBox.Text = "Cегодня купили:\n\n";
            Random rd = new Random();
            item= new Dictionary<string, int>();
            for (int i = 0; i < sourceTable.Rows.Count; i++)
            {
                if (rd.Next(100) > 90)
                {
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
    }
}
