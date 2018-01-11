using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsGrid;
using tools;

namespace _9._18
{ /* (*) Будем называть «дружественными» элементами для двумерного массива такие элементы, 
    которые соединяются с данным элементом одной из сторон и имеют одно и то же значение, 
    а также все дружественные элементы для дружественных элементов данного элемента. 
    Составить для переданного двумерного массива новый массив, в котором каждый элемент 
    будет содержать информацию о количестве дружественных элементов для соответствующего 
    элемента в переданном массиве */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(Input, 40, false, false, false, true, true);
            DataGridViewUtils.InitGridForArr(Output, 40, true, false, false, false, false);
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] Arr2 = DataGridViewUtils.GridToArray2<int>(Input);
                ToolsArr2 toolsArr2 = new ToolsArr2(Arr2);
                int[,] OutArr2 = toolsArr2.GetCount();
                DataGridViewUtils.Array2ToGrid(Output, OutArr2);
                save.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    FileArr2 file = new FileArr2(saveFileDialog.FileName);
                    int[,] Arr2 = DataGridViewUtils.GridToArray2<int>(Output);
                    file.WriteArr2(Arr2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileArr2 file = new FileArr2(openFileDialog.FileName);
                    int[,] Arr2 = file.ReadArr2();
                    DataGridViewUtils.Array2ToGrid(Input, Arr2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }
    }
}
