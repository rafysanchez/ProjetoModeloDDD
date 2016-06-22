using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienterepository;

        public ClienteService(IClienteRepository clienterepository)
            :base(clienterepository)
        {
            _clienterepository = clienterepository;
        }
    }
}
