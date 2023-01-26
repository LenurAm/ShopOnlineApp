using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repository.Contracts;

namespace ShopOnline.Api.Repository
{
	public class ProductRepository : IProductRepository
	{
		private readonly ShopOnlineDbContext shopOnlineDbContext;
		public ProductRepository(ShopOnlineDbContext shopOnlineDbContext) 
		{
			this.shopOnlineDbContext=shopOnlineDbContext;
		}
		public async Task<IEnumerable<ProductCategory>> GetCategories()
		{
			var categories=await this.shopOnlineDbContext.ProductCategories.ToListAsync();
			return categories;
		}

		public async Task<ProductCategory> GetCategory(int id)
		{
			//var category = await shopOnlineDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
			//return category;
			throw new NotImplementedException();
		}

		public Task<Product> GetItem(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Product>> GetItems()
		{
			var products = await this.shopOnlineDbContext.Products.ToListAsync();
			return products;
		}
	}
}
