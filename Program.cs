using System;
namespace Act4
{
    public class Program
    {
        public static double GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Convert.ToDouble(Console.ReadLine());
        }
        public static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }
        public static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public static void PrintAreaMessage(double area)
        {
            if (area > 50)
            {
                Console.WriteLine("L'àrea és més gran de 50");
            }
            else if (area > 20)
            {
                Console.WriteLine("L'àrea és entre 20 i 50");
            }
            else
            {
                Console.WriteLine("L'àrea és menor o igual a 20");
            }
        }
        public static void Main()
        {
            const string RectangleWidthMsg = "Introdueix l'amplada del rectangle:";
            const string RectangleHeightMsg = "Introdueix l'altura del rectangle:";
            const string RectangleArea = "L'àrea del rectangle és: {0}";
            const string CercleRadi = "Introdueix el radi del cercle:";
            const string CercleArea = "La circumferència del cercle és: {0}";

            // Càlcul de l'àrea d'un rectangle
            double rectangleWidth = GetUserInput(RectangleWidthMsg);
            double rectangleHeight = GetUserInput(RectangleHeightMsg);
            double rectangleArea = CalculateRectangleArea(rectangleWidth, rectangleHeight);
            Console.WriteLine(RectangleArea, rectangleArea);
            // Càlcul de la circumferència d'un cercle
            double circleRadius = GetUserInput(CercleRadi);
            double circleCircumference = CalculateCircumference(circleRadius);
            Console.WriteLine(CercleArea, circleCircumference);
            // Missatge basat en el valor de l'àrea
            PrintAreaMessage(rectangleArea);
        }
    }
}