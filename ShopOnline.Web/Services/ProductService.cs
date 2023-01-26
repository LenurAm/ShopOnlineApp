using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System.Collections.Concurrent;
using System.Net.Http.Json;

namespace ShopOnline.Web.Services
{
	public class ProductService: IProductService
	{
		private HttpClient httpClient;

		public ProductService(HttpClient httpClient) 
		{
			this.httpClient=httpClient;
		}

		public async Task<IEnumerable<ProductDto>> GetItems()
		{
			try
			{
				var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
				return products;
			}
			catch (Exception)
			{
				throw;
			}
		}
		
	}
}
