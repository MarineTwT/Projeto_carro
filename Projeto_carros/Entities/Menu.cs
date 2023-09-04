using System;

namespace Entities
{
    internal class Menu
    {
        

        public static void Mostrar_menu()
        {
            Console.Write("\nAluguel Pablo´s:" +
                          "\nQual das seguintes opções quer fazer\n1 - Mostrar:" +
                          "\n2 - Adicionar um carro novo na frota:\n3 - Remover um carro: \n4 - Alugar um carro: " +
                          "\n5 - Devolver um carro: \n6 - Sair \n-> ");
        }      

        public static void Chamar_menu() 
        {
            int opcao = 0;

            do
            {
                Mostrar_menu();

                try
                {
                    opcao = Convert.ToInt16(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            
                        Console.Write("\n1 - Mostrar frotas: \n2 - Mostrar Clientes:\n->");
                        int opcao2 = Convert.ToInt16(Console.ReadLine());
                        Console.Clear();
                        if (opcao2 == 1) Car.Mostrar_frota();
                        else if (opcao2 == 2) Client.Mostrar_clientes();
                        break;
                            

                        case 2:
                            
                        Car.Adicionar_Carro();
                        Console.Clear();
                        break;
                            

                        case 3:
                            
                        Car.Remover_Carro();
                        Console.Clear();
                        break;
                            

                        case 4:
                            
                        Car.Alugar_Carro();
                        Console.Clear();
                        break;
                            

                        case 5:
                            
                        Car.Devolver_carro();
                        Console.Clear();
                        break;
                            

                        case 6:
                            
                        Console.WriteLine("\nTenha um bom dia!\n");
                        Thread.Sleep(2000);
                        break;
                            
                        default:
                        break;
                            
                    }
                }

                catch (FormatException)
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

            } while (opcao != 6);
                       
        }

    }
}

