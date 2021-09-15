using System;
using cuenta;

namespace cuenta
{
    class Cauto : IEstrategia
    {
        public void Acreditar(Cliente cliente, double monto)
        {
            cliente.AcreditarEfectivo(monto*0.8);
            cliente.Cuenta.Acreditar(monto*0.2);
        }
        public void Debitar(Cliente cliente, double monto)
        {
            cliente.DebitarEfectivo(monto*0.8);
            cliente.Cuenta.Debitar(monto*0.2);
        }
        public bool EsApto(Cliente cliente) => cliente.Efectivo >= 10000 && cliente.Efectivo <= 50000
    }
}