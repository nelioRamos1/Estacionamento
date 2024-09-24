using System;

namespace Estacionamentoz.obj
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();

            estacionamento.AdicionarVeiculo("abc-1234");
            estacionamento.AdicionarVeiculo("xyz-5678");
            estacionamento.ListarVeiculos();
            estacionamento.RemoverVeiculo("abc-1234");
            estacionamento.ListarVeiculos();
        }
    }
}
