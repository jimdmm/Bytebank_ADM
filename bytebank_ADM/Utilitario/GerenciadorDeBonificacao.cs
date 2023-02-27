using bytebank_ADM.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double totalDeBonificacao { get; private set; }

        public void registrar(funcionario funcionario)
        {
            this.totalDeBonificacao += funcionario.GetBonificacao();
        }
    }
}
