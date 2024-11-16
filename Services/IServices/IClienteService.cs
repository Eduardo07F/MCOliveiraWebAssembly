using Entidades;

namespace MCOliveiraWebAssembly.Services.IServices
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetAll();
        Task<Cliente> GetById(int id);
        Task<Cliente> Add(Cliente cliente);
        Task<Cliente> Update(Cliente cliente);
        Task<bool> Delete(int id);
        Task<bool> Inativar(int id);
    }
}
