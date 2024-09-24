using System;
using System.Collections.Generic;

namespace Estacionamentoz.obj
{
    public class Estacionamento
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private const decimal taxaPorHora = 5.00m;

        public void AdicionarVeiculo(string placa)
        {
            var veiculo = new Veiculo(placa);
            veiculos.Add(veiculo);
            Console.WriteLine($"Veículo {placa} adicionado.");
        }

        public void RemoverVeiculo(string placa)
        {
            var veiculo = veiculos.Find(v => v.Placa == placa);
            if (veiculo != null)
            {
                decimal valorCobrado = CalcularValorCobrado(veiculo);
                veiculos.Remove(veiculo);
                Console.WriteLine($"Veículo {placa} removido. Valor cobrado: R$ {valorCobrado:F2}");
            }
            else
            {
                Console.WriteLine($"Veículo {placa} não encontrado.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo estacionado.");
                return;
            }

            Console.WriteLine("Veículos estacionados: ");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Placa: {veiculo.Placa}, Entrada: {veiculo.Entrada}");
            }
        }

        private decimal CalcularValorCobrado(Veiculo veiculo)
        {
            TimeSpan tempoEstacionado = DateTime.Now - veiculo.Entrada;
            return (decimal)Math.Ceiling(tempoEstacionado.TotalHours) * taxaPorHora;
        }
    }
}
