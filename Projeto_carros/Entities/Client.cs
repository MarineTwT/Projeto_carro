namespace Entities
{
    internal class Client
    {
        public static List<Client> lista_de_clientes { get; set; } = new List<Client>();

        public string nome { get; private set; }
        public string sobrenome { get; private set; }

        public int nif { get; private set; }
        public int codigo { get; private set; }
        public int carro { get; set; }

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
            foreach (Client i in lista_de_clientes) i.Mostrar_dados(); Console.ReadLine();
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
