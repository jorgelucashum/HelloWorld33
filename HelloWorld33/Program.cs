using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloWorld33.Entities;
using HelloWorld33.Entities.Enums;

namespace HelloWorld33
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>(); // Criando uma lista vazia do tipo abstrata para conter as subclasses.

            Console.Write("Digite o número de formas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Forma: #" + i);
                Console.Write("Retângulo ou círculo (r/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Cor (preto/azul/vermelho):");
                Color color;
                Enum.TryParse(Console.ReadLine(), out color); // Convertendo tipo 'string' para 'enum'.


                if (ch == 'r')
                {
                    Console.Write("Altura: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Largura: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Raio: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }

            }

            Console.WriteLine("\nÁreas das formas: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }

            Console.ReadLine(); // Fim.
        }
    }
}
