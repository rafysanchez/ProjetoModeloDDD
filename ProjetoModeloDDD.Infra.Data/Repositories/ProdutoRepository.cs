
using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {

        public IEnumerable<Produto> BuscaPorNome(string Nome)
        {
            return Db.Produtos.Where(p => p.Nome.StartsWith(Nome)).OrderBy(p => p.Nome);
        }

    }
}
