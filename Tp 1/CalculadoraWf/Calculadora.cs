using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_1;

namespace CalculadoraWf
{
    public partial class Calculadora : Form
    {
        Numero numeroUno = new Numero();
        Numero numeroDos = new Numero();
        Numero resultado = new Numero();
        string operador;

        public Calculadora()
        {
            InitializeComponent();
        }
        // resultado
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        //numero1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numeroUno = new Numero(this.textBox1.Text);
            this.textBox1.Text = numeroUno.GetNumero().ToString();
        }
        //numero2
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            numeroDos = new Numero(this.textBox2.Text);
            this.textBox2.Text = numeroDos.GetNumero().ToString();
        }
        //operador
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }
        //CC(limpiar)
        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        //igual
        private void button2_Click(object sender, EventArgs e)
        {

            operador = Tp_1.Calculadora.ValidarOperador(this.comboBox1.Text);
            resultado = new Numero(Tp_1.Calculadora.Operar(numeroUno,numeroDos,operador));
            this.comboBox1.Text = operador;
            this.label1.Text = resultado.GetNumero().ToString();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";
            this.label1.Text = "0";
            this.comboBox1.Text = "+";  
        }
    }
 
}
