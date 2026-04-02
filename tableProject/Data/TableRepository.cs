using tableProject.Contracts.Repositories;
using tableProject.Data;
using tableProject.Models;

namespace tableProject.Repositories;

public class TableRepository : GenericRepository<Table>, ITableRepository
{
    public TableRepository(ApplicationDbContext context) : base(context)
    {
    }
}