using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancarioAbstract.Model
{
    class ContaCorrente : Conta
    {

        // Criação de atributos // 
        
        private double limiteEspecial;

        // Fim atributos

        // Criação Get e Set //

        public double getLimiteEspecial()
        {
            return limiteEspecial;
        }

        public void setLimiteEspecial(double limiteEspecial)
        {
            this.limiteEspecial = limiteEspecial;
        }

        // Fim Get e Set //

        // Criação Construtores // 

        public ContaCorrente()
        {
            limiteEspecial = 0.0;
            setSaldo(0.0);
        }

        public ContaCorrente(double limiteEspecial, double saldo)
        {
            this.limiteEspecial = limiteEspecial;
            setSaldo(saldo);
        }

        // Fim Construtores // 
        
        // Criação Métodos //

        public override void atualizarSaldos()
        {
            if(getSaldo() < 0)
            {
                setSaldo(getSaldo() * 1.08);
            }
        }

        public override bool debitar(double valor)
        {
            
            if( (valor < getLimiteEspecial() + getSaldo()) && (valor > 0))
            {
                setSaldo( getSaldo() - valor );
                return true;
            }
            else
            {
                return false;
            }
        }

        // Fim Métodos //

    }
}
