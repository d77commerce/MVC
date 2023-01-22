namespace MVCtest.Infrastructure.Common.OrderHeader
{
    public interface IOrderHeaderRepository:IRepository<Models.OrderHeader>
   {
       void Update(Models.OrderHeader obj);
       void UpdateStatus(int id,string orderStatus,string? paymentStatus = null);
     
   }
}
