using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //срабатывают единожды при запуске
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] s = new double[3] { 0, 0, 0 };
            double[] p = new double[3];
            double[,] a = new double[3, 3];
            string[,] b = new string[3, 3];
            byte i, j, k = 0, l = 0;

            if (radioButton1.Checked)
            {
                s[0] = 5; s[2] = 2.5;
            }
            if (radioButton2.Checked) s[1] = 10;
            if (radioButton3.Checked) s[0] += 10;
            if (radioButton4.Checked) s[1] += 5;
            if (radioButton5.Checked)
            {
                s[1] += 2.5; s[2] += 5;
            }
            if (radioButton6.Checked)
            {
                s[0] += 2.5; s[2] += 10;
            }
            if (radioButton7.Checked) s[0] += 5;
            if (radioButton8.Checked) s[2] += 5;
            if (radioButton9.Checked)
            {
                s[1] += 5; s[2] += 2.5;
            }
            if (radioButton10.Checked) s[0] += 2.5;
            if (radioButton11.Checked) s[1] += 2.5;

            double ss = s.Sum();
            for (i = 0; i < 3; i++)
            {
                p[i] = s[i] / ss * 100;
                s[i] = 0;
            }

            if (radioButton12.Checked) s[0] = 6;
            if (radioButton13.Checked) s[0] += 7;
            if (radioButton14.Checked) s[0] += 4;
            if (radioButton15.Checked) s[0] += 3;
            if (radioButton16.Checked) s[1] = 7;
            if (radioButton17.Checked) s[1] += 3;
            if (radioButton18.Checked) s[1] += 6;
            if (radioButton19.Checked) s[1] += 4;
            if (radioButton20.Checked) s[2] = 7;
            if (radioButton21.Checked) s[2] += 6;
            if (radioButton22.Checked) s[2] += 4;
            if (radioButton23.Checked) s[2] += 3;
            if (radioButton24.Checked) s[0] = 6;
            if (radioButton25.Checked) s[0] += 7;
            if (radioButton26.Checked) s[0] += 4;
            if (radioButton27.Checked) s[0] += 3;
            if (radioButton28.Checked) s[1] = 7;
            if (radioButton29.Checked) s[1] += 3;
            if (radioButton30.Checked) s[1] += 6;
            if (radioButton31.Checked) s[1] += 4;
            if (radioButton32.Checked) s[2] = 7;
            if (radioButton33.Checked) s[2] += 6;
            if (radioButton34.Checked) s[2] += 4;
            if (radioButton35.Checked) s[2] += 3;
            if (radioButton36.Checked) s[1] += 6;
            if (radioButton37.Checked) s[1] += 4;
            if (radioButton38.Checked) s[2] = 7;
            if (radioButton39.Checked) s[2] += 6;
            if (radioButton40.Checked) s[2] += 4;
            if (radioButton41.Checked) s[2] += 3;
            if (radioButton42.Checked) s[2] += 6;
            if (radioButton43.Checked) s[2] += 4;
            if (radioButton44.Checked) s[2] += 3;
            if (radioButton49.Checked) s[2] += 4;
            if (radioButton50.Checked) s[2] += 3;

            ss = s.Sum();
            for (i = 0; i < 3; i++)
            {
                s[i] = s[i] / ss * 100;
            }

            double max = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    a[i, j] = s[i] * p[j] / 100;
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                        k = i;
                        l = j;
                    }
                }
            }

            b[0, 0] = "Результат средний. взаимное соперничество";
            b[0, 1] = "Результат низкий. Продавец не может убедить покупателя";
            b[0, 2] = "Результат средний. Покупатель не доверяет продавцу";
            b[1, 0] = "Результат высокий. Продавец \"задавит\" покупателя";
            b[1, 1] = "Результат средний. Стороны не могут найти общий язык";
            b[1, 2] = "Результат средний. Продавец не может понять покупателя";
            b[2, 0] = "Результат средний. Покупатель получает информацию";
            b[2, 1] = "Результат низкий. Покупатель не получает ответы на вопросы";
            b[2, 2] = "Результат высокий. Взаимное уважение, четкое понимание цели";
            label1.Text = b[k, l] + "/ Вероятность сделки=" + Math.Round(max).ToString() + "%";
        }

        private void button2_Click(object sender, EventArgs e) //выход из ПО
        {
            Application.Exit();
        }

    }
}
