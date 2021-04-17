using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloWorld33.Entities.Enums;
namespace HelloWorld33.Entities
{
    // Classes abstratas: São classes que não podem ser instanciadas (subclasses derivadas da superclasse podem ser).
    // É uma forma de garantir herança total. Somente subclasses não abstratas podem ser instanciadas, mas nunca a super classe abstrata.
    // Uma classe abstrata serve somente como um modelo para reuso nas demais classes, assim evitando repetir várias linhas de cógidos com a mesma função em classes diferentes.
    // No 'UML' o itálico indica que a classe é abstrata
   
    abstract class Shape // 'abstract' indicando que é o 'Shape' ´eu uma classe abstrata.
    {
        public Color color { get; set; }

        public Shape()
        {
        }

        protected Shape(Color color)
        {
            this.color = color;
        }


        // Métodos abastratos: São métodos que não possuem implementação.
        // Métodos precisam ser abstratos quando a classe é genérica de mais para conter sua implementação. (Ex: um método 'área' para várias formas que tem áreas com fórmulas diferentes).
        // Se uma classe tem um método abstrato, esta classe também precisa ser abstrata.
        // Notação UML: texto em 'itálico' (o mesmo da classe).
        public abstract double Area(); // 'abstract' indicando que o método é abstrato.

    }
}
