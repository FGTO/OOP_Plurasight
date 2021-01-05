using System;
namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderID)
        {
            OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve()
        {
            return new Order();
        }

        /// <summary>
        /// Save the current order.
        /// </summary>
        public bool Save()
        {
            return true;
        }
    }
}
