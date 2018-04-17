using Undefine.Infrastructure.Helper;

namespace Undefine.Domain.Model
{
    public abstract class Entity
    {
        public string Id { get; set; }

        public Entity()
        {
            this.Id = GuidHelper.GenerateComb().ToString();
        }
    }
}
