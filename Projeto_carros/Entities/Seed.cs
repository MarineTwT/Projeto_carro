using Entities;

namespace Projeto_carros.Entities
{
    internal class Seed
    {
        public static void seed_car()
        {
            Car.lista_de_carros.Add(new Car(1, "12-MA-46", "Chevrolet", "Celta", 2005, 10587, 0));
            Car.lista_de_carros.Add(new Car(2, "98-RE-12", "Volkswagen", "Golf", 2000, 102587, 0));
            Car.lista_de_carros.Add(new Car(3, "23-ET-56", "Ford", "Fusion", 2008, 1027, 0));
            Car.lista_de_carros.Add(new Car(4, "GG-66-98", "Chevrolet", "Corsa", 2002, 108767, 0));
            Car.lista_de_carros.Add(new Car(5, "GA-06-99", "Toyota", "Corolla", 1998, 208767, 0));
        }
      
        public static void seed_client()
        {
            Client.lista_de_clientes.Add(new Client(1, "Beltrano","Ciclano",100236598));
            Client.lista_de_clientes.Add(new Client(2, "Otáviio", "Astucio", 1452368745));
            Client.lista_de_clientes.Add(new Client(3, "Manuel", "Lopez", 785687896));
            Client.lista_de_clientes.Add(new Client(4, "Lorenzo", "Ciclano", 456321458));
            Client.lista_de_clientes.Add(new Client(5, "Virginia", "Ciclano", 475689632));
        }
    }
}
