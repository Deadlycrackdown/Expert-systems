using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // добавление типов проблем в комбобокс
            comboBoxProblem.Items.Add("Проблема аппаратного характера");
            comboBoxProblem.Items.Add("Проблема с ПО");
            comboBoxProblem.Items.Add("Проблема с подключением к сети");

            //добавить текст в чекбоксы в проблемы с железом
            string[] hardwareQuestions = new string[] {
         "Компьютер издает какие-то странные звуки?",
         "Есть ли на компьютере предупреждающие лампочки?",
         "Есть ли странные запахи из компьютера?",
         "Есть ли какие-либо незакрепленные или отсоединенные провода или компоненты внутри компьютера?",
         "Компьютер падал или был физически поврежден?",
         "Не подвергался ли компьютер воздействию сильной жары или холода?",
         "Компьютер издает какие-либо звуковые сигналы?",
         "Компьютер отвечает медленно или вообще не отвечает?",
         "Компьютер неожиданно выключается?",
         "Компьютер отображает искаженную графику или цвета?"
    };
            AddQuestionsToCheckBoxes(groupBoxHardware, hardwareQuestions);

            // добавить текст в чекбоксы в проблемы с ПО
            string[] softwareQuestions = new string[] {
         "Обновлено ли программное обеспечение?",
         "Есть ли какие-либо сообщения об ошибках при запуске программного обеспечения?",
         "Вы пробовали перезагрузить компьютер и снова запустить программу?",
         "Вы пробовали запускать программу в режиме совместимости?",
         "Вы пробовали запускать программу от имени администратора?",
         "Программное обеспечение конфликтует с каким-либо другим установленным программным обеспечением?",
         "Программное обеспечение несовместимо с текущей операционной системой?",
         "В программном обеспечении отсутствуют какие-либо необходимые компоненты или файлы?",
         "Программное обеспечение долго загружается или отвечает?",
         "Программное обеспечение часто дает сбой или зависает?"
    };
            AddQuestionsToCheckBoxes(groupBoxSoftware, softwareQuestions);

            // добавить текст в чекбоксы в проблемы с подключением к сети
            string[] connectivityQuestions = new string[] {
         "Модем включен?",
         "Все ли кабели и соединения безопасны?",
         "Вы связались со своим интернет-провайдером?",
         "Вы пробовали перезагрузить модем?",
         "Вы пробовали сбросить настройки роутера?",
         "Вы пробовали подключиться напрямую к модему с помощью кабеля?",
         "Достаточно ли сильный сигнал Wi-Fi?",
         "Могут ли другие устройства подключиться к Wi-Fi?",
         "Верный ли IP-адрес?",
         "Брандмауэр блокирует соединение?"
    };
            AddQuestionsToCheckBoxes(groupBoxConnectivity, connectivityQuestions);
        }

        private void AddQuestionsToCheckBoxes(GroupBox groupBox, string[] questions)
        {
            //Рандомизировать массив вопросов, чтобы рандомизировать порядок вопросов
            Random rnd = new Random();
            questions = questions.OrderBy(q => rnd.Next()).ToArray();

            // перебрать все флажки в групповом поле
            foreach (CheckBox checkBox in groupBox.Controls.OfType<CheckBox>())
            {
                // Check if the index is within the range of the questions array
                if (checkBox.TabIndex < questions.Length)
                {
                    // Установить текст флажка на соответствующий вопрос
                    checkBox.Text = questions[checkBox.TabIndex];
                }
            }
        }

        private void comboBoxProblem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxProblem.SelectedItem.ToString())
            {
                case "Проблема аппаратного характера":
                    groupBoxHardware.Visible = true;
                    groupBoxSoftware.Visible = false;
                    groupBoxConnectivity.Visible = false;
                    break;
                case "Проблема с ПО":
                    groupBoxHardware.Visible = false;
                    groupBoxSoftware.Visible = true;
                    groupBoxConnectivity.Visible = false;
                    break;
                case "Проблема с подключением к сети":
                    groupBoxHardware.Visible = false;
                    groupBoxSoftware.Visible = false;
                    groupBoxConnectivity.Visible = true;
                    break;
                default:
                    groupBoxHardware.Visible = false;
                    groupBoxSoftware.Visible = false;
                    groupBoxConnectivity.Visible = false;
                    break;
            }
        }

        private void buttonShowGroupBox_Click(object sender, EventArgs e)
        {
            // Спрятать все групбоксы
            groupBoxHardware.Visible = false;
            groupBoxSoftware.Visible = false;
            groupBoxConnectivity.Visible = false;

            // Показать(сделать видимым) соответствующий групбокс на основе выбранной проблемы в комбобокс
            switch (comboBoxProblem.SelectedItem.ToString())
            {
                case "Проблема аппаратного характера":
                    groupBoxHardware.Visible = true;
                    break;
                case "Проблема с ПО":
                    groupBoxSoftware.Visible = true;
                    break;
                case "Проблема с подключением к сети":
                    groupBoxConnectivity.Visible = true;
                    break;
            }
        }

            private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Получить выбранные проблемы
            List<string> selectedProblems = new List<string>();
            if (groupBoxHardware.Visible)
            {
                foreach (CheckBox checkBox in groupBoxHardware.Controls.OfType<CheckBox>().Where(c => c.Checked))
                {
                    selectedProblems.Add(checkBox.Text);
                }
            }
            else if (groupBoxSoftware.Visible)
            {
                foreach (CheckBox checkBox in groupBoxSoftware.Controls.OfType<CheckBox>().Where(c => c.Checked))
                {
                    selectedProblems.Add(checkBox.Text);
                }
            }
            else if (groupBoxConnectivity.Visible)
            {
                foreach (CheckBox checkBox in groupBoxConnectivity.Controls.OfType<CheckBox>().Where(c => c.Checked))
                {
                    selectedProblems.Add(checkBox.Text);
                }
            }
            // Определить вывод на основе выбранных проблем
            string conclusion = "";
            if (selectedProblems.Count == 0)
            {
                conclusion = "Проблемы не выделены";
            }
            else if (selectedProblems.Count == 3)
            {
                conclusion = "Следующие проблемы были обнаружены:\n\n";
                foreach (string problem in selectedProblems)
                {
                    conclusion += "- " + problem + "\n";
                }
                conclusion += "\nПожалуйста, попробуйте следующее решение:\n\n";
                switch (comboBoxProblem.SelectedItem.ToString())
                {
                    case "Проблема аппаратного характера":
                        conclusion += "– Проверьте все кабели и соединения.\n– Перезагрузите компьютер.\n– Запустите диагностический тест оборудования.";
                        break;
                    case "Проблема с ПО":
                        conclusion += "- Проверьте наличие обновлений для вашего программного обеспечения\n- Перезагрузите компьютер\n- Переустановите программное обеспечение.";
                        break;
                    case "Проблема с подключением к сети":
                        conclusion += "- Проверьте все кабели и соединения.\n– Перезагрузите модем и маршрутизатор.\n– Обратитесь к своему интернет-провайдеру.";
                        break;
                }
            }
            else if (selectedProblems.Count == 2)
            {
                conclusion = "Возможно проблема в этом:\n\n";
                foreach (string problem in selectedProblems)
                {
                    conclusion += "- " + problem + "\n";
                }
                conclusion += "\nПожалуйста, попробуйте следующее решение:\n\n";
                switch (comboBoxProblem.SelectedItem.ToString())
                {
                    case "Проблема аппаратного характера":
                        conclusion += "– Попробуйте перезагрузить ПК\n";
                        break;
                    case "Проблема с ПО":
                        conclusion += "- Попробуйте перезагрузить ПО\n";
                        break;
                    case "Проблема с подключением к сети":
                        conclusion += "- Перезагрузите интернет или маршрутизатор\n";
                        break;
                }
            }
            else if (selectedProblems.Count == 1)
            {
                conclusion = "На основе предоставленных данных невозможно сделать вывод о неисправности\n";
            }

            else
            {
                conclusion = "Обнаружено множество проблем.\n Обратитесь за помощью в службу технической поддержки.";
            }

            // Вывести итог этого всего в новом окне
            MessageBox.Show(conclusion, "Диагностированы проблемы");

            comboBoxProblem.SelectedIndex = -1;
            groupBoxHardware.Visible = false;
            groupBoxSoftware.Visible = false;
            groupBoxConnectivity.Visible = false;
            foreach (CheckBox checkBox in groupBoxHardware.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }
            foreach (CheckBox checkBox in groupBoxSoftware.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }
            foreach (CheckBox checkBox in groupBoxSoftware.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }

            foreach (CheckBox checkBox in groupBoxConnectivity.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }

            foreach (CheckBox checkBox in groupBoxHardware.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }

        //    очистить форму и оффнуть кнопки
         //   selectedProblems.Clear();
          //  comboBoxProblem.SelectedIndex = -1;
         //   groupBoxHardware.Visible = false;
          //  groupBoxSoftware.Visible = false;
          //  groupBoxConnectivity.Visible = false;
          //  buttonSubmit.Enabled = false;
          //  buttonShowGroupBox.Enabled = false;
        }
    }
}