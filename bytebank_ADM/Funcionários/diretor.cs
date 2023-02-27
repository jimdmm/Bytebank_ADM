using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionários
{
    public class diretor:funcionario
    {

        public override double GetBonificacao()
        {
                return this.Salario + base.GetBonificacao();
        }
    }
}
