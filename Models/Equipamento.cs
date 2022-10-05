using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DetranApp.DB
{
    public class Equipamento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonRequired]
        public string IdEquip { get; set; }
        [BsonRequired]
        public string TipoEquipamento { get; set; }
        [BsonRequired]
        public string ModeloEquipamento { get; set; }

    }
}
