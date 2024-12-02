using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor.Pasteleria
{
    public class ConsumidorPst
    {
        private ColaPst<Cliente> _cola;

        public ConsumidorPst(ColaPst<Cliente> cola)
        {
            _cola = cola;
        }

        public Cliente Consumir()
        {
            Cliente cliente = _cola.Extraer();
            Thread.Sleep(5000);
            return cliente;
        }
    }
}
    

