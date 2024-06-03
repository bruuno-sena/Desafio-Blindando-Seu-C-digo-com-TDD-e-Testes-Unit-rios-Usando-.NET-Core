using System;
using System.Collections.Generic;
using System.Linq;

namespace NewProject
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        private void RegistrarHistorico(string operacao, double resultado)
        {
            listaHistorico.Insert(0, $"Operação: {operacao} = {resultado} - {data}");
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            RegistrarHistorico($"{num1} + {num2}", resultado);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            RegistrarHistorico($"{num1} - {num2}", resultado);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            RegistrarHistorico($"{num1} * {num2}", resultado);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            int resultado = num1 / num2;
            RegistrarHistorico($"{num1} / {num2}", resultado);
            return resultado;
        }

        public int Modulo(int num1, int num2)
        {
            int resultado = num1 % num2;
            RegistrarHistorico($"{num1} % {num2}", resultado);
            return resultado;
        }

        public double Potencia(int baseNum, int expoente)
        {
            double resultado = Math.Pow(baseNum, expoente);
            RegistrarHistorico($"{baseNum} ^ {expoente}", resultado);
            return resultado;
        }

        public double RaizQuadrada(double num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");
            }
            double resultado = Math.Sqrt(num);
            RegistrarHistorico($"√{num}", resultado);
            return resultado;
        }

        public double Seno(double angulo)
        {
            double resultado = Math.Sin(angulo);
            RegistrarHistorico($"sin({angulo})", resultado);
            return resultado;
        }

        public double Cosseno(double angulo)
        {
            double resultado = Math.Cos(angulo);
            RegistrarHistorico($"cos({angulo})", resultado);
            return resultado;
        }

        public double Tangente(double angulo)
        {
            double resultado = Math.Tan(angulo);
            RegistrarHistorico($"tan({angulo})", resultado);
            return resultado;
        }

        public double Logaritmo(double num, double baseLog = 10)
        {
            if (num <= 0)
            {
                throw new ArgumentException("O logaritmo não é definido para números menores ou iguais a zero.");
            }
            double resultado = Math.Log(num, baseLog);
            RegistrarHistorico($"log{baseLog}({num})", resultado);
            return resultado;
        }

        public List<string> Historico()
        {
            return listaHistorico.Take(3).ToList();
        }
    }
}
