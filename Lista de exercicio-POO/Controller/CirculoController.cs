using Lista_de_exercicio_POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_exercicio_POO.Controller
{

    // classe controladora para circulos relacionado a circulo
    internal class CirculoController
    {
        // metodo publio estatico para calcular o circulo 
        public static (string Message, MessageBoxIcon icone )CalculaCirculo(string input)
        {
            if (Double.TryParse(input, out double valorConvertido))
            {
                //cria instancia da classe circulo class
                CirculoClass circulo = new CirculoClass(valorConvertido);


                string resultado = $"Área:{circulo.CalcularArea()}\nPerimetro:{circulo.CalcularPerimetro()}";



            }
            else
            {
                //

            }
            
        }

    }

}
