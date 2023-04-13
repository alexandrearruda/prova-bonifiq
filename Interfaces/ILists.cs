using System.Reflection.Metadata.Ecma335;
using ProvaPub.Repository;
using ProvaPub.Services;

namespace ProvaPub.Interfaces
{
    public interface ILists
    {

        public ProductService GetProductService(TestDbContext ctx);
        
        public CustomerService GetCustomerService(TestDbContext ctx);
    }

}