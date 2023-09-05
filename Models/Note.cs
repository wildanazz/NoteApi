using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NoteApi.Models;

public class Note
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool Important { get; set; }

    public bool Done { get; set; }
}