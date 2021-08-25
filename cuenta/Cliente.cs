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
        public Estrategia IEstrategia;
        public Cliente()
        {
            Cuenta = new Cuenta();
            Efectivo = 0;
        }
        public int Cbu => Cuenta.Cbu;
        public void Acreditar(double monto)
        {
            Estrategia.Acreditar(this.monto)
            if (!Estrategia.EsApto(this))
            {
                Estrategias.EstrategiaPara(this);
            }
        }
        public void Debitar(double monto)
        {
            Estrategia.Debitar(this.monto)
            if (!Estrategia.EsApto(this))
            {
                Estrategias.EstrategiaPara(this);
            }
        }
        public bool TieneAlMenos(double monto) => Saldo >= monto;
    }
}
