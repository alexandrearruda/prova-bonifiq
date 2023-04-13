using PagedList;

namespace ProvaPub.Models
{
    public class Lists
    {
        public List<Customer>? Customers { get; set; }
        public PagedList<Product>? Products { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
    }
}
