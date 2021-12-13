using Lab.Business.Models;
using System;
using System.Threading.Tasks;

namespace Lab.Business.Interfaces
{
    public interface IProdutoService
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
