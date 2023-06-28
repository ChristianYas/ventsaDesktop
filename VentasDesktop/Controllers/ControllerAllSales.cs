using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasDesktop.Models;

namespace VentasDesktop.Controllers
{
    class ControllerAllSales
    {
        HttpClient _httpClient = new HttpClient();

        public async Task<List<ViewSale>> getAllSales()
        {

            List<ViewSale> allSalesList = new List<ViewSale>();

            string url = "https://localhost:7076/allSales";

            HttpResponseMessage res = await _httpClient.GetAsync(url);

            if (res.IsSuccessStatusCode)
            {
                string json = await res.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<ViewSale>>(json);

                foreach(var item in data)
                {
                    Product product = item.product;

                    int idProduct = product.idProduct;
                    string title = product.title;
                    string description = product.description;
                    decimal unitPrice = product.unitPrice;
                    int stock = product.stock;

                    Sale sale = item.sale;

                    int idSales = sale.idSale;
                    int quantitySold = sale.quantitySold;
                    DateTime date = sale.date;

                    ViewSale vs = new ViewSale(product, sale);

                    allSalesList.Add(vs);

                }
            }

            return allSalesList;
        }
    }
}
