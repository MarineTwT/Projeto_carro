using Entities;
using Projeto_carros.Entities;

namespace Projeto_carros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Seed.seed_car();
            Seed.seed_client();
            Menu.Chamar_menu();
        }
    }
}