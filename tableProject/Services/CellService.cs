using tableProject.Contracts.Repositories;
using tableProject.Contracts.Services;
using tableProject.Data;
using tableProject.Models;

namespace tableProject.Services;

public class CellService : GenericService<Cell>, ICellService
{
    private readonly ICellRepository _cellRepository;

    public CellService(ICellRepository cellRepository, ApplicationDbContext context) 
        : base(cellRepository, context)
    {
        _cellRepository = cellRepository;
    }
}