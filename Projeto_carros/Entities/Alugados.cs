using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_carros.Entities
{
    internal class Alugados
    {
        public static List<Alugados> lista_de_alugados { get; set; } = new List<Alugados>();
        public int id { get; set; }
        public Client client { get; set; }
        public Car car { get; set; }

        public DateTime data_alugada { get; set; }
        public DateTime data_devolucao { get; set; }

        public Alugados(int id, Client client, Car car, DateTime data_alugada, DateTime data_devolucao)
        {
            this.id = id;
            this.client = client;
            this.car = car;
            this.data_alugada = data_alugada;
            this.data_devolucao = data_devolucao;
        }

        public override string ToString()
        {
            return "ID do Cliente: " + client
                + "\nID_Carro: " + car
                + "\nData Alugado: " + data_alugada
                + "\nData da devolução: " + data_devolucao;
        }
    }
}
