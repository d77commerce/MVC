

using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace WebShopS.Grpc.Services
{
    public class ProductGrpcService  : Product.ProductBase
    {
         ProductList result = new ProductList();
        public override Task<ProductList> GetAll(Empty request, ServerCallContext context)
        {
            return base.GetAll(request, context);
        }
    }
}
