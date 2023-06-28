using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasDesktop.Controllers;
using VentasDesktop.Models;

namespace VentasDesktop.Forms
{
    public partial class ExistingProducts : Form
    {
        public ExistingProducts()
        {
            InitializeComponent();

            fillTable();
        }

        public async Task fillTable()
        {

            ControllerExistingProducts ce = new ControllerExistingProducts();

            List<ViewSale> allSalesList = await ce.getExistingProducts();

            foreach (var item in allSalesList)
            {
                Product product = item.product;

                int idProduct = product.idProduct;
                string title = product.title;
                string description = product.description;
                decimal unitPrice = product.unitPrice;
                int stock = product.stock;

                string stockString = stock.ToString();

                if(stock < 100)
                {
                    stockString += " comprar mas producto a proveedor";
                }

                tableExistingProducts.Rows.Add(idProduct, title, description,
                                        unitPrice, stockString);
            }
        }
    }
}
