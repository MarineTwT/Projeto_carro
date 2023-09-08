using Entities.Enums;
using Projeto_carros.Entities;

namespace Entities
{

    internal class Car
    {
        public static List<Car> lista_de_carros { get; set; } = new List<Car>();
        public int id { get; private set; }

        public int ano { get; private set; }
        public  float km { get; private set; }
        public Disposicao disposicao { get; private set; }

        public string matricula { get; private set; }
        public string marca { get; private set; }
        public string modelo { get; private set; }

        public Car(int id, string matricula, string marca, string modelo, int ano, float km, Disposicao disposicao)
        {
            this.id = id;
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
            this.ano = ano;
            this.disposicao = disposicao;
        }

        public static void Mostrar_frota()
        {
            Console.Write("\n--------------------------------------\n");
            Console.WriteLine("\nPossuímos " + lista_de_carros.Count + " carro(s) na frota atual.");
            foreach (Car i in lista_de_carros) Console.WriteLine(i.ToString());           
        }       

        public static void Alugar_Carro()
        {
            Console.WriteLine("\n-----------------------------\n \nAlugando um carro:\n");

            try
            {
                Console.Write("\nJá está cadastrado? \n[1 - Sim /2 - Não] \n->");
                int escolha = Convert.ToInt16(Console.ReadLine());
                int codigo = 1;

                if (escolha == 1 && Client.lista_de_clientes.Count > 0)
                {
                    Client.Mostrar_clientes();
                    Console.Write("\nQual cliente seria? \n[Código] -> ");
                    codigo = Convert.ToInt16(Console.ReadLine());
                }

                else if ((escolha == 1 && Client.lista_de_clientes.Count <= 0) || escolha == 2)
                {
                    Console.WriteLine("\nNão possui nenhum cliente no momento. Vamos adicionar como novo:");
                    codigo = 0;
                    Client.Adicionar_cliente();
                }
            }

            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }

            foreach (Car i in lista_de_carros)
            {
                if (i.disposicao == 0) Console.WriteLine(i.ToString());
            }

            Console.Write("\nQual carro gostaria de alugar? \n[ID] -> ");
            int escolha2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nCarro escolhido:");
            foreach (Car i in lista_de_carros)
            {
                foreach (Client j in Client.lista_de_clientes)
                {
                    if (i.id == escolha2)
                    {
                        DateTime devolucao = DateTime.Now;
                        devolucao.AddDays(7);
                        int id = Alugados.lista_de_alugados.Count();
                        i.disposicao = (Disposicao)1;

                        Alugados.lista_de_alugados.Add(new Alugados(id,j,i,DateTime.Now,devolucao));
                        Console.WriteLine(Alugados.lista_de_alugados.ToString());
                    }
                }
            }

            Console.WriteLine("Criado e alugado!");
            Console.ReadLine();
        }

        public static void Adicionar_Carro()
        {
            int escolha = 0;
            try
            {
                while (escolha != 2)
                {
                    Console.Write("\n--------------------------------------\n");
                    int id = lista_de_carros.Count + 1;
                  
                    Console.Write("\nAdicione a matrícula do carro:\n->");
                    string matricula = Console.ReadLine();

                    Console.Write("\nAdicione a marca carro:\n-> ");
                    string marca = Console.ReadLine();

                    Console.Write("\nAdicione o modelo carro:\n-> ");
                    string modelo = Console.ReadLine();

                    Console.Write("\nAdicione o ano do carro:\n-> ");
                    int ano = Convert.ToInt16(Console.ReadLine());
                    
                    Console.Write("\nAdicione a Kilometragem do carro:\n-> ");
                    float km = Convert.ToInt16(Console.ReadLine());

                    lista_de_carros.Add(new Car(id, matricula, marca, modelo, ano, km, 0));
                    Console.Write("\nQuer adicionar mais um carro?  [1 - Sim /2 - Não]\n-> ");
                    escolha = Convert.ToInt16(Console.ReadLine());
                }
            }

            catch(FormatException) 
            {
                Console.WriteLine("Formato inválido!!!");
                Console.ReadLine();
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Não pode ser nulo, ou colocar um valor muito alto!!!");
                Console.ReadLine();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Não pode inserir valores estranho !?");
                Console.ReadLine();
            }
        }

        public static void Remover_Carro()
        {
            try
            {
                Console.Write("\n--------------------------------------\n");

                foreach (Car i in lista_de_carros) Console.WriteLine(i.ToString());

                Console.Write("\nEscolha o carro para remover da frota:\n[ID] -> ");
                int escolha = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Carro escolhido: \n");
                foreach (Car i in lista_de_carros)
                {
                    if (i.id == escolha)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }

                Console.Write("\nTem certeza que quer remover este carro? \n[1 - Sim /2 - Não] -> ");
                int escolha2 = Convert.ToInt16(Console.ReadLine());
                escolha--;

                if (escolha2 == 1)
                {
                    lista_de_carros.RemoveAt(escolha);
                }
            }

            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public override string ToString()
        {
            return "\nID " + id
                + "\nModelo - Marca: " + modelo + " - " + marca
                + "\nAno: " + ano
                + "\nMatrícula: " + matricula
                + "\nKM rodado: " + km
                + "\nDisposição: " + disposicao;
        }
    }
}
