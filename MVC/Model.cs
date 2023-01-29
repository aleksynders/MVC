using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MVC
{
    public static class Model
    {
        public static List<string> dataListOperationStr = new List<string>() { "Сложение", "Вычитание", "Умножение", "Деление" };
        public static List<string> dataListOperationZnak = new List<string>() { "+", "-", "*", "/" };

        public static TextBlock tbTextOperation;
        public static string One;
        public static string Two;
        public static TextBox tbResult;

        public static int Operation
        {
            set
            {
                tbTextOperation.Text = dataListOperationZnak[value];
            }
        }
        public static int Result
        {
            set
            {
                try
                {
                    double numberOne = 0;
                    double numberTwo = 0;
                    if (One != "")
                        numberOne = Convert.ToDouble(One);
                    if (Two != "")
                        numberTwo = Convert.ToDouble(Two);
                    switch (value)
                    {
                        case 0:
                            tbResult.Text = Convert.ToString(numberOne + numberTwo);
                            break;
                        case 1:
                            tbResult.Text = Convert.ToString(numberOne - numberTwo);
                            break;
                        case 2:
                            tbResult.Text = Convert.ToString(numberOne * numberTwo);
                            break;
                        case 3:
                            if (numberTwo == 0)
                                tbResult.Text = "Деление на 0 невозможно!";
                            else
                                tbResult.Text = Convert.ToString(numberOne / numberTwo);
                            break;
                    }
                }
                catch
                {
                    tbResult.Text = "Ошибка!";
                }
            }
        }
    }
}
