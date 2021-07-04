using System;
using System.Data;
using System.Windows.Forms;

namespace HealStorage
{
    public partial class Form1 : Form
    {
        internal static int currentDay = 0;

        public Form1()
        {
            InitializeComponent();
            BdConnection.SetStartupParams();
            GetDataTable();

        }

        private void GetDataTable()
        {
            try
            {
                BdConnection.GetDataSQL(pharmacyStorage,
                "select Product as `Продукт`," +
                "round(RAND()*(200)) as 'Цена за единицу'," +
                "count(Product) as 'Количество',min(ExpirationDate)" +
                "  as 'Срок годности' from pharmitem group by Product");
                BdConnection.GetDataSQL(statistics, "SELECT ID,Product as 'Продукт'," +
                    "ExpirationDate as 'Срок годности' FROM `pharmitem`");
                BdConnection.GetDataSQL(supplierGoods, "SELECT ID,SupName AS 'Поставщик'," +
                    "ProductID,SupProduct as 'Поставлямый продукт',SupPrice AS 'Цена продукта'," +
                    "DeliveryDistance AS 'Стоймость доставки' FROM `supplieritem`");
                BdConnection.GetDataSQL(itemInfo, "SELECT ID,ProductName as 'Название продукта'," +
                    "Packaging as 'В 1 шт',InThePackage as 'Кол-во в упаковке' FROM `products`");

            }
            catch (Exception)
            {

            }
        }

        private void buttonResetDays_Click(object sender, EventArgs e)
        {
            BdConnection.ExecuteScript(AddTables.tableData);
            GetDataTable();
            richTextBox1.Text = "Симуляция была сброшена";
            dayTimeInfo.Text = "Далее: фаза закупки";
            currentDay = 0;
            daysCount.Text = $"Дней прошло: {currentDay}";
        }

        private void buttonNextDay_Click(object sender, EventArgs e)
        {
            if (dayTimeInfo.Text == "Далее: фаза закупки")//фаза закупки товара
            {
                Automatization.supplyingItem();
                richTextBox1.Text = "Идет закупка товара...";
                currentDay++;
                daysCount.Text = $"Дней прошло: {currentDay}";
                dayTimeInfo.Text = "Далее: фаза продажи";
                GetDataTable();
            }
            else//фаза продажи товара
            {
                Automatization.BuyItemCustomer((DataTable)statistics.DataSource, richTextBox1);
                dayTimeInfo.Text = "Далее: фаза закупки";
                GetDataTable();
            }
        }


        private void tableUpdate_Click(object sender, EventArgs e)
        {
            GetDataTable();
        }
    }
}
