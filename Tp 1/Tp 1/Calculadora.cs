using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_1
{
    public class Calculadora
    {
        /// <summary>
        /// opera matemáticamente dos objetos del tipo Numero según se le indique
        /// </summary>
        /// <param name="numeroUno">primer operando</param>
        /// <param name="numeroDos">segundo operando</param>
        /// <param name="operador">String operador</param>
        /// <returns>[0]en caso de no poder realixzar la operador o el resultado en caso favorable</returns>
        public static double Operar (Numero numeroUno, Numero numeroDos,string operador)
        {
            double resultado = 0;
            switch(operador)
            {
                case "+":
                    resultado = numeroUno.GetNumero() + numeroDos.GetNumero();
                    break;
                case "-":
                    resultado = numeroUno.GetNumero() - numeroDos.GetNumero();
                    break;
                case "*":
                    resultado = numeroUno.GetNumero() * numeroDos.GetNumero();
                    break;
                case "/":
                    if (numeroDos.GetNumero() != 0)// si no entra el resultado es 0
                    {
                        resultado = numeroUno.GetNumero() / numeroDos.GetNumero();
                    }
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Verifica que el operador sea el correcto
        /// </summary>
        /// <param name="operador">string que sera validado</param>
        /// <returns>[+] en caso de error, el operando en caso favorable</returns>
        public static string ValidarOperador(string operador)
        {
            string retorno = "+";
            if(operador=="-"||operador=="*"||operador=="/")
            {
                retorno = operador;
            }
            return retorno;
        }

    }
}
