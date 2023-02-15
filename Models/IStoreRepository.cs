using System.Linq;

namespace SklepGamingowy.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
