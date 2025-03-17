using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_exercicio_POO.Models
{   
    internal class CirculoClass
    {
        // atributo privado, que nao pode ser acessado diretamente fora da classe
        private double Raio {  get; set; }
    
        // metodo construtor que recebe raio como parametro
        public CirculoClass(double Raio)
        {
            SetRaio (Raio);
        }

        private void SetRaio(double raio)
        {
            if (Raio > 0)
            {
                this.Raio = raio;
            }
            else
            {
                // lança uma execao caso o raio seja menor que zero
                throw new ArgumentException("O raio deve ser número positivo"); 

            }
        }

        // metodo publico que calcula a area
        public double CalcularArea()
        { 
            return Math.PI*(this.Raio * this.Raio);
            
        }

        // metodo que calcula o perimetro
        public double CalcularPerimetro()
        {
            double ValoreCalcularPerimetro = 2 * Math.PI * this.Raio;
            return ValoreCalcularPerimetro;
        
        }


    }
}
