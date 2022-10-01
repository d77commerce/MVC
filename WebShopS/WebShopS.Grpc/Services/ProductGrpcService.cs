

using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using WebShopS.Core.Contracts;

namespace WebShopS.Grpc.Services
{
    public class ProductGrpcService  : Product.ProductBase
    {
        private readonly IProductService productService;

        public ProductGrpcService(IProductService _productService)
        {
                productService  = _productService;
        }
         ProductList result = new ProductList();
        public override async Task<ProductList> GetAll(Empty request, ServerCallContext context)
        {
            ProductList result =new ProductList();
            var products = await productService.GetAll();
            result.Items.AddRange(products.Select(p=> new ProducItem()
            {
                Id = p.Id.ToString(),
                Name = p.Name,
                Price = (double)p.Price,
                Quantity = p.Quantity,
                Description = p.Description,
                Barcode = p.BarCode
            }));
            return result;
        }
    }
}
