
using System;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        private string position = "Отказать";
        private bool quality = false;
        private readonly string[] questions =
        {
            "У вас есть научное звание? (Yes/No)",
            "У вас есть научные открытия? (Yes/No)",
            "Средний балл в учебе? (число между 0 и 5)",
            "Стаж работы по специальности? (Полные года)"
        };
        private readonly double[,] answers = new double[4, 2];
        private int currentQuestion = 0;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Введите \"Yes\" если вы готовы.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentQuestion > 0)
            {
                answers[currentQuestion - 1, 0] = 1;

                if (double.TryParse(textBox1.Text, out double result))
                {
                    answers[currentQuestion - 1, 1] = result;
                }
            }

            if (currentQuestion >= questions.Length)
            {
                label1.Text = "Теперь вы - " + position;
                button1.Enabled = false;
                return;
            }

            switch (currentQuestion)
            {
                case 0:
                    if (textBox1.Text.ToLower() == "yes")
                    {
                        answers[currentQuestion, 0] = 1;
                        quality = true;
                        currentQuestion++;
                        label1.Text = questions[currentQuestion];
                    }
                    else
                    {
                        label1.Text = "Введите \"Yes\" если вы готовы.";
                    }
                    break;
                case 1:
                    if (textBox1.Text.ToLower() == "yes")
                    {
                        answers[currentQuestion, 0] = 1;
                        currentQuestion++;
                        label1.Text = questions[currentQuestion];
                    }
                    else
                    {
                        position = "No";
                        currentQuestion = questions.Length;
                    }
                    break;
                case 2:
                    if (quality && answers[currentQuestion - 1, 1] >= 3.5)
                    {
                        answers[currentQuestion, 0] = 1;
                        position = "Инженер проектировщик";
                        currentQuestion = questions.Length;
                    }
                    else if (quality && answers[currentQuestion - 1, 1] < 3.5 && answers[currentQuestion, 1] > 2)
                    {
                        answers[currentQuestion, 0] = 1;
                        position = "Лаборант";
                        currentQuestion = questions.Length;
                    }
                    else
                    {
                        currentQuestion++;
                        label1.Text = questions[currentQuestion];
                    }
                    break;
                case 3:
                    if (answers[currentQuestion - 1, 0] == 1 && answers[currentQuestion - 1, 1] >= 5)
                    {
                        position = "Старший Научный сотрудник";
                    }
                    else if (answers[currentQuestion - 1, 0] == 1 && answers[currentQuestion - 1, 1] >= 3.5)
                    {
                        position = "Научный сотрудник";
                    }
                    else
                    {
                        position = "No";
                    }
                    label1.Text = "Теперь вы - " + position;
                    button1.Enabled = false;
                    break;
                default:                    break;
            }

            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
