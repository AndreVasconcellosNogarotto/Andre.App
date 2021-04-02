using Andre.Business.Models;
using System;
using System.Threading.Tasks;

namespace Andre.Business.Interface
{
   public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
