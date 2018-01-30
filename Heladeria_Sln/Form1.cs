using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria_Sln
{
    public partial class frmPrincipal : Form
    {
        OrdenCompra orden;
        Helado Helado;
        topping Topping;
        public frmPrincipal()
        {
            InitializeComponent();
            orden = new OrdenCompra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularOrden();

        }

        private void CalcularOrden()
        {
            if (rbtnChocolate.Checked)
            {
                Helado = new Chocolate();
                orden.AgregarHelado(Helado);
            }
            else
            {
                if (rbtnCrema.Checked)
                {
                    Helado = new Crema();
                    orden.AgregarHelado(Helado);
                }
                else
                {
                    if (rbtnFresa.Checked)
                    {
                        Helado = new Fresa();
                        orden.AgregarHelado(Helado);
                    }
                }
            }

            if (chkCaramelo.Checked)
            {
                Topping = new Caramelo();
                orden.AgregarTopping(Topping);
            }

            if (chkMani.Checked)
            {
                Topping = new Mani();
                orden.AgregarTopping(Topping);
            }

            if (chkOreo.Checked)
            {
                Topping = new Oreo();
                orden.AgregarTopping(Topping);
            }


            txtTotal.Text = orden.CalcularTotal().ToString();


        }
    }
}
