using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using banco.Estrategia;

namespace cuenta
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Efectivo { get; set; }
        public double Saldo => Efectivo + Saldo;
        public Cuenta Cuenta { get; set; }
        public IEstrategia Estrategia{get; set;}
        public Cliente()
        {
            Cuenta = new Cuenta();
            Efectivo = 0;
        }
        public int Cbu => Cuenta.Cbu;
        public void Acreditar(double monto)
        {
            Estrategia.Acreditar(this, monto);
            if (!Estrategia.EsApto(this))
            {
                Estrategias.EstrategiaPara(this);
            }
        }
        public void Debitar(double monto)
        {
            Estrategia.Debitar(this, monto);
            if (!Estrategia.EsApto(this))
            {
                Estrategias.EstrategiaPara(this);
            }
        }
        public bool TieneAlMenos(double monto) => Saldo >= monto;
        public void DebitarEfectivo(double monto) => Efectivo -= monto;
        public void AcreditarEfectivo(double monto) => Efectivo += monto;
        internal double VaciarEfectivo()
        {
            var Efectivo = this.Efectivo;
            Efectivo = 0;
            return Efectivo;
        }
    }
}