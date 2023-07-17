using System.ComponentModel.DataAnnotations;

namespace RepositoryDB
{
    public class Entity
    {
        [Key]
        public uint Id { get; set; }

        public Entity() { }
        public Entity(uint id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            if ((obj != null) && (obj is Entity entity))
            {
                return entity.Id == Id;
            }
            return false;
        }
    }
}
