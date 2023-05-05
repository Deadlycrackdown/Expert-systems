using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e) //Код сначала инициализирует три переменные — d, m и n равными 0. 
        {
            richTextBox1.Clear(); //очистка текстбокса
            double d = 0, m = 0, n = 0;
            switch (radioButton1.Checked) //Затем он использует серию операторов switch, чтобы проверить, какие переключатели выбраны для каждой роли. 
            {
                case true:
                    d += 1;
                    break;
                default:
                    break;
            }
            switch (radioButton2.Checked) //Если выбран переключатель, соответствующая переменная увеличивается на 1.
            {
                case true:
                    d += 1;
                    break;
                default:
                    break;
            }
            switch (radioButton3.Checked)
            {
                case true:
                    m += 1;
                    break;
                default:
                    break;
            }
            switch (radioButton4.Checked)
            {
                case true:
                    m += 1;
                    break;
                default:
                    break;
            }
            switch (radioButton5.Checked)
            {
                case true:
                    n += 1;
                    break;
                default:
                    break;
            }
            switch (radioButton6.Checked)
            {
                case true:
                    n += 1;
                    break;
                default:
                    break;
            }
            switch (radioButton7.Checked)
            {
                case true:
                    d += 1;
                    break;
                default:
                    break;
            }
            switch (radioButton8.Checked)
            {
                case true:
                    m += 1;
                    break;
                default:
                    break;
            }
            switch (radioButton9.Checked)
            {
                case true:
                    n += 1;
                    break;
                default:
                    break;
            }
            switch (radioButton10.Checked)
            {
                case true:
                    m += 1;
                    break;
                default:
                    break;
            }
            //Затем код вычисляет процент выбранных переключателей для каждой роли путем деления количества выбранных переключателей на общее количество переключателей и умножения на 100.
            d = d / 10 * 100;
            m = m / 10 * 100;
            n = n / 10 * 100;
            richTextBox1.AppendText("делопроизводитель - " + d.ToString() + "%" + Environment.NewLine); //Код добавляет результаты в РИЧБОКС с помощью метода AppendText
            richTextBox1.AppendText("менеджер - " + m.ToString() + "%" + Environment.NewLine);         
            richTextBox1.AppendText("начальник - " + n.ToString() + "%" + Environment.NewLine);
        }


        private void button2_Click(object sender, EventArgs e) //А это просто выход
        {
            Application.Exit();
        }
    } //в принципе код схож с кодом, который был написан на Delphi, не требуется упрощать и т.д. В принципе код понятен.
}
