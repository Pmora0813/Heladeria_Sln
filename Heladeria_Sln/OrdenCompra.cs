using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria_Sln
{
    class OrdenCompra 
    {
        public Cono cono { get; set; }
        public OrdenCompra()
        {
            cono = new Cono();
            cono.Topping = new List<topping>();
        }

        public void AgregarHelado(Helado Helado)
        {
            cono.Helado = Helado;
        }

        public void AgregarTopping( topping Topping)
        {
            cono.Topping.Add(Topping);
        }

        public double CalcularTotal()
        {
            double total = 0;
            total = cono.Helado.Costo();

            foreach (topping topp in cono.Topping)
            {
                total += topp.Precio();
            }

            return total;
        }

    }
}
