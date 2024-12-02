using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor.Pasteleria
{
   public class ProductorPast
    {
        private ColaPst<Cliente> _cola;
        public ProductorPast(ColaPst<Cliente> cola)
        {
            _cola = cola;
        }

        public void Producir(Cliente item)
        {
            _cola.Agregar(item);
            Thread.Sleep(2000);
        }
    }
}
