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
            BdConnection.GetData(pharmacyStorage,"city");
            BdConnection.GetData(statistics, "country");
            BdConnection.GetData(supplierGoods, "countrylanguage");
        }

        private void buttonResetDays_Click(object sender, EventArgs e)
        {
            currentDay = 0;
            daysCount.Text = $"Дней прошло: {currentDay}";
        }

        private void buttonNextDay_Click(object sender, EventArgs e)
        {
            currentDay++;
            daysCount.Text = $"Дней прошло: {currentDay}";
        }
//пока делает хрень, но потом будет нужна для регулировки таблицы
        private void pharmacyStorage_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            daysCount.Text = $"Дней прошло: {100}";
        }
    }
}
