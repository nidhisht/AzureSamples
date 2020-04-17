using _09.webapi_cosmos_sqlapi.Entity;
using System;
using System.Collections.Generic;

namespace _09.webapi_cosmos_sqlapi
{
    public static class MockOrder
    {
        public static Order Populate()
        {
            return new Order
            {
                Id = Guid.NewGuid().ToString(),
                Customer = new Customer { Id = 1, FirstName = "John", LastName = "Denvar", PhoneNumber = "9986004300" },
                Status = new OrderStatus { Id = 1, Name = "In Progress" },
                AuditSummary = new AuditTrail { CreatedBy = "Staff 1", CreatedOn = DateTime.Now },
                OrderDate = DateTime.Now,
                OrderItems = new List<OrderItem>
                {
                    new OrderItem { Id = "HB001", Name = "Hiking Boot", Quantity = 1, Currency = "INR", UOM="pair", UnitPrice= 1499, Discount=299 },
                    new OrderItem { Id = "CY010", Name = "BTwin adult cycle", Quantity = 1, Currency = "INR", UOM="piece", UnitPrice= 5899, Discount=0 }
                }
            };
        }
    }
}
