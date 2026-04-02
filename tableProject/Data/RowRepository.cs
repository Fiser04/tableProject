using tableProject.Contracts.Repositories;
using tableProject.Data;
using tableProject.Models;

namespace tableProject.Repositories;

public class RowRepository : GenericRepository<Row>, IRowRepository
{
    public RowRepository(ApplicationDbContext context) : base(context)
    {
    }
}