using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class CalculadoraDIO
    {
        private List<string> listahistorico;
        private string data;
        public CalculadoraDIO(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }
        public int somar(int val1, int val2)
        {
            var result = val1 + val2;
            
            listahistorico.Insert(0, "res:" + result+ " data:" +data);
            return result;
        }

        public int subtrair(int val1, int val2)
        {
            var result = val1 - val2;
            listahistorico.Insert(0, "res:" + result + " data:" + data);
            return result;
        }

        public int multiplicar(int val1, int val2)
        {
            var result = val1 * val2;
            listahistorico.Insert(0, "res:" + result + " data:" + data);
            return result;
           
        }

        public int dividir(int val1, int val2)
        {
            var result = val1 / val2;
            listahistorico.Insert(0, "res:" + result + " data:" + data);
            return result;
        }

        public List<string> historico()
        {
            List<string> res;
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}
