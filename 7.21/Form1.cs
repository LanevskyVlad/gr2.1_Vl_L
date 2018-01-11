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

namespace _7._18
{
    //Дан целочисленный массив размера N. Преобразовать массив, увеличив1|уменьшив2 каждую его серию на один элемент.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeArrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arr = ConvertArr.StrToArray<int>(ArrInput.Text);
                ToolsArr toolsArr = new ToolsArr(arr);
                int[] ArrNew = toolsArr.RemoveElements();
                RemoveOutput.Text = ConvertArr.ArrayToStr(ArrNew);
                ArrNew = toolsArr.AddElements();
                AddOutput.Text = ConvertArr.ArrayToStr(ArrNew);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
