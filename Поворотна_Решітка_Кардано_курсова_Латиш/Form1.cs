using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Поворотна_Решітка_Кардано_курсова_Латиш
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int count = 1;
        public string text = "";
        public char[] letters;
        bool isBlack =false;
        string pattern1 = (@"^[a-zA-Z]+$");
        string pattern2 = (@"^[а-яА-Я]+$");
        private void button1_Click(object sender, EventArgs e)
        {
            InitiateMatrix();
        }
        private void InitiateMatrix()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    matrix.RowCount = 8;
                    matrix.ColumnCount = 8;
                    break;
                case 1:
                    matrix.RowCount = 12;
                    matrix.ColumnCount = 12;
                    break;
                case 2:
                    matrix.RowCount = 16;
                    matrix.ColumnCount = 16;
                    break;
                case 3:
                    matrix.RowCount = 20;
                    matrix.ColumnCount = 20;
                    break;
                default:
                    MessageBox.Show("Виберіть розмірність матриці для шифру!");
                    break;
            }

            int totalHeight = matrix.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            matrix.Height = totalHeight;
            int totalWidth = matrix.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            matrix.Width = totalWidth;
            matrix2.RowCount = matrix.RowCount;
            matrix2.ColumnCount = matrix.ColumnCount;
            matrix3.RowCount = matrix.RowCount;
            matrix3.ColumnCount = matrix.RowCount;
            matrix2.Height = totalHeight;
            matrix3.Height = totalHeight;
            matrix2.Width = totalWidth;
            matrix3.Width = totalWidth;
            text = textCrypto.Text;
            if (Regex.IsMatch(text, pattern1) || Regex.IsMatch(text, pattern2))
            {
                matrix.Visible = true;
                letters = text.ToCharArray();
                int counter = 1;
                for (int i = 0; i < matrix.RowCount / 2; i++)
                {
                    for (int j = 0; j < matrix.RowCount / 2; j++)
                    {
                        matrix[i, j].Value = counter;
                        counter++;
                    }
                }
                counter = 1;

                for (int j = matrix.RowCount - 1; j > matrix.RowCount / 2 - 1; j--)
                {
                    for (int i = 0; i < matrix.RowCount / 2; i++)
                    {
                        matrix[i, j].Value = counter;
                        counter++;
                    }
                }
                counter = 1;


                for (int j = 0; j < matrix.RowCount / 2; j++)
                {
                    for (int i = matrix.RowCount - 1; i > matrix.RowCount / 2 - 1; i--)
                    {
                        matrix[i, j].Value = counter;
                        counter++;
                    }
                }
                counter = 1;

                for (int i = matrix.RowCount - 1; i > matrix.RowCount / 2 - 1; i--)
                {
                    for (int j = matrix.RowCount - 1; j > matrix.RowCount / 2 - 1; j--)
                    {
                        matrix[i, j].Value = counter;
                        counter++;
                    }
                }
            }
            else MessageBox.Show("Текст для шифрування має бути кирилицею/латиницею");
        }
        private void matrix_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = matrix.Rows[e.RowIndex].Cells[e.ColumnIndex];
            bool flag = true;
            if (cell.Value.ToString() == $"{count}" && count <= text.Length && flag)
            {
                matrix.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;
                matrix[e.ColumnIndex, e.RowIndex].Value = text[count - 1];
                matrix3[e.ColumnIndex, e.RowIndex].Value = count;
                count++;
            }
            if (count == text.Length + 1 && flag)
            {
                MessageBox.Show("Інші значення будуть підставлені автоматично");
                FillMatrixByRandomLetters();
                CopyMatrix();
                flag = false;
            }
        }
        private void CopyMatrix()
        {
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    matrix2[j, i].Value = matrix[j, i].Value;
                    if (matrix.Rows[i].Cells[j].Style.BackColor != Color.Yellow)
                        matrix3.Rows[i].Cells[j].Style.BackColor = Color.Black;
                }
            }
        }
        private void FillMatrix(List<char> letters)
        {
            Random random = new Random();
            int randomIndex=0;
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    if (matrix.Rows[i].Cells[j].Style.BackColor != Color.Yellow)
                    {
                        randomIndex = random.Next(0, letters.Count);
                        char randomLetter = letters[randomIndex];
                        matrix[j, i].Value = randomLetter.ToString();
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            matrix2.Visible = true;
            matrix3.Visible = true;
            Color color;
            if (isBlack)
            {
                color = Color.White;
                isBlack = false;
            }
            else
            {
                color = Color.Black;
                isBlack = true;
            }

            for (int i = 0; i < matrix.RowCount; i++)
            {
                    for (int j = 0; j < matrix.ColumnCount; j++)
                    {
                        if (matrix.Rows[i].Cells[j].Style.BackColor != Color.Yellow)
                        {
                            matrix.Rows[i].Cells[j].Style.BackColor = color;
                        }
                    }
            }
        }
    }
}
