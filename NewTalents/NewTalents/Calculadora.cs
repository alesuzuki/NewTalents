using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {

        private List<string> listaHistorico;
        private DateTime agora;

        public Calculadora()
        {
            listaHistorico = new List<string>();
            agora = DateTime.Now;
        }

        private void inserirNoHistorico(object res)
        {
            listaHistorico.Insert(0, $"Resultado : {res}, data - {agora:dd/MM/yy - HH:mm:ss}");
        }

        public int somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            inserirNoHistorico(resultado);
            return resultado;
        }

        public int subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            inserirNoHistorico(resultado);
            return resultado;
        }

        public int multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            inserirNoHistorico(resultado);
            return resultado;
        }

        public double dividir(double val1, double val2)
        {
            if (val2 == 0)
            {
                throw new DivideByZeroException();
            }

            double resultado = val1 / val2;
            inserirNoHistorico(resultado);
            return resultado;
        }

        public List<string> Historico()
        {
            if (listaHistorico.Count < 1)
            {
                throw new Exception("Lista vazia");
            }

            int counter = listaHistorico.Count - 3;
            listaHistorico.RemoveRange(0, counter);

            return listaHistorico;
        }

    }
}
