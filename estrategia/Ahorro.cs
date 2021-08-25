using cuenta;

namespace cuenta
{
    class Emergencia : IEstrategia
    {
        void Debitar(Cliente cliente, double monto)
        {
            
        }
        void Acreditar(Cliente cliente, double monto);
        bool EsApto(Cliente cliente);
    }
}