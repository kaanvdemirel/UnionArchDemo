using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProductNorthwindService

    {

        HttpClient _httpClient;

        public ProductNorthwindService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<List<Product>> GetProductsAsync()
        {

            var response = await _httpClient.GetAsync("https://localhost:44382/api/products/getAll");
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<List<Product>>();
            return result;

        }
    }
}
