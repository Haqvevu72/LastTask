using Entities.Abstract;

namespace Entities.Concrete
{
    public class Country:BaseEntity
    {
        public string CountryName { get; set; }

        // * Navigation Property *
        public virtual ICollection<Product> Products { get; set; }

    }
}
