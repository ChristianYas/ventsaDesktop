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
    public partial class AllSales : Form
    {

        public AllSales()
        {
            InitializeComponent();

            fillTable();
        }

        public async Task fillTable()
        {

            ControllerAllSales ca = new ControllerAllSales();

            List<ViewSale> allSalesList = await ca.getAllSales();

            foreach(var item in allSalesList)
            {
                Product product = item.product;

                int idProduct = product.idProduct;
                string title = product.title;
                string description = product.description;
                decimal unitPrice = product.unitPrice;
                int stock = product.stock;

                Sale sale = item.sale;

                int idSale = sale.idSale;
                int quantitySold = sale.quantitySold;
                DateTime date = sale.date;

                decimal total = unitPrice * quantitySold;

                string totalString = $"{total.ToString()}$";

                tableAllSales.Rows.Add(idSale, title, description,
                                        unitPrice, stock, quantitySold, totalString, date);
            }
        }
    }
}
