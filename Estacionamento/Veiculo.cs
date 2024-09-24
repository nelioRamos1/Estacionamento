using System;

namespace Estacionamentoz.obj
{
    public class Veiculo
    {
        public string Placa { get; }
        public DateTime Entrada { get; }

        public Veiculo(string placa)
        {
            Placa = placa;
            Entrada = DateTime.Now;
        }
    }
}
