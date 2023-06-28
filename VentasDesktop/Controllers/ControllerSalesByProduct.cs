using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasDesktop.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VentasDesktop.Controllers
{
    class ControllerSalesByProduct
    {

        private HttpClient _httpClient = new HttpClient();

        public async Task<List<string>> getTitleProducts()
        {

            List<string> titles = new List<string>();

            string uri = "https://localhost:7076/titles";

            try
            {
                HttpResponseMessage res = await _httpClient.GetAsync(uri);

                if (res.IsSuccessStatusCode)
                {
                    string json = await res.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<List<string>>(json);

                    foreach( var item in data )
                    {
                        titles.Add(item);
                    }
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return titles;
        }

        public async Task<List<SalesByProduct>> getSalesByProduct(string productName)
        {

            List<SalesByProduct> salesByProductsList = new List<SalesByProduct>();

            string baseUrl = "https://localhost:7076";
            string endpoint = "/salesByProduct/";

            string url = baseUrl + endpoint + productName;

            HttpResponseMessage res = await _httpClient.GetAsync(url);

            if (res.IsSuccessStatusCode)
            {
                string json = await res.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<SalesByProduct>>(json);

                foreach(var item in data)
                {

                    string title = item.title;
                    string description = item.description;
                    decimal unitPrice = item.unitPrice;
                    int quantity = item.quantity;
                    DateTime date = item.date;

                    SalesByProduct salesByProduct = new SalesByProduct(title, 
                                                                        description, 
                                                                        unitPrice, 
                                                                        quantity, 
                                                                        date);

                    salesByProductsList.Add(salesByProduct);                    
                }
            }


            return salesByProductsList;
        }

    }
}
