using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NoteApi.Models;

namespace NoteApi.Services;

public class NoteService
{
    private readonly IMongoCollection<Note> _noteCollection;

    public NoteService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        MongoClient mongoClient = new MongoClient(mongoDBSettings.Value.ConnectionString);
        IMongoDatabase mongoDatabase = mongoClient.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _noteCollection = mongoDatabase.GetCollection<Note>(mongoDBSettings.Value.CollectionName);
    }

    public async Task<List<Note>> GetAsync() => await _noteCollection.Find(_ => true).ToListAsync();
}