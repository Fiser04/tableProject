using tableProject.Contracts.Repositories;
using tableProject.Contracts.Services;
using tableProject.Data;
using tableProject.Models;

namespace tableProject.Services;

public class ColumnService : GenericService<Column>, IColumnService
{
    private readonly IColumnRepository _columnRepository;

    public ColumnService(IColumnRepository columnRepository, ApplicationDbContext context) 
        : base(columnRepository, context)
    {
        _columnRepository = columnRepository;
    }
}