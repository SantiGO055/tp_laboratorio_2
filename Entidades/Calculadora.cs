using System;

namespace Entidades
{
    /// <summary>
    /// Main de la clase Calculadora
    /// Contiene todos los metodos para definir el funcionamiento de la calculadora
    /// </summary>
    public static class Calculadora
    {
        /// <summary>
        /// Metodo privado estatico que valida si el operador es correcto
        /// </summary>
        /// <param name="operador">Recibe Operador de tipo string</param>
        /// <returns>Retorna el operador validado, caso contrario retorna un +</returns>
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";
            if ((operador == "+") || (operador == "-") || (operador == "*") || (operador == "/"))
            {
                retorno = operador;
            }
            else
                retorno = "+";
            return retorno;
        }

        /// <summary>
        /// Metodo publico estatico que realiza la operacion de los numeros
        /// </summary>
        /// <param name="n1">Variable numero1 de tipo Numero que recibe para realizar la operacion</param>
        /// <param name="n2">Variable numero2 de tipo Numero que recibe para realizar la operacion</param>
        /// <param name="operador">Variable de tipo string que recibe el operador</param>
        /// <returns>Retorna el resultado de la operacion de ambos numeros</returns>
        public static double Operar(Numero n1, Numero n2, string operador)
        {
            double resultado = 0;
            operador = ValidarOperador(operador);

            switch (operador)
            {
                case "+":
                    resultado = n1 + n2;
                    break;
                case "-":
                    resultado = n1 - n2;
                    break;
                case "*":
                    resultado = n1 * n2;
                    break;
                case "/":
                    resultado = n1 / n2;
                    break;
            }
            return resultado;
        }
    }
}
