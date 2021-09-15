using cuenta;
using System;
using System.Collections.Generic;
using System.Text;

namespace cuenta
{
    class Emergencia : IEstrategia
    {
        public void Acreditar(Cliente, double monto)
        {
            cliente.AcreditarEfectivo(monto*0.5);
            cliente.Cuenta.Acreditar(monto*0.5);
        }
        public void Debitar(Cliente cliente, double monto)
        {
            if(cliente.TieneAlMenos(monto))
            {
                cliente.DebitarEfectivo(monto);
            }
            else
            {
                monto -= cliente.VaciarEfectivo();
                Cliente.Cuenta.DebitarEfectivo(monto);
            }
            public bool EsApto(Cliente cliente) => cliente.Efectivo > 50000;
        }
    }
}