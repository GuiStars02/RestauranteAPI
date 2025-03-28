using Microsoft.EntityFrameworkCore;

namespace RestauranteAPI.Data
{
    public class RestauranteContext : DbContext
    {
        public RestauranteContext(DbContextOptions options) : base(options)
        {
        }

    }
}
