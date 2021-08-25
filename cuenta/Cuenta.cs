using System;
using System.Collections.Generic;
using System.Text;

namespace cuenta
{
    class Cuenta
    {
        private int Contador { get; set; } = 0;
        public int Cbu { get; set; }
        public double Saldo { get; set; }
        public Cuenta()
        {
            Contador++;
            Cbu=Contador;
            Saldo = 0;
        }
        public void Acreditar(double monto) => Saldo += monto;
        public void Debitar(double monto) => Saldo -= monto;
        public bool TieneAlMenos(double monto) => Saldo >= monto;
    }
}
