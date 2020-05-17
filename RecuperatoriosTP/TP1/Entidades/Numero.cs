using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// Main de la clase Numero
    /// Contiene todos los metodos para definir la funcion que cumplen los numeros
    /// </summary>
    public class Numero
    {
        private double numero;

        #region Constructores
        /// <summary>
        /// Constructor por defecto que asigna 0 al atributo numero
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que recibe variable numero de tipo string y castea a double, asigna la variable al atributo de la clase
        /// </summary>
        /// <param name="numero">Variable numero</param>
        public Numero(string numero) : this()
        {
            this.SetNumero = numero;
        }

        /// <summary>
        /// Constructor que recibe la variable numero de tipo double y la asigna al atributo de la clase
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero) : this()
        {
            this.SetNumero = numero.ToString();
        }

        #endregion

        #region Propiedad
        /// <summary>
        /// Seteo del valor numerico validado al atributo numero de la clase
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }

        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo privado que valida si el valor recibido es numerico
        /// </summary>
        /// <param name="strNumero">Recibe numero de tipo string</param>
        /// <returns>Retorna valor numerico, sino, retorna 0</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            if (double.TryParse(strNumero, out double numero) && numero >= 0)
            {
                retorno = numero;
            }
            return retorno;
        }

        /// <summary>
        /// Metodo publico estatico que convierte el numero decimal en binario
        /// </summary>
        /// <param name="numero">Numero decimal de tipo double</param>
        /// <returns>Retorna el numero binario, de no ser posible retorna Valor Invalido</returns>
        public static string DecimalBinario(double numero)
        {
            string numeroBinario = "";
            double NumAbsoluto = Math.Abs(numero);
            long cociente = (long)NumAbsoluto;
            long resto = (long)NumAbsoluto;

            if (cociente >= 1)
            {
                while (cociente >= 1)
                {
                    resto = cociente % 2;
                    cociente = cociente / 2;

                    if (resto != 0)
                    {
                        numeroBinario = "1" + numeroBinario;
                    }
                    else
                    {
                        numeroBinario = "0" + numeroBinario;
                    }
                }
                return numeroBinario;
            }
            else
                return "Valor Invalido";
        }

        /// <summary>
        /// Metodo publico que sobrecarga el metodo DecimalBinario
        /// Castea el numero string a double y realiza la conversion a binario
        /// </summary>
        /// <param name="numero">Numero decimal de tipo string</param>
        /// <returns>Retorna el numero binario, caso contrario retorna valor invalido</returns>
        public string DecimalBinario(string numero)
        {
            double numeroAux;
            string retorno = "";
            if (double.TryParse(numero, out numeroAux))
            {
                retorno = DecimalBinario(numeroAux);
            }
            return retorno;
        }

        /// <summary>
        /// Metodo publico estatico que convierte el numero binario a decimal
        /// </summary>
        /// <param name="binario">Numero binario de tipo string</param>
        /// <returns>Retorna el numero decimal convertido, caso contrario retorna Valor Invalido</returns>
        public string BinarioDecimal(string binario)
        {
            double NumeroDecimal = 0, binarioDouble, NumAbsoluto;
            int potencia = 1;
            string NumAbsolutoStr = "";

            if (EsBinario(binario))
            {
                if (double.TryParse(binario, out binarioDouble))
                {
                    NumAbsoluto = Math.Abs(binarioDouble);
                    NumAbsolutoStr = Convert.ToString(NumAbsoluto);
                }
                else
                    NumAbsolutoStr = "Valor Invalido";

                for (int i = NumAbsolutoStr.Length - 1; i >= 0; i--)
                {
                    if (binario[i] == '1')
                    {
                        NumeroDecimal += potencia;
                    }
                    potencia *= 2;
                }
                NumAbsolutoStr = Convert.ToString(NumeroDecimal);
            }
            return NumAbsolutoStr;
        }

        private bool EsBinario(string binario)
        {
            
            if (binario.Contains("0") || binario.Contains("1"))
            {
                return true;
            }
            else
                return false;
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Metodo publico estatico que sobrecarga el operador +
        /// </summary>
        /// <param name="n1">Variable numero1 de tipo Numero que recibe para realizar la sobrecarga</param>
        /// <param name="n2">Variable numero2 de tipo Numero que recibe para realizar la sobrecarga</param>
        /// <returns>Retorna un double de la suma de los dos numeros</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Metodo publico estatico que sobrecarga el operador -
        /// </summary>
        /// <param name="n1">Variable numero1 de tipo Numero que recibe para realizar la sobrecarga</param>
        /// <param name="n2">Variable numero2 de tipo Numero que recibe para realizar la sobrecarga</param>
        /// <returns>Retorna un double de la resta de los dos numeros</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Metodo publico estatico que sobrecarga el operador *
        /// </summary>
        /// <param name="n1">Variable numero1 de tipo Numero que recibe para realizar la sobrecarga</param>
        /// <param name="n2">Variable numero2 de tipo Numero que recibe para realizar la sobrecarga</param>
        /// <returns>Retorna un double de la multiplicacion de los dos numeros</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Metodo publico estatico que sobrecarga el operador /
        /// </summary>
        /// <param name="n1">Variable numero1 de tipo Numero que recibe para realizar la sobrecarga</param>
        /// <param name="n2">Variable numero2 de tipo Numero que recibe para realizar la sobrecarga</param>
        /// <returns>Retorna un double de la division de los dos numeros, 
        /// si es una division por 0 retorna el valor minimo de double</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno;
            if (n2.numero == 0)
            {
                retorno = Double.MinValue;
            }
            else
            {
                retorno = n1.numero / n2.numero;
            }
            if (n1.numero < n2.numero)
            {
                retorno = Math.Round(n1.numero / n2.numero, 6);
            }
            return retorno;
        }
        #endregion
    }
}
