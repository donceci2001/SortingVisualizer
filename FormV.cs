using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortV
{
    public partial class FormVisualization : Form
    {
        int[] array;
        private int speed;
        public FormVisualization()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            int numbers;
            int maxValue = panelVisualization.Height;
            bool valid = int.TryParse(textBoxArrayElements.Text, out _);
            if (valid)
                numbers = int.Parse(textBoxArrayElements.Text);
            else
            {
                return;
            }

            array = new int[numbers];

            MakeRectangle(Color.Blue, 0, 0, panelVisualization.Width, maxValue);
           
            Random randomNum = new Random();
            for (int i = 0; i < numbers; i++)
            {
                array[i] = randomNum.Next(0, maxValue);
            }

            int width = (int)Math.Ceiling((decimal)(panelVisualization.Width / numbers + 1));
            for (int i = 0; i < numbers; i++)
            {
                MakeRectangle(Color.White, i * width, maxValue - array[i], width, maxValue);
            }
        }
       
        private void buttonSort_Click(object sender, EventArgs e)
        {
            MergeSort sort = new MergeSort();
            using (var gr = panelVisualization.CreateGraphics())
               sort.StartSorting(array, gr , panelVisualization.Width, panelVisualization.Height , speed);
        }

        public void MakeRectangle(Color Color, int index1, int index2 , int Width, int Height)
        {
            var rectangle = new Rectangle();
            rectangle.color = Color;
            rectangle.x = index1;
            rectangle.y = index2;
            rectangle.width = Width;
            rectangle.height = Height;

            using (var gr = panelVisualization.CreateGraphics())
                rectangle.Paint(gr);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            speed = trackBar1.Value;
        }
    }
}
