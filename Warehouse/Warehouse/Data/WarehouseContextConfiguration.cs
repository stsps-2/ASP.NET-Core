using Microsoft.EntityFrameworkCore;

namespace Warehouse.Data.Models
{
    public partial class WarehouseContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options)
            : base(options)
        {
        }
    }
}
