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
    public partial class FormSalesByProduct : Form
    {

        private static ControllerSalesByProduct cs = new ControllerSalesByProduct();

        public FormSalesByProduct()
        {
            InitializeComponent();

            fillComboBox();
            
        }

        private async Task fillComboBox()
        {

            List<string> titles = await cs.getTitleProducts();

            foreach(string title in titles)
            {
                comboBox.Items.Add(title);
            }
        }

        private async Task getSalesByProduct(string productName)
        {

            List<SalesByProduct> salesByProductList = await cs.getSalesByProduct(productName);

            int totalSales = 0;

            foreach (var p in salesByProductList)
            {   
                decimal total = p.unitPrice * p.quantity;

                string totalString = $"{total.ToString()}$";

                totalSales += p.quantity;

                tableSalesByProduct.Rows.Add(p.title, p.unitPrice, p.quantity, totalString, p.date);
            }

            label2.Text = $"Total de ventas de este producto: {totalSales.ToString()}";
        }

        private void clearTable()
        {
            tableSalesByProduct.Rows.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string productName = comboBox.Text;

            clearTable();

            getSalesByProduct(productName);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
