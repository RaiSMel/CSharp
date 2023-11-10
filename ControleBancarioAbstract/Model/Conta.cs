using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancarioAbstract.Model
{
    abstract class Conta
    {

        // Criação de atributos // 

        private double saldo;

        // Fim atributos

        // Criação Get e Set //

        public double getSaldo()
        {
            return saldo;
        }
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        // Fim Get e Set //

        // Criação Métodos //

        public void creditar(double valor)
        {
            if(valor > 0 )
            {
                setSaldo(getSaldo() + valor);
            }
        }
        
        public virtual bool debitar(double valor)
        {
            if(getSaldo() > valor && valor != 0)
            {
                setSaldo(getSaldo() - valor);
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public abstract void atualizarSaldos();

        // Fim Métodos //
    }
}
