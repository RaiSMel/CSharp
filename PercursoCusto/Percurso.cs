using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer.Properties
{
    class Percurso
    {
        private double kmPercorrido;
        private double valorCombustivel;
        private double valorPedagio;

        public double getValorPedagio()
        {
            return valorPedagio;
        }
        public void setValorPedagio(double valorPedagio)
        {
            this.valorPedagio = valorPedagio;
        }
        public double getValorCombustivel()
        {
            return valorCombustivel;
        }
        public void setValorCombustivel(double valorCombustivel)
        {
            this.valorCombustivel = valorCombustivel;
        }
        public double getkmPercorrido()
        {
            return kmPercorrido;
        }
        public void setKmPercorrido(double kmPercorrido)
        {
            this.kmPercorrido = kmPercorrido;
        }
        public Percurso()
        {
            valorCombustivel = 0.0;
            valorPedagio = 0.0;
            kmPercorrido = 0.0;
        }
        public Percurso(double valorPedagio, double valorCombustivel, double kmPercorrido )
        {
            this.valorPedagio = valorPedagio;
            this.valorCombustivel = valorCombustivel;
            this.kmPercorrido = kmPercorrido;
        }
        public string listarPercurso()
        {
            return "o valor do pedágio é: " + valorPedagio +  "\no valor do combustível é: " + valorCombustivel + "\na kilometrâgem é igual à: " + kmPercorrido;
        }
    }
}
