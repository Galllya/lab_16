using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            money.ru = (int)numericUpDown1.Value;
            money.dol = (int)numericUpDown2.Value;
            comboBox1.SelectedItem = "Продать";
        }

        Money money = new Money();
        


        private void btStart_Click(object sender, EventArgs e)
        {
           
            money.rate = (double)edRate.Value;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, money.rate);

            money.how_m = (double)how_many.Value;
            money.combo = comboBox1.SelectedItem.ToString();
            money.update();

            label5.Text = "У вас " + money.ru.ToString() + " ₽";
            label4.Text = "У вас " + money.dol.ToString() + " $";


            
            chart1.Series[0].Points.AddXY(money.i, money.rate);
            money.i++;
            money.rate = Math.Round(money.rate, 0);
            money.rate = (int)money.rate;
        }


    }
}
