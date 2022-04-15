using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Закрыть программу
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Очистить все поля
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblOper.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txtResult.Text = "";
        }

        // Сумма двух чисел
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double i1, i2, i3;
            lblOper.Text = "Сложение";
            i1 = Convert.ToDouble(txt1.Text);
            i2 = Convert.ToDouble(txt2.Text);
            i3 = i1 + i2;
            txtResult.Text = Convert.ToString(i3);
        }

        // Разность двух чисел
        private void btnSub_Click(object sender, EventArgs e)
        {
            double i1, i2, i3;
            lblOper.Text = "Вычитание";
            i1 = Convert.ToDouble(txt1.Text);
            i2 = Convert.ToDouble(txt2.Text);
            i3 = i1 - i2;
            txtResult.Text = Convert.ToString(i3);
        }

        // Произведение двух чисел
        private void btnMult_Click(object sender, EventArgs e)
        {
            double i1, i2, i3;
            lblOper.Text = "Умножение";
            i1 = Convert.ToDouble(txt1.Text);
            i2 = Convert.ToDouble(txt2.Text);
            i3 = i1 * i2;
            txtResult.Text = Convert.ToString(i3);
        }

        // Частное двух чисел (без деления на 0)
        private void btnDiv_Click(object sender, EventArgs e)
        {
            double i1, i2, i3;
            lblOper.Text = "Деление";
            i1 = Convert.ToDouble(txt1.Text);
            i2 = Convert.ToDouble(txt2.Text);
            if (i2 == 0)
            {
                txtResult.Text = "Ошибка!";
            }
            else
            {
                i3 = i1 / i2;
                txtResult.Text = Convert.ToString(i3);
            }
        }

    }
}
