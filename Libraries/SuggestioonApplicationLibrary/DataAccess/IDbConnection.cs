namespace SuggestioonApplicationLibrary.DataAccess;
public interface IDbConnection
{
    IMongoCollection<CategoryModel> CategoryCollection { get; }
    string CategoryCollectionName { get; }
    MongoClient Client { get; }
    string DbName { get; }
    IMongoCollection<StatusModel> StatusCollection { get; }
    string StatusCollectionName { get; }
    string SuggestionCollectionName { get; }
    IMongoCollection<SuggestionModel> SuggestionCollection { get; }
    IMongoCollection<UserModel> UserCollection { get; }
    string UserCollectionName { get; }
}