using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionários
{
    public class funcionario
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }
        
        public double Salario { get; set; }
        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }
    }
}
