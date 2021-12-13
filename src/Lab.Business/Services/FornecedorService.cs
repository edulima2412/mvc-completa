using Lab.Business.Interfaces;
using Lab.Business.Models;
using System;
using System.Threading.Tasks;

namespace Lab.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        public Task Adicionar(Fornecedor fornecedor)
        {
            // Validar o estado da entidade

            // Se não existe fornecedor com o mesmo documento
        }

        public Task Atualizar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
