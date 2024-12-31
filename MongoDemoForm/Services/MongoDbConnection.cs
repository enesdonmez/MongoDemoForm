using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDemoForm.Services;

public class MongoDbConnection
{
    private IMongoDatabase _database;

    public MongoDbConnection()
    {
        var client = new MongoClient("mongodb://localhost:27017"); // veri tabanı bağlantı adresi
        _database = client.GetDatabase("DBCustomer"); // veri tabanı olusturduk.
    }

    public IMongoCollection<BsonDocument> GetCustomersCollection()
    {
        return _database.GetCollection<BsonDocument>("Customers");
    }
}