﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExContaBancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }

        private string Titular { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria (int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria (int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta: " + Numero
                + ", Titular: " + Titular
                + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
