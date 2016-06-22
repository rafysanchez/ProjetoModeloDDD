using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtorepository;

        public ProdutoService(IProdutoRepository produtorepository)
            :base(produtorepository)
        {
            _produtorepository = produtorepository;
        }
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtorepository.BuscaPorNome(nome);
        }
    }
}
