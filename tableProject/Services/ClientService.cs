using tableProject.Contracts.Repositories;
using tableProject.Contracts.Services;
using tableProject.Data;
using tableProject.Models;

namespace tableProject.Services;

public class ClientService : GenericService<Client>, IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository, ApplicationDbContext context) 
        : base(clientRepository, context)
    {
        _clientRepository = clientRepository;
    }
}