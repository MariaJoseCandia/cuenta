using cuenta;

namespace banco.Estrategias
{
    public interface IEstrategia
    {
        void Debitar(Cliente cliente, double monto);
        void Acreditar(Cliente cliente, double monto);
        bool EsApto(Cliente cliente);
        static List<IEstrategia> Estra = new List<IEstrategia>()
        {
          new Ahorro(),
          new Cauto(),
          new Emergencia(),
        };
        public static IEstrategia EstrategiaPara(Cliente cliente)
        => (Estra.FirstOrDefault(e => e.EsApto(cliente)));
    }
}