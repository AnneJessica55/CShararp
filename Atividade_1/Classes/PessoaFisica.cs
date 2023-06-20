using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1.Classes
{
    internal class PessoaFisica :Clientes
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }

        //Construtores
       public  PessoaFisica()
        {

        }

    }
}