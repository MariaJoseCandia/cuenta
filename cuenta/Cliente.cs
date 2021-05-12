using System;
using System.Collections.Generic;
using System.Text;

namespace cuenta
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Efectivo { get; set; }
        public double Saldo { get; set; }
        public int Cbu { get; set; } = 0;
        
       
        public Cuenta Cuenta { get; set; }

        public Cliente()
        {
            Cuenta = new Cuenta();
            Efectivo = 0;
            Saldo = 0;
        }

        public void Acreditar(double monto)
        {
            Saldo = Saldo + monto * 0.8;
            Cuenta.Acreditar(monto * 0.2);
        }
        public void Debitar(double monto)
        {
            Saldo = Saldo - monto * 0.8;
            Cuenta.Debitar(monto * 0.2);
        }

        public bool TieneAlMenos(double monto) => Saldo >= monto;
    }
}
