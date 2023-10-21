using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }

        public int OriginCountry { get; set; }

        public double ProductCost { get; set; }

        // * Navigation Property *
        public virtual Country Country { get; set; }

    }
}
