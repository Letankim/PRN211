using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class CartItemcs
    {
        public Product product {  get; set; }
        public int amount { get; set; }
        public double TotalMoney => amount * product.Price;
    }
}
