using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1.Classes
{
    internal class Clientes
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Valor { get; protected set; }
        public double ValorImposto { get; protected set; }
        public double Total { get; protected set; }
        //Construtores
        public Clientes() 
        {
        }

        public virtual void PagarImposto( double v)
        {
           Valor = v;
           ValorImposto = Valor * 0.10;
           Total = Valor + ValorImposto;
        }
    }
}
