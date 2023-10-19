using MongoDB.Driver;
using MongoDB.Bson;

var client = new MongoClient("mongodb://localhost:27017/");

var database = client.GetDatabase("Test");

var usersCollection = database.GetCollection<BsonDocument>("Users");

var userId = new ObjectId("6529a2aa5f3c584384d447d1");
var filter = Builders<BsonDocument>.Filter.Eq("_id", userId);

var userDocument = usersCollection.Find(filter).FirstOrDefault();

if (userDocument != null)
{
    Console.WriteLine(userDocument.ToJson());
}
else
{
    Console.WriteLine("User do not found");
}
