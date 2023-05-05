using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        byte k, i, n;
        string[,] a = new string[3, 3];

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a[n, i] = "Продавать";
            }
            else if (radioButton2.Checked)
            {
                a[n, i] = "Ждать";
            }
            else if (radioButton3.Checked)
            {
                a[n, i] = "Покупать";
            }

            k++;
            if (k == 9)
            {
                label5.Text = "Все ситуации изучены";
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;
            k = 0;
            n = 0;
            for (int m = 0; m < 3; m++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[m, j] = "0";
                }
            }
        }
    

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                n = (byte)new Random().Next(3);
                i = (byte)new Random().Next(3);
                switch (n)
                {
                    case 0:
                        label2.ForeColor = System.Drawing.Color.Red;
                        label2.Text = "Падает";
                        break;
                    case 1:
                        label2.ForeColor = System.Drawing.Color.Yellow;
                        label2.Text = "Стабильна";
                        break;
                    case 2:
                        label2.ForeColor = System.Drawing.Color.Green;
                        label2.Text = "Растёт";
                        break;
                }
                switch (i)
                {
                    case 0:
                        label4.ForeColor = System.Drawing.Color.Red;
                        label4.Text = "Падает";
                        break;
                    case 1:
                        label4.ForeColor = System.Drawing.Color.Yellow;
                        label4.Text = "Стабилен";
                        break;
                    case 2:
                        label4.ForeColor = System.Drawing.Color.Green;
                        label4.Text = "Растёт";
                        break;
                }
                if (a[n, i] == "0")
                {
                    label5.Text = "Выберите действие";
                    timer1.Enabled = false;
                }
                else
                {
                    label5.Text = a[n, i];
                }
            }
        }
    }
}
