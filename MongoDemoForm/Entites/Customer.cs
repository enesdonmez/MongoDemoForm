using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDemoForm.Entites;

public class Customer
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string CustomerId { get; set; }
    
    public string CustomerName { get; set; }
    
    public string CustomerSurname { get; set; }
    
    public string CustomerCity { get; set; }
    
    public decimal CustomerBalance { get; set; }
}