using System;

using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteCalculadoraTDD
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string data;

        public Calculadora(string data)
        {

            ListaHistorico = new List<string>();

            this.data = data;
        }

        public int Somar(int num1, int num2)
        {

            var resultado = num1 + num2;

            ListaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {

            var resultado = num1 - num2;

            ListaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {

            var resultado = num1 * num2;

            ListaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            var resultado = num1 / num2;

            ListaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);

            return ListaHistorico;
        }
    }
}
