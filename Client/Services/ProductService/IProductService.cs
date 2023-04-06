using EComm.Shared;

namespace EComm.Client.Services.ProductService
{
	public interface IProductService
	{
		List<Product> Products { get; set; }
		Task GetProducts();
		Task<ServiceResponse<Product>> GetProduct(int productId);
	}
}
