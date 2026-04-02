using tableProject.Contracts.Repositories;
using tableProject.Data;
using tableProject.Models;

namespace tableProject.Repositories;

public class CellRepository : GenericRepository<Cell>, ICellRepository
{
    public CellRepository(ApplicationDbContext context) : base(context)
    {
    }
}