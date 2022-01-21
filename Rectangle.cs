using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortV
{
    class Rectangle
    {
        public float x { get; set; }
        public int y { get; set; }
        public float width { get; set; }
        public int height { get; set; }
           
        public Color color { get; set; }
        public void Paint(Graphics gr)
        {
            using(var brush = new SolidBrush(color))
            {
                gr.FillRectangle(brush, x, y, width, height);
            }
            
        }
    }
}
