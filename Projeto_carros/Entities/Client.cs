using Entities;
using System.Collections;

namespace Entities
{
    internal class Client
    {
        public static List<Client> lista_de_clientes { get; set; } = new List<Client>();

        public string nome { get; private set; }
        public string sobrenome { get; private set; }

        public int nif { get; private set; }
        public int codigo { get; private set; }
        public int carro { get; private set; }

        public Client(int codigo, string nome, string sobrenome, int nif, int carro)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.nif = nif;
            this.codigo = codigo;
            this.carro = carro;
        }

        public static void Mostrar_clientes()
        {
            Console.Write("\n--------------------------------------\n");
            foreach (Client i in lista_de_clientes) i.Mostrar_dados();
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

            lista_de_clientes.Add(new Client(codigo, nome, sobrenome, nif, 0));
        }

        public static void Alugar_Carro()
        {
            Console.WriteLine("\n-----------------------------\n \nAlugando um carro:\n");

            Console.Write("\nJá está cadastrado? \n[1 - Sim /2 - Não] \n->");
            int escolha = Convert.ToInt16(Console.ReadLine());

            if (escolha == 1 && lista_de_clientes.Count > 0)
            {
                Mostrar_clientes();
                Console.Write("\nQual cliente seria? \n[Código] -> ");
                int codigo = Convert.ToInt16(Console.ReadLine());
            }

            else if (escolha == 1 && lista_de_clientes.Count <= 0)
            {
                Console.WriteLine("\nNão possui nenhum cliente no momento. Vamos adicionar como novo:");
                Adicionar_cliente();
            }

            else if (escolha == 2)
            {
                Adicionar_cliente();
            }

            foreach (Car i in Car.lista_de_carros) if (i.disposicao.Equals(0)) i.Mostrar_dados();

            Console.Write("\nQual carro gostaria de alugar? \n[ID] -> ");
            int escolha2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nCarro escolhido:");
            foreach (Car i in Car.lista_de_carros)
            {
                if (i.id == escolha2)
                {
                    i.Mostrar_dados();
                    i.disposicao.Equals(1);
                }
            }
        }

        public void Mostrar_dados()
        {
            Console.WriteLine("\n--- Cliente ---");
            Console.WriteLine("Código: {0}", codigo);
            Console.WriteLine("Nome: {0} {1}", nome, sobrenome);
            Console.WriteLine("NIF: {0} ", nif);
            Console.WriteLine("Último carro alugado [ID]: {0}", carro);
        }

        /*public override string ToString()
        {
            return "\n--- Cliente ---"
                 + "\nCódigo: {0}" + codigo
                 + "\nNome: {0} {1}" + nome + sobrenome
                 + "\nNIF: {0} " + nif
                 + "\nÚltimo carro alugado [ID]: {0}" + carro;
        }*/
    }
}
