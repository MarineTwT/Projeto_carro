using Entities.Enums;
using System.Collections;

namespace Entities
{

    internal class Car
    {
        public static List<Car> lista_de_carros { get; set; } = new List<Car>();

        public int ano { get; private set; }
        public  int km { get; private set; }
        public Disposicao disposicao { get; private set; }
        public int id { get; private set; }

        public string matricula { get; private set; }
        public string marca { get; private set; }
        public string modelo { get; private set; }

        public Car(int id, string matricula, string marca, string modelo, int ano, int km, Disposicao disposicao)
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
            foreach (Car i in lista_de_carros) i.Mostrar_dados();           
        }

        public static void Devolver_carro()
        {
            if (Client.lista_de_clientes.Count <= 0) Console.WriteLine("Não possui carros para devolver...");
            
            else
            {
                int carro_temp;
                Console.WriteLine("\nDevolvendo um carro:");

                Client.Mostrar_clientes();
                Console.WriteLine("Qual cliente está devolvendo?");
                Console.Write("\n[Código] -> ");
                int codigo = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("\nQuantos KM´s o carro andou?");
                Console.Write("\n[KM] -> ");
                int km = Convert.ToInt32(Console.ReadLine());

                foreach (Client i in Client.lista_de_clientes)
                {
                    foreach (Car k in Car.lista_de_carros)
                    {
                        if (i.codigo == codigo)
                        {
                            carro_temp = i.carro;

                            if (k.id == carro_temp)
                            {
                                k.disposicao = 0;
                                k.km = km;
                            }
                        }
                    }
                }
            }

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
                    int km = Convert.ToInt16(Console.ReadLine());

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
            Console.Write("\n--------------------------------------\n");

            foreach (Car i in lista_de_carros) i.Mostrar_dados();

            Console.Write("\nEscolha o carro para remover da frota:\n[ID] -> ");
            int escolha = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Carro escolhido: \n");
            foreach (Car i in lista_de_carros)
            {
                if (i.id.Equals(escolha))
                {
                    i.Mostrar_dados();
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

        public void Mostrar_dados()
        {
            Console.WriteLine("\n--- Carro ---\n");
            Console.WriteLine("ID {0}", id);
            Console.WriteLine("Modelo - Marca: {0} - {1}", modelo, marca);
            Console.WriteLine("Ano: {0} ", ano);
            Console.WriteLine("Matrícula: {0} ", matricula);
            Console.WriteLine("KM rodado: {0} ", km);
            Console.WriteLine("Disposição: " + disposicao.ToString());
        }

        /*public override string ToString()
        {
            return "\n--- Carro ---\n"
                + "\nID " + id
                + "\nModelo - Marca: " + modelo + " - " + marca
                + "\nAno: " + ano
                + "\nMatrícula: " + matricula
                + "\nKM rodado: " + km
                + "\nDisposição: " + disposicao;
        }*/
    }
}
