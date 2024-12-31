using MongoDB.Bson;
using MongoDB.Driver;
using MongoDemoForm.Entites;

namespace MongoDemoForm.Services;

public class CustomerOperations
{
    public void AddCustomer(Customer customer)
    {
        var connection = new MongoDbConnection();
        var customerCollection = connection.GetCustomersCollection();
        var document = new BsonDocument
        {
            { "CustomerName", customer.CustomerName },
            { "CustomerSurname", customer.CustomerSurname },
            { "CustomerCity", customer.CustomerCity },
            { "CustomerBalance", customer.CustomerBalance },
        };

        customerCollection.InsertOne(document);
    }

    public List<Customer> GetAllCustomers()
    {
        var connection = new MongoDbConnection();
        var customerCollection = connection.GetCustomersCollection();
        var customers = customerCollection.Find(new BsonDocument()).ToList();
        List<Customer> customerList = new List<Customer>();
        foreach (var c in customers)
        {
            customerList.Add(new Customer
            {
                CustomerId = c["_id"].ToString(),
                CustomerName = c["CustomerName"].ToString(),
                CustomerSurname = c["CustomerSurname"].ToString(),
                CustomerCity = c["CustomerCity"].ToString(),
                CustomerBalance = decimal.Parse(c["CustomerBalance"].ToString()),
            });
        }

        return customerList;
    }

    public void DeleteCustomer(string customerId)
    {
        var connection = new MongoDbConnection();
        var customerCollection = connection.GetCustomersCollection();
        var customer =
            Builders<BsonDocument>.Filter.Eq("_id",
                ObjectId.Parse(customerId)); // customerId ue eşit olan _id yi bulduk.
        customerCollection.DeleteOne(customer); // silme işlemi
    }

    public void UpdateCustomer(Customer customer)
    {
        var connection = new MongoDbConnection();
        var customerCollection = connection.GetCustomersCollection();
        var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
        var UpdatedValue = Builders<BsonDocument>.Update
            .Set("CustomerName", customer.CustomerName)
            .Set("CustomerSurname", customer.CustomerSurname)
            .Set("CustomerCity", customer.CustomerCity)
            .Set("CustomerBalance", customer.CustomerBalance);
        customerCollection.UpdateOne(filter, UpdatedValue);
    }

    public Customer GetCustomerById(string id)
    {
        var connection = new MongoDbConnection();
        var customerCollection = connection.GetCustomersCollection();
        var customerFilter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
        var result = customerCollection.Find(customerFilter).FirstOrDefault();
        return new Customer
        {
            CustomerBalance = int.Parse(result["CustomerBalance"].ToString()),
            CustomerName = result["CustomerName"].ToString(),
            CustomerSurname = result["CustomerSurname"].ToString(),
            CustomerCity = result["CustomerCity"].ToString(),
            CustomerId = id
        };
    }
}