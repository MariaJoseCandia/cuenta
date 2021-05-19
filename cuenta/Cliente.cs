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
        public double Saldo => Efectivo + Saldo;
       
       
        public Cuenta Cuenta { get; set; }

        public Cliente()
        {
            Cuenta = new Cuenta();
            Efectivo = 0;
        }

        public int Cbu => Cuenta.Cbu;

        public void Acreditar(double monto)
        {
            Efectivo = Efectivo + monto * 0.8;
            Cuenta.Acreditar(monto * 0.2);
        }
        public void Debitar(double monto)
        {
            Efectivo = Efectivo - monto * 0.8;
            Cuenta.Debitar(monto * 0.2);
        }

        public bool TieneAlMenos(double monto) => Saldo >= monto;

        
    }
}
