using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1.Classes
{
    internal class PessoaJuridica : Clientes
    {
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        //Construtores
        public PessoaJuridica() 
        {
        }

        public override void PagarImposto(double v)
        {
            Valor = v;
            ValorImposto = Valor * 0.20;
            Total = Valor + ValorImposto;
        }
    }
    
}
