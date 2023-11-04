using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // ІНІЦІАЛІЗАЦІЯ
            if (radioButton2.Checked){
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
            }
            else{
                MessageBox.Show("Не вибраний спосіб створення шифру");
            }
            //***
            // ЗАПОВНЕННЯ
            string text = textCrypto.Text;
            if (text != "")
            {
                char[] letters = text.ToCharArray();
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
        }
    }
}
