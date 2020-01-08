using _01.webapi_azuresql.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _01.webapi_azuresql.Helper
{
    public class SqlHelper
    {
        string connectionString = "Server=tcp:sqldb162.database.windows.net,1433;Initial Catalog=sqldb-handson;Persist Security Info=False;User ID=nidhish;Password=azure-jan2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string query = "select * from [SalesLT].[Customer]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Customer customer;
                        while (reader.Read())
                        {
                            customer = FillCustomer(reader);
                            customers.Add(customer);
                        }
                    }
                }
            }
            return customers;
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = new Customer();
            string query = "select * from [SalesLT].[Customer] where CustomerId=" + id;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customer = FillCustomer(reader);
                        }
                    }
                }
            }
            return customer;
        }

        private Customer FillCustomer(SqlDataReader reader)
        {
            Customer customer = new Customer
            {
                CustomerID = (int)reader["CustomerID"],
                NameStyle = (reader["NameStyle"] ?? string.Empty).ToString(),
                Title = (reader["Title"] ?? string.Empty).ToString(),
                FirstName = (reader["FirstName"] ?? string.Empty).ToString(),
                MiddleName = (reader["MiddleName"] ?? string.Empty).ToString(),
                LastName = (reader["LastName"] ?? string.Empty).ToString(),
                Suffix = (reader["Suffix"] ?? string.Empty).ToString(),
                CompanyName = (reader["CompanyName"] ?? string.Empty).ToString(),
                SalesPerson = (reader["SalesPerson"] ?? string.Empty).ToString(),
                EmailAddress = (reader["EmailAddress"] ?? string.Empty).ToString(),
                Phone = (reader["Phone"] ?? string.Empty).ToString(),
                PasswordHash = (reader["PasswordHash"] ?? string.Empty).ToString(),
                PasswordSalt = (reader["PasswordSalt"] ?? string.Empty).ToString(),
                rowguid = (Guid)(reader["rowguid"] ?? Guid.Empty),
                ModifiedDate = (DateTime)(reader["ModifiedDate"] ?? DateTime.MinValue),
            };
            return customer;
        }
    }
}
