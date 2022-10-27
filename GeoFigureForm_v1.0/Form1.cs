using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeoFigureForm_v1._0
{
    public partial class Form1 : Form
    {
        private void SetFigureFormat()
        {
            switch (comboBoxForFigure.Text)
            {
                case ("Прямоугольник"):
                    {
                        buttonForSelect.Visible = true;
                        label1.Visible = true;
                        textBoxForFigure1.Visible = true;
                        label2.Visible = true;
                        textBoxForFigure2.Visible = true;
                        label3.Visible = false;
                        textBoxForFigure3.Visible = false;
                        textBoxForFigure1.Clear();
                        textBoxForFigure2.Clear();
                        textBoxForFigure3.Clear();
                        label1.Text = "Введите ширину";
                        label2.Text = "Введите высоту";
                        //buttonForSelect.Click += Click;
                    }
                    break;
                case ("Треугольник"):
                    {
                        buttonForSelect.Visible = true;
                        label1.Visible = true;
                        textBoxForFigure1.Visible = true;
                        label2.Visible = true;
                        textBoxForFigure2.Visible = true;
                        label3.Visible = true;
                        textBoxForFigure3.Visible = true;
                        textBoxForFigure1.Clear();
                        textBoxForFigure2.Clear();
                        textBoxForFigure3.Clear();
                        label1.Text = "Введите угол 1";
                        label2.Text = "Введите угол 2";
                        label3.Text = "Введите угол 3";
                    }
                    break;
                case ("Круг"):
                    {
                        buttonForSelect.Visible = true;
                        label1.Visible = true;
                        textBoxForFigure1.Visible = true;
                        label2.Visible = false;
                        textBoxForFigure2.Visible = false;
                        label3.Visible = false;
                        textBoxForFigure3.Visible = false;
                        textBoxForFigure1.Clear();
                        textBoxForFigure2.Clear();
                        textBoxForFigure3.Clear();
                        label1.Text = "Введите радиус";
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Выберите формат фигуры");
                        buttonForSelect.Visible = false;
                        label1.Visible = false;
                        textBoxForFigure1.Visible = false;
                        label2.Visible = false;
                        textBoxForFigure2.Visible = false;
                        label3.Visible = false;
                        textBoxForFigure3.Visible = false;
                        textBoxForFigure1.Clear();
                        textBoxForFigure2.Clear();
                        textBoxForFigure3.Clear();
                    }
                    break;
            }
        }
        private void check() 
        {
            if (comboBoxForFigure.Text == "Прямоугольник")
            {
                Retangle rect = new Retangle();
                try
                {
                    rect.Height = int.Parse(textBoxForFigure1.Text);
                    rect.Width = int.Parse(textBoxForFigure2.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Пользовательские ошибки {ex.Message}");
                }
            }
            if (comboBoxForFigure.Text == "Треугольник")
            {
                Triangle triangle = new Triangle();
                try
                {
                    triangle.SideA = int.Parse(textBoxForFigure1.Text);
                    triangle.SideB = int.Parse(textBoxForFigure2.Text);
                    triangle.SideC = int.Parse(textBoxForFigure3.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Пользовательские ошибки {ex.Message}");
                }
            }
            if (comboBoxForFigure.Text == "Круг")
            {
                Circle circle = new Circle();
                try
                {
                    circle.Radius = int.Parse(textBoxForFigure1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Пользовательские ошибки {ex.Message}");
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            buttonForSelect.Visible = false;
            label1.Visible = false;
            textBoxForFigure1.Visible = false;
            label2.Visible = false;
            textBoxForFigure2.Visible = false;
            label3.Visible = false;
            textBoxForFigure3.Visible = false;
        }

        private void comboBoxForFigure_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void buttonForFigure_MouseClick(object sender, MouseEventArgs e)
        {
            SetFigureFormat();
        }
        private void buttonForSelect_MouseClick(object sender, MouseEventArgs e)
        {
            check();
        }

        private void buttonForSelect_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
    public abstract class Figure
    {
        //Площадь
        public abstract double Area();
        //Периметр
        public abstract double Perimeter();
    }

    public class Retangle : Figure
    {
        private int width;
        private int height;
        public int Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Некорректный ввод!");
                }
                else
                {
                    width = value;
                }
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Некорректный ввод!");
                }
                else
                {
                    height = value;
                }

            }
        }

        public override double Area()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return Width * 2 + Height * 2;
        }
    }

    public class Triangle : Figure
    {
        private int sideA;
        private int sideB;
        private int sideC;
        public int SideA
        {
            get { return sideA; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Некорректный ввод!");
                }
                else
                    sideA = value;
            }
        }
        public int SideB
        {
            get { return sideB; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Некорректный ввод!");
                }
                else
                    sideB = value;
            }
        }
        public int SideC
        {
            get { return sideC; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Некорректный ввод!");
                }
                else
                    sideC = value;
            }
        }
        public double Side { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public bool isTriangle(int a, int b, int c)
        {
            return (a + b) > c && (a + c) > b && (b + c) > a;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
    }

    public class Circle : Figure
    {
        private int radius;
        public int Radius 
        {
            get { return radius; }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Некорректный ввод!");
                }
                else
                {
                    radius = value;
                }
            } 
        }
        public override double Area()
        {
            return Radius * Math.PI;
        }
        public override double Perimeter()
        {
            return Radius * Math.PI;
        }
    }
}
