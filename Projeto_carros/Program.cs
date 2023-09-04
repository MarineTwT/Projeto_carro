using Entities;

namespace Projeto_carros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car.lista_de_carros.Add(new Car(1, "12-MA-46", "Chevrolet", "Celta", 2005, 10587, 0));
            Car.lista_de_carros.Add(new Car(2, "98-RE-12", "Volkswagen", "Golf", 2000, 102587, 0));
            Car.lista_de_carros.Add(new Car(3, "23-ET-56", "Ford", "Fusion", 2008, 1027, 0));
            Car.lista_de_carros.Add(new Car(4, "GG-66-98", "Chevrolet", "Corsa", 2002, 108767, 0));
            Car.lista_de_carros.Add(new Car(5, "GA-06-99", "Toyota", "Corolla", 1998, 208767, 0));

            Menu.Chamar_menu();
        }
    }
}