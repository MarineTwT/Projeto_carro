using System.Linq;

namespace Entities
{
    internal class Client
    {
        public static List<Client> lista_de_clientes { get; set; } = new List<Client>();

        public int Id { get; private set; }

        public string nome { get; private set; }
        public string sobrenome { get; private set; }

        public int nif { get; private set; }

        public Client(int Id, string nome, string sobrenome, int nif)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.nif = nif;
            this.Id = Id;         
        }

        public static void Mostrar_clientes()
        {
            Console.Write("\n--------------------------------------\n");
            foreach (Client i in lista_de_clientes) Console.WriteLine(i.ToString());
        }

        public static void Adicionar_cliente()
        {
            Console.Write("\n--------------------------------------\n");
            int codigo = lista_de_clientes.Count + 1;

            Console.Write("\nNome:\n->");
            string nome = Console.ReadLine();

            Console.Write("\nSobrenome:\n-> ");
            string sobrenome = Console.ReadLine();

            Console.Write("\nNIF:\n-> ");
            int nif = Convert.ToInt32(Console.ReadLine());

            lista_de_clientes.Add(new Client(codigo, nome, sobrenome, nif));
        }

        public override string ToString()
        {
            return "\n--- Cliente ---"
                 + "\nCódigo: " + Id
                 + "\nNome: " + nome + " " + sobrenome
                 + "\nNIF: " + nif;
        }
    }
}
