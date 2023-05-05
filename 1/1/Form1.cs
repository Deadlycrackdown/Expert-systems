using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            comboBox1.Items.Add("Мужской"); //выбор пола
            comboBox1.Items.Add("Женский");

            for (int i = 1; i <= 10; i++) //для значения от 1 до 10
            {
                comboBox2.Items.Add(i);
            }

            for (int i = 100; i <= 1000; i += 100) //для значений с промежутком в 100
            {
                comboBox3.Items.Add(i.ToString());
            }


            comboBox4.Items.Add("Нет"); //варианты ответа в комбобокс
            comboBox4.Items.Add("Да");

            comboBox5.Items.Add("Нет");
            comboBox5.Items.Add("Да");

        }
        private void button1_Click(object sender, EventArgs e) //скрипт работы
        {
            byte k = 0; //Объявляет переменные, в т.ч. k (инициализируется равным 0), r, v и x.
            byte r, v;
            double x;
            if (comboBox1.SelectedIndex == 0)
            {
                k = 3; //Проверяет выбранный индекс поля со списком и устанавливает k равным 3, если выбран первый элемент.
            }
            r = Convert.ToByte(textBox3.Text); //Преобразует текст в двух текстовых полях (textBox3 и textBox2) в байты и сохраняет их в r и v соответственно.
            v = Convert.ToByte(textBox2.Text);
            v += (byte)(100 - r); //Добавляет 100 минус r к v и отображает результат в метке (label9).
            label9.Text = "превышение веса=" + v.ToString();
            v /= 10; //Делит v на 10 и устанавливает v равным 0, если оно меньше 0, или 10, если оно больше 10.
            if (v < 0)
            {
                v = 0;
            }
            if (v > 10)
            {
                v = 10;
            }
            k += v; //Складывает выбранные индексы нескольких других выпадающих списков и умножает некоторые из них на 5, а результат добавляет к k.
            k += (byte)comboBox2.SelectedIndex;
            k += (byte)comboBox3.SelectedIndex;
            k += (byte)(5 * comboBox4.SelectedIndex);
            k += (byte)(5 * comboBox5.SelectedIndex);
            x = k / 33.0 * 100.0; //Вычисляет x как деление k на 33,0, умноженное на 100,0.
            if (x <= 33)
            {
                label6.Text = "Низкая вероятность"; //Отображает метку с категорией вероятности на основе значения x, которое может быть "Низкая вероятность" (низкая вероятность), 
            } //"Высокая вероятность" (высокая вероятность) или "Средняя вероятность" (средняя вероятность).
            else if (x >= 66)
            {
                label6.Text = "Высокая вероятность";
            }
            else
            {
                label6.Text = "Средняя вероятность";
            }
            k = (byte)Math.Round(x); //Округляет значение x и добавляет его к метке категории вероятности.
            label6.Text += " " + k.ToString() + "%";
        }


        private void button2_Click(object sender, EventArgs e) //выход
        {
            Application.Exit();
        }
    }
    
}
