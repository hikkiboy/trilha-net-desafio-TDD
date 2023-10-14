using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public List<string> ListaHistorico = new List<string>();
        public int Somar(int n1, int n2)
        {
            string conta = $"{n1} + {n2}";
            ListaHistorico.Insert(0,conta);
            return n1+n2;
        }

        public int Subtrair (int n1, int n2)
        {
            string conta = $"{n1} - {n2}";
            ListaHistorico.Insert(0,conta);
            return n1 - n2;
        }

        public int Multiplicar (int n1, int n2)
        {
            string conta = $"{n1} * {n2}";
            ListaHistorico.Insert(0,conta);
            return n1 * n2;
        }
        
        public int Dividir(int n1, int n2)
        {
            string conta = $"{n1} / {n2}";
            ListaHistorico.Insert(0,conta);
            return n1 / n2;
        }
        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
        
      
    }
}