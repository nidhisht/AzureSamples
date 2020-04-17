using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace _09.webapi_cosmos_sqlapi.Entity
{
    public class Order
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus Status { get; set; }
        public AuditTrail AuditSummary { get; set; }
    }

    public class OrderItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Currency { get; set; }
        public string UOM { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal NetPrice { get { return (UnitPrice - Discount) * Quantity; } }

    }

    public class Customer
    {
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class AuditTrail
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
    }
}
