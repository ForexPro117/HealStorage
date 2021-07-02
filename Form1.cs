using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealStorage
{
    public partial class Form1 : Form
    {
        private static int currentDay = 0;

        public Form1()
        {
            InitializeComponent();
            try
            {
                BdConnection.GetDataSQL(pharmacyStorage,
                "select Product as `Продукт`," +
                "round(RAND()*(200)) as 'Цена за единицу'," +
                "count(Product) as 'шт',min(ExpirationDate)" +
                "  as 'Срок годности' from pharmitem group by Product");
                BdConnection.GetData(statistics, "pharmitem");
                BdConnection.GetData(supplierGoods, "supplieritem");
                BdConnection.GetData(itemInfo, "products");
            }
            catch (Exception)
            {

            }


        }

        private void buttonResetDays_Click(object sender, EventArgs e)
        {
            currentDay = 0;
            daysCount.Text = $"Дней прошло: {currentDay}";
        }

        private void buttonNextDay_Click(object sender, EventArgs e)
        {
            if (dayTimeInfo.Text=="Конец дня")
            {
                currentDay++;
                daysCount.Text = $"Дней прошло: {currentDay}";

                dayTimeInfo.Text = "Начало дня";
            }
            else
            {


                dayTimeInfo.Text = "Конец дня";
            }
        }

        private void tableUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                BdConnection.GetDataSQL(pharmacyStorage,
                "select Product as `Продукт`," +
                "round(RAND()*(200)) as 'Цена за единицу'," +
                "count(Product) as 'шт',min(ExpirationDate)" +
                "  as 'Срок годности' from pharmitem group by Product");
                BdConnection.GetData(statistics, "pharmitem");
                BdConnection.GetData(supplierGoods, "supplieritem");
                BdConnection.GetData(itemInfo, "products");
            }
            catch (Exception)
            {

            }
        }
    }
}
