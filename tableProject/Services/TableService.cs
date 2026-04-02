using tableProject.Contracts.Repositories;
using tableProject.Contracts.Services;
using tableProject.Data;
using tableProject.Models;

namespace tableProject.Services;

public class TableService : GenericService<Table>, ITableService
{
    private readonly ITableRepository _tableRepository;

    public TableService(ITableRepository tableRepository, ApplicationDbContext context) 
        : base(tableRepository, context)
    {
        _tableRepository = tableRepository;
    }
}