using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        private DataTable stringGrid1Table;
        private DataTable stringGrid2Table;
        private readonly char[] _al = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        private readonly char[] _bl = { 'а', 'о', 'е', 'и', 'т', 'н', 'с', 'р', 'к', 'л', 'в', 'м', 'д', 'п', 'у', 'я', 'ы', 'з', 'б', 'г', 'ь', 'ч', 'й', 'х', 'ж', 'ю', 'ш', 'ц', 'ё', 'э', 'щ', 'ъ', 'ф' };
        private const int key = 1;

        public Form1()
        {
            InitializeComponent();

            stringGrid1Table = new DataTable();
            stringGrid2Table = new DataTable();

            stringGrid1Table.Columns.Add("Letter", typeof(string));
            stringGrid1Table.Columns.Add("Frequency (%)", typeof(string));

            stringGrid2Table.Columns.Add("Letter", typeof(string));
            stringGrid2Table.Columns.Add("Encrypted Letter", typeof(string));

            stringGrid1.DataSource = stringGrid1Table;
            stringGrid2.DataSource = stringGrid2Table;

            stringGrid2.CellValueChanged += StringGrid2_CellValueChanged;

            for (int i = 0; i < _al.Length; i++)
            {
                string letter = _al[i].ToString();
                double frequency = 0.0;
                stringGrid1Table.Rows.Add(letter, frequency);
            }
            for (int i = 0; i < _bl.Length; i++)
            {
                string letter = _bl[i].ToString();
                string encryptedLetter = "";
                stringGrid2Table.Rows.Add(letter, encryptedLetter);
            }
        }
        private string Decrypt(string encryptedLine, int key)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in encryptedLine)
            {
                int charValue = (int)c - key;
                if (charValue < (int)'а')
                {
                    charValue += 32;
                }
                result.Append((char)charValue);
            }

            return result.ToString();
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var fileStream = new StreamReader(openFileDialog.FileName))
                {
                    var scod = "";
                    while (!fileStream.EndOfStream)
                    {
                        var s = fileStream.ReadLine();
                        scod += s;
                        memo1TextBox.AppendText(s + Environment.NewLine);
                    }
                    memo2.Text = memo1TextBox.Text;

                    double[] ch = new double[_al.Length];
                    int[] n = new int[_bl.Length];
                    for (int k = 0; k < ch.Length; k++)
                    {
                        ch[k] = 0;
                    }
                    for (int k = 0; k < ch.Length; k++)
                    {
                        for (int j = 0; j < scod.Length; j++)
                        {
                            if (scod[j] == _al[k])
                            {
                                ch[k]++;
                            }
                        }
                    }
                    double sum = ch.Sum();
                    for (int k = 0; k < ch.Length; k++)
                    {
                        ch[k] = ch[k] / sum * 100;
                        stringGrid1Table.Rows[k]["Frequency (%)"] = ch[k].ToString("#0.00");
                    }
                    for (int k = 0; k < n.Length; k++)
                    {
                        n[k] = k;
                    }
                    for (int k = 0; k < _bl.Length - 1; k++)
                    {
                        for (int j = k + 1; j < _bl.Length; j++)
                        {
                            if (ch[k] < ch[j])
                            {
                                double rr = ch[k];
                                ch[k] = ch[j];
                                ch[j] = rr;
                                int rb = n[k];
                                n[k] = n[j];
                                n[j] = rb;
                            }
                        }
                    }
                    for (int k = 0; k < _al.Length; k++)
                    {
                        stringGrid2Table.Rows[k]["Letter"] = _al[k].ToString();

                    }

                }
            }
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string encryptedText = memo2.Text;

            string decryptedText = Decrypt(encryptedText, key);

            memo1.Text = decryptedText;
        }

        private void StringGrid2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (columnIndex == 1)
            {
                string encryptedLetter = stringGrid2Table.Rows[rowIndex][columnIndex].ToString();

                string decryptedText = Decrypt(memo2.Text, key);
                memo1.Text = decryptedText.Replace(encryptedLetter, _al[rowIndex].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
