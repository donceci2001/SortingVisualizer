using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SortV
{
    public class MergeSort 
    {
        private int[] arr;
        private Graphics visualizedObject;
        private int maxVal;
        private int panelWidth;
        private int speed;

        public void StartSorting(int[] array, Graphics visObject, int pnlWidth, int maxValue, int speed)
        {
            arr = array;
            visualizedObject = visObject;
            maxVal = maxValue;
            panelWidth = pnlWidth;
            this.speed = speed;
            SortMerge(arr, new int[arr.Length], 0, arr.Length - 1);
        }

        public void SortMerge(int [] array, int[] temp, int leftStart, int rightEnd)
        {
            if(leftStart >= rightEnd)
            {
                return;
            }
            int middle = (leftStart + rightEnd) / 2;
            SortMerge(array, temp, leftStart, middle);
            SortMerge(array, temp, middle + 1, rightEnd);
            Merge(array, temp, leftStart, rightEnd);
        }

        public void Merge(int [] array , int [] temp, int leftStart, int rightEnd)
        {
            float width = (float)panelWidth / arr.Length ;

            int leftEnd = (rightEnd + leftStart) / 2;
            int rightStart = leftEnd + 1;
            int left = leftStart;
            int right = rightStart;
           
            int index = leftStart ;

            while(left <= leftEnd && right <= rightEnd)
            {
                if(array[left] <= array[right])
                {
                    temp[index] = array[left];
                    left++;
                    ReDraw(Color.Blue, left, 0, width, maxVal);
                    MakeRectangle(Color.White, left * width, maxVal - arr[left], width, maxVal);

                }
                else
                {
                    temp[index] = array[right];
                    right++;
                    ReDraw(Color.Blue, right, 0, width, maxVal);
                    MakeRectangle(Color.White, right * width, maxVal - arr[right - 1], width, maxVal);

                }

                index++;        
            }

            Array.Copy(array, left, temp, index, leftEnd - left + 1);
            Array.Copy(array, right, temp, index, rightEnd - right + 1);
            Array.Copy(temp, leftStart, array, leftStart, rightEnd - leftStart + 1);


            ReDraw(Color.Blue, 0, 0, panelWidth, maxVal);
            for (int i = 0; i < arr.Length; i++)
            {
                MakeRectangle(Color.White, i * width, maxVal - array[i], width, maxVal);
            }



            if (Sorted(arr))
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    MakeRectangle(Color.Green, i * width, maxVal - array[i], width, maxVal);
                    Thread.Sleep(speed * 5);
                }
            }

        }
        

        public void MakeRectangle(Color Color, float index1, int index2, float Width, int Height)
        {
            var rectangle = new Rectangle();
            rectangle.color = Color;
            rectangle.x = index1;
            rectangle.y = index2;
            rectangle.width = Width;
            rectangle.height = Height;
            
            rectangle.Paint(visualizedObject);

        }

        public void ReDraw(Color color, float x , float y , float width, float height)
        {
            using (var brush = new SolidBrush(color))
            {
                visualizedObject.FillRectangle(brush, x * width, y, width, height);
                Thread.Sleep(speed);
            }
        }


        public bool Sorted(int[] arr)
        {

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;
            
        }
    }
}
