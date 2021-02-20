using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ex03
{
    class Funcionarios
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salario { get; private set; }

        public Funcionarios(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void Aumento(double porcent)
        {
            Salario += Salario * porcent / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
