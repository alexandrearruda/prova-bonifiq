using ProvaPub.Models;
using ProvaPub.Repository;
using PagedList;
using Microsoft.EntityFrameworkCore;
using ProvaPub.Interfaces;

namespace ProvaPub.Services
{
    public class ProductService 
    {
        readonly TestDbContext _ctx;

        public ProductService(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public Lists ListProducts(int page)
        {
            if (page == 0)
            {
                page = 1;
            }
            return new Lists() { HasNext = false, TotalCount = 10, Products = (PagedList<Product>)_ctx.Products.ToPagedList(page, 10) };
        }

    }
}
