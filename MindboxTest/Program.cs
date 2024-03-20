using AOTFCalculator;
using AOTFCalculator.Entities;
using AOTFCalculator.Entities.Base;

namespace MindboxTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Выбери фигуру (Напечатай цифру)\n 1 - круг\n 2 - Треугольник" );
            var input = Console.ReadLine();
            Shape shape = new Triangle(new double[] { });
            switch (input)
            {
                case ("1"):
                    Console.WriteLine("Введи радиус круга");
                    var inputRadius = Convert.ToDouble(Console.ReadLine());
                    shape = ShapeFactory.CreateCircle(inputRadius);
                    break;
                case ("2"):
                    Console.WriteLine("Стороны треугольника через пробел");
                    try
                    {
                        var inputTriangle = Console.ReadLine().Split(' ')
                        .Where(x => !string.IsNullOrWhiteSpace(x))
                        .Select(x => double.Parse(x)).ToArray();
                        shape = ShapeFactory.CreateTriangle(inputTriangle[0], inputTriangle[1], inputTriangle[2]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка");
                        Console.WriteLine(ex.Message);
                        break;
                    }
                break;
            }
            Console.WriteLine($"Площадь {shape.ShapeName()} равна {shape.AreaOfTheFigure()}");
        }
    }
}
