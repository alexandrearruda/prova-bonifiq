using ProvaPub.Models;

namespace ProvaPub.Services
{
    public class OrderService
    {
        public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
        {
            switch (paymentMethod)
            {
                case "pix":
                    Console.WriteLine("Pagamento pix");
                    paymentValue = 1;

                    break;
                case "creditcard":
                    Console.WriteLine("Pagamento creditcard");
                    paymentValue = 2;

                    break;
                case "paypal":
                    Console.WriteLine("Pagamento paypal");
                    paymentValue = 3;
                    break;
                default:
                    paymentValue = 0;
                    Console.WriteLine("Pagamento Inválido");
                    break;
            }

            return await Task.FromResult(new Order()
            {
                Value = paymentValue
            });



        }
    }
}
