using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagonalDifference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<List<int>> arr = new List<List<int>>();

            List<int> a = new List<int>() { 11, 2, 4 };
            arr.Add(a);

            List<int> b = new List<int>() { 4, 5, 6 };
            arr.Add(b);

            List<int> c = new List<int>() { 10, 8, -12 };
            arr.Add(c);

            Console.WriteLine(diagonalDifference(arr));
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int rigthDiagonal = 0;
            int leftDiagonal = 0;

            int countInverter = arr.Count - 1;

            for (int i = 0; i < arr.Count; i++)
            {
                rigthDiagonal += arr[i][i];
                leftDiagonal += arr[countInverter][i];

                countInverter--;
            }

            return Math.Abs(rigthDiagonal - leftDiagonal);
        }
    }
}
