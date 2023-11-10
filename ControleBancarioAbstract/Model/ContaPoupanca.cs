using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBancarioAbstract.Model;
using ControleBancarioAbstract.Control;

namespace ControleBancarioAbstract.Model
{
    class ContaPoupanca : Conta
    {

        // Criação de atributos // 

        private double reajusteMensal;

        // Fim atributos

        // Criação Get e Set //

        public double getReajusteMensal()
        {
            return reajusteMensal;
        }

        public void setReajusteMensal(double reajusteMensal)
        {
            this.reajusteMensal = reajusteMensal;
        }

        // Fim Get e Set //

        // Criação Construtores // 

        public ContaPoupanca()
        {
            reajusteMensal = 0.0;
            setSaldo(0.0);
        }

        public ContaPoupanca(double reajusteMensal, double saldo)
        {
            this.reajusteMensal = reajusteMensal;
            setSaldo(saldo);
        }

        // Fim Construtores // 

        // Criação Métodos //

        public override void atualizarSaldos()
        {
            atualizarSaldos();
        }

        public void atualizarSaldos(double reajuste)
        {
            reajuste = getReajusteMensal();
            if (reajuste > 0 && reajuste <= 1){
                setSaldo(getSaldo() * (getSaldo() * reajuste ));
            }
        }

        // Fim Métodos //

    }
}
