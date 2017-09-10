using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_1
{
    public class Numero
    {
        private double _numero;

        public Numero(): this(0)
        {

        }

        public Numero(string numero)
        {
            SetNumero(numero);
        }

        public Numero(double numero)
        {
            this._numero = numero;
        }
        
        /// <summary>
        /// retorna el valor del atributo numero
        /// </summary
        /// <returns>double numero</returns>
        public double GetNumero()
        {
            return this._numero;
        }

        /// <summary>
        /// setea el valor string al atributo numero
        /// </summary>
        /// <param name="numero">numero que sera seteado</param>
        private void SetNumero(string numero)
        {
            this._numero = ValidarNumero(numero);
        }

        /// <summary>
        /// valida que sea un numero el caracter ingresado y si lo es lo castea a double
        /// </summary>
        /// <param name="numeroString">numero que intentara ser casteado</param>
        /// <returns>[0] en caso de error y el numero casteado a double en caso de ser favorable</returns>
        private double ValidarNumero (string numeroString)
        {
            double numero;
            if(!double.TryParse(numeroString, out numero))
            {
                numero = 0;
            }
            return numero;
        }


    }
}
