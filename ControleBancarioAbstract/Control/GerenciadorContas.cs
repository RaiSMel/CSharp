using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBancarioAbstract.Model;

namespace ControleBancarioAbstract.Control
{
    class GerenciadorContas 
    {

        // Criação atributos //

        private double saldoTotal;

        // Fim atributos //

        // Criação Get e Set // 

        public double getSaldoTotal()
        {
            return saldoTotal;
        }
        public void setSaldoTotal(double saldoTotal)
        {
            this.saldoTotal = saldoTotal;
        }

        // Fim Get e Set //

        // Criação Construtores // 

        public GerenciadorContas()
        {
            saldoTotal = 0.0;
        }
        public GerenciadorContas(double saldoTotal)
        {
            this.saldoTotal = saldoTotal;
        }

        // Fim Construtores // 

        // Criação Métodos // 

        public void totalizarSaldos(Conta conta)
        {
            setSaldoTotal(getSaldoTotal() + conta.getSaldo());
        }

        // Fim Métodos

    }
}

