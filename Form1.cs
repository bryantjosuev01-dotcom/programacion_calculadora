using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_BV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variables
        String operador = "0";
        Double num1 = 0;
        Double num2 = 0;

 
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 1) textBox1.Text = "0";
            else textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnuno_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "1";
        }

        private void btndos_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "2";
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "3";
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "4";
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "5";
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "6";
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "7";
        }

        private void btnocho_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "8";
        }

        private void btncero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        public void btnigual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);
            double resultOperation = 0;

            switch (operador)
            {
                case "+":
                    resultOperation = num1 + num2;
                    break;

                case "-":
                    resultOperation = num1 - num2;
                    break;

                case "*":
                    resultOperation = num1 * num2;
                    break;

                case "/":
                    if (num2 != 0) // Evitar división por cero
                    {
                        resultOperation = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.");
                        return;
                    }
                    break;
                case "%":
                    if (num2 != 0)
                    {
                        resultOperation = num1 % num2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede calcular el residuo con divisor cero.");
                        return;
                    }
                    break;
                case "^":
                    resultOperation = Math.Pow(num1,num2);
                    break;
                case "log":
                    resultOperation = Math.Log(num1,num2);
                    break;


                case "raiz":
                    resultOperation = Math.Sqrt(num1);
                    break;

                case "PI":
                  
                    resultOperation = num1 *3.1416;
                    

                    break;
                case "seno":
                    resultOperation = Math.Sin(num1);
                    break;
                    




                default:
                    MessageBox.Show("Operación no válida.");
                    return;
            }

            textBox1.Text = resultOperation.ToString();
        }
        private double memoryValue = 0;

        private void button7_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double valor))
            {
                memoryValue += valor;
                MessageBox.Show("Memoria = " + memoryValue);
            }
            else
            {
                MessageBox.Show("Número inválido.");
            }
        }

        private void btnexpo_Click(object sender, EventArgs e)
        {
            operador = "^";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);
            if (valor > 0)
            {
                double resultado = Math.Log(valor); // logaritmo natural
                textBox1.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("El logaritmo solo está definido para números positivos.");
            }
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);
            double resultado = Math.Sqrt(valor);
            textBox1.Text = resultado.ToString();

        }

        private void btnPI_Click(object sender, EventArgs e)
        {

            textBox1.Text = Math.PI.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
            MessageBox.Show("Memoria borrada.");
        }


        private void button6_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);
            double resultado = Math.Sin(valor);
            textBox1.Text = resultado.ToString();
        }

        private void btnmr_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double valor))
            {
                memoryValue -= valor;
                MessageBox.Show("Memoria = " + memoryValue);
            }
            else
            {
                MessageBox.Show("Número inválido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = memoryValue.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                double grados = Convert.ToDouble(textBox1.Text);
                double radianes = grados * Math.PI / 180.0; // Conversión a radianes
                double resultado = Math.Cos(radianes);
                textBox1.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Número inválido en pantalla.");
            }
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("recuerde insertar en grados");
                double grados = Convert.ToDouble(textBox1.Text);
                double radianes = grados * Math.PI / 180.0; // Conversión a radianes
                double resultado = Math.Tan(radianes);
                textBox1.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Número inválido en pantalla.");
            }
        }

        private void btnfacto_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            if (n < 0)
            {
                MessageBox.Show("No existe el factorial de números negativos.");
                return;
            }
            long resultado = 1;
            for (int i = 1; i <= n; i++)//El ciclo iterara hasta que llegue al numero ingresado en pantalla
                resultado *= i;

            textBox1.Text = resultado.ToString();
        }
    }
}
