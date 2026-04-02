using tableProject.Contracts.Repositories;
using tableProject.Contracts.Services;
using tableProject.Data;
using tableProject.Models;

namespace tableProject.Services;

public class RowService : GenericService<Row>, IRowService
{
    private readonly IRowRepository _rowRepository;

    public RowService(IRowRepository rowRepository, ApplicationDbContext context) 
        : base(rowRepository, context)
    {
        _rowRepository = rowRepository;
    }
}