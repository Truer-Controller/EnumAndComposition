using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EnumAndComposition.Entities
{
    class OrderItem
    {
        public int QuantityItem { get; set; }
        public double PriceItem { get; set; }
        public Product Product { get; set; }


        public OrderItem()
        {
        }
        public OrderItem(int quantityItem, double priceItem, Product product)
        {
            QuantityItem = quantityItem;
            PriceItem = priceItem;
            Product = product;

        }

        public double SubTotal()
        {
            return QuantityItem * PriceItem;
        }
        public override string ToString()
        {
            return Product.NameProduct
                + ", $"
                + PriceItem.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + QuantityItem
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}