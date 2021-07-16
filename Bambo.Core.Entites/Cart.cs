using System.Collections.Generic;
using System.Linq;

namespace Bambo.Core.Entites
{
    public class Cart
    {
        private List<CartLine> lines = new List<CartLine>();

        public virtual void AddItem(Product product, int quantity)
        {
            CartLine cartLine = GetCartLine(product.ProductID);
            if (cartLine != null)
            {
                cartLine.Quantity += quantity;
            }
            else
            {
                lines.Add(new CartLine() { Quantity = quantity, Product = product });
            }

        }

      
       

        public IEnumerable<CartLine> CartLines { get => lines; }

        private CartLine GetCartLine(int productId)
        {
            return lines.FirstOrDefault(p => p.Product.ProductID == productId);
        }
        public virtual int GetTotalPrice()
        {
            return lines.Sum(e => e.Product.Price * e.Quantity);
        }

    }
}
