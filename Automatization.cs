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
        public static void BuyItemCustomer(DataTable sourceTable, RichTextBox textBox)
        {
            Dictionary<string, int> item = new Dictionary<string, int>();
            textBox.Text = "Cегодня купили:\n";
            Random rd = new Random();
            var a = 0;
            for (int i = 0; i < sourceTable.Rows.Count; i++)
            {
                if (rd.Next(100)>80)
                {
                    var key= sourceTable.Rows[i].ItemArray[1].ToString();
                    if (item.ContainsKey(key))
                    {
                        item[key]++;
                    }else
                    {
                        item.Add(key, 1);
                    }

                }
            }
            foreach (var text in item)
            {
                textBox.Text += text.Key+": "+text.Value+"шт" + "\n";
            }
        }
    }
}
