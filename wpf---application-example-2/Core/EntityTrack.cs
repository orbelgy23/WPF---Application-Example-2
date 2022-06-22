
namespace WPF___Application_Example_2.Core
{
    public class Entity
    {

    }

    public class EntityTrack
    {
        public Entity NativeEntity { get; set; }

        public string Name { get; set; }

        public EntityTrack(Entity e, string name)
        {
            NativeEntity = e;
            Name = name;
        }
    }
}
