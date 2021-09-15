using System;
using cuenta;

namespace cuenta
{
    class Emergencia : IEstrategia
    {
        public void Acreditar(Cliente cliente, double monto);
        {
            cliente.AcreditarEfectivo(monto);
        }
        public void Debitar(Cliente cliente, double monto);
        {
            if(cliente.Cuenta.TieneAlMenos(monto))
            {
                cliente.Cuenta.Debitar(monto);
            }
            eslse
            {
                monto -= cliente.Cuenta.VaciarCuenta();
                cliente.DebitarEfectivo(mpnto);
            }
        }
        public bool EsApto(Cliente cliente) => cliente.Efectivo < 10000;
    }
}