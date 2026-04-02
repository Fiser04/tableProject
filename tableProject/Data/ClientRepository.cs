using tableProject.Contracts.Repositories;
using tableProject.Data;
using tableProject.Models;

namespace tableProject.Repositories;

public class ClientRepository : GenericRepository<Client>, IClientRepository
{
    public ClientRepository(ApplicationDbContext context) : base(context)
    {
        
    }
}