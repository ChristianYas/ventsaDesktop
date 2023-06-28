using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasDesktop.Models
{
    class ViewSale
    {
        public Product product { get; set; }

        public Sale sale { get; set; }

        public ViewSale() { }

        public ViewSale(Product product, Sale sale)
        {
            this.product = product;
            this.sale = sale;
        }
    }
}
