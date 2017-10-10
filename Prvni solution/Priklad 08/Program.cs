using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priklad_08
{
    class MathOper
    {
        private double firstNumber { get; set; }
        private double secondNumber { get; set; }
        public MathOper(double firstVal,double secondVal)
        {
            firstNumber = firstVal;
            secondNumber = secondVal;
        }
        public double sum()
        {
            double result = firstNumber + secondNumber;
            return result;
        }
        public double dif()
        {
            double result = firstNumber - secondNumber;
            return result;
        }
        public double multiple()
        {
            double result = firstNumber * secondNumber;
            return result;
        }
        public double divide()
        {
            double result = firstNumber / secondNumber;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Vytvořte třídu, která bude do konstruktoru jako parametry přijímat dvě čísla a bude implementovat čtyři metody na základní aritmetické operace + - * /. 
             * Tyto metody postupně volejte a vypište na konzoli výsledky těchto operací ve formátu uvedeném v příkladu 1. 
             * (Výpis na konzoli můžete implementovat v metodách třídy, které implementuje výpočty)
             */
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            MathOper result = new MathOper(number1, number2);
            Console.WriteLine(result.sum());
            Console.WriteLine(result.dif());
            Console.WriteLine(result.multiple());
            Console.WriteLine(result.divide());
            Console.ReadKey();
        }
    }
}
