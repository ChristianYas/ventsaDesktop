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
    public partial class BestSelling : Form
    {
        public BestSelling()
        {
            InitializeComponent();

            fillTable();
        }

        public async Task fillTable()
        {

            ControllerBestSelling cs = new ControllerBestSelling();

            List<ViewSale> bestSellingsList = await cs.getBestSellings();

            foreach (var item in bestSellingsList)
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

                tableBestSellings.Rows.Add(idSale, title, description,
                                        unitPrice, stock, quantitySold, totalString, date);
            }
        }

        private void tableBestSellings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
