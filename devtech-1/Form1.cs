using System;
using System.Windows.Forms;

namespace devtech_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Complex X = new Complex(1, 2);
            Complex Y = new Complex(3, 4);

            Console.WriteLine((X + Y).ToString());
            Console.WriteLine((X - Y).ToString());
            Console.WriteLine((X * Y).ToString());
            Console.WriteLine((X / Y).ToString());
        }
    }
    public class Complex
    {
        private double re;
        private double im;

        public Complex()
        {
            this.re = 0;
            this.im = 0;
        }

        public Complex(double re)
        {
            this.re = re;
            this.im = 0;
        }

        public Complex(double re, double im)
        {
            this.im = im;
            this.re = re;
        }

        public double GetAbs()
        {
            return Math.Sqrt(Math.Pow(re, 2) + Math.Pow(im, 2));
        }

        public double GetArg()
        {
            return Math.Atan(im/re);
        }

        public override string ToString()
        {
            return $"({this.re}, {this.im})";
        }

        public static Complex operator +(Complex x, Complex y)
        {
            Complex result = new Complex();
            result.re = x.re + y.re;
            result.im = x.im + y.im;
            return result;
        }

        public static Complex operator -(Complex x, Complex y)
        {
            Complex result = new Complex();
            result.re = x.re - y.re;
            result.im = x.im - y.im;
            return result;
        }

        public static Complex operator *(Complex x, Complex y)
        {
            Complex result = new Complex();
            result.re = (x.re * y.re) - (x.im * y.im);
            result.im = (x.im * y.re) + (x.re * y.im);
            return result;
        }

        public static Complex operator /(Complex x, Complex y)
        {
            Complex result = new Complex();
            result.re = ((x.re * y.re) + (x.im * y.im)) / (Math.Pow(y.re, 2) + Math.Pow(y.im, 2));
            result.im = ((x.im * y.re) - (x.re * y.im)) / (Math.Pow(y.re, 2) + Math.Pow(y.im, 2));
            return result;
        }
    }
}
