using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tools;

namespace _7._49
{ /* Вводится массив целых чисел. Найти наиболее длинную симметричную подпоследовательность 
    подряд идущих элементов  (реализовать функцию, которая будет возвращать позицию первого 
    элемента такой подпоследовательности и кол-во элементов). В случае нескольких таких 
    подпоследовательностей найти самую первую. Например, для массива 
    {5, 1, 3, 1, 3, 5, 1, 5, 3, 7, 8, 8, 9, 8, 8, 5, 1} правильным ответом будет  
    подпоследовательность { 3, 5, 1, 5, 3 }.
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {

            try
            {
                int[] arr = ConvertArr.StrToArray<int>(ArrInput.Text);
                ToolsArr toolsArr = new ToolsArr(arr);
                if (toolsArr.SearchSymmetrySeries(out int index, out int count))
                {
                    int[] ArrNew = toolsArr.SubArr(index, count);
                    output.Text = ConvertArr.ArrayToStr(ArrNew);
                }
                else
                {
                    output.Text = "последовательность не найдена";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
