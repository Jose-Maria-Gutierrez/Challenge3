using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Alumno
    {
        private int numero;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;

        public int _numero()
        {
            return this.numero;
        }

        public double notas()
        {
            return this.nota1 + this.nota2 + this.nota3 + this.nota4;
        }

        public Alumno(int numero,double nota1,double nota2,double nota3,double nota4)
        {
            this.numero = numero;
            this.nota1 = nota1; 
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
        }

    }
}
