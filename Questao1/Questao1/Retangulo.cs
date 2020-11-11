using System;
using System.Collections.Generic;
using System.Text;

namespace Questao1
{
    class Retangulo
    {
        private double Largura, Altura, area, Perimetro, Diagonal;


        public Retangulo(double Largura, double Altura)
        {
            this.Largura = Largura;
            this.Altura = Altura;
        }

        public double GetLargura()
        {
            return Largura;
        }

        public double GetAltura()
        {
            return Altura;
        }
        public double GetAreaRetangulo()
        {
            return area;
        }

        public double GetPerimetro()
        {
            return Perimetro;
        }

        public double GetDiagonal()
        {
            return Diagonal;
        }

        public void SetAreaRetangulo(double Largura, double Altura)
        {
            this.area = Largura * Altura;
        }

        public void SetPerimetro(double Largura, double Altura)
        {
            this.Perimetro = 2 * (Largura + Altura);
        }

        public void SetDiagonal(double Largura, double Altura)
        {
            this.Diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public void SetLargura(double Largura)
        {
            this.Largura = Largura;
        }

        public void SetAltura(double Altura)
        {
            this.Altura = Altura;
        }
    }
}
