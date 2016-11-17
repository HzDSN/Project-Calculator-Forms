using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Calculator_Forms
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public enum Calculate
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    class Calculator
    {
        public double addition(double firstValue, double secondValue)
        {
            double sum;
            sum = firstValue + secondValue;
            return sum;
        }

        public double subtraction(double firstValue, double secondValue)
        {
            double sum;
            sum = firstValue - secondValue;
            return sum;
        }

        public double multiplication(double firstValue, double secondValue)
        {
            double sum;
            sum = firstValue * secondValue;
            return sum;
        }

        public double division(double firstValue, double secondValue)
        {
            double sum;
            sum = firstValue / secondValue;
            return sum;
        }
    }
}
