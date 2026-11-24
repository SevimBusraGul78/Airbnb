using MongoDB.Bson.Serialization.Attributes;

namespace MYAcademy_AirbnbProject.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

        public  string  CategoryId { get; set; }
        public  string  CategoryName { get; set; }
        public  string  Description { get; set; }
        public  string  Icon { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
