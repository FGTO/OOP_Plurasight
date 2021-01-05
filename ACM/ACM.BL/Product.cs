using System;
namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; set; }

        /// <summary>
        /// Validate a product.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            //TODO code that retrieve the defined product.
            return new Product();
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        public bool Save()
        {
            return true;
        }

    }
}
