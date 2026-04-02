using tableProject.Contracts.Repositories;
using tableProject.Data;
using tableProject.Models;

namespace tableProject.Repositories;

public class ColumnRepository : GenericRepository<Column>, IColumnRepository
{
    public ColumnRepository(ApplicationDbContext context) : base(context)
    {
    }
}