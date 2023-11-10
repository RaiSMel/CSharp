using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer.Properties
{
    class Custos
    {
        Percurso p = new Percurso();

        public string calcularViagem(Percurso p)
        {
            return p.listarPercurso() + "\nValor do percurso é igual à: " + ((p.getkmPercorrido()*p.getValorCombustivel())+p.getValorPedagio()) ;
        }
    }
}
