using Avalonia.Controls;
using Avalonia.Input;
using System;
using System.Runtime.InteropServices;

namespace AvaloniaApplication1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private string GetX()
        {
            //ax2 + bx + c = 0
            double a = Convert.ToDouble(TextFiled.Text);
            double b = Convert.ToDouble(TextFiled2.Text);
            double c = Convert.ToDouble(TextFiled3.Text);

            double D = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            if (D < 0)
            {
                return "Корней нет";
            }

            else if (a == 0)
            {
                return "Это не квадратное уравнение";
            }

            if (D == 0)
            {
                if (x1 < x2)
                {
                    return $"D = 0 => \nx = {x2}";
                }
                else return $"D = 0 => \nx = {x1}";
            }

            string foundX = $"x1 = {x1} \nx2 = {x2}";

            return foundX;
        }

        private void FindX(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            PrintX.Text = GetX();
        }

        private void Exit(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Close();
        }
    }
}