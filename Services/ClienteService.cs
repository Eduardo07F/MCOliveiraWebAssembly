using Entidades;
using MCOliveiraWebAssembly.Services.IServices;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Newtonsoft;

namespace MCOliveiraWebAssembly.Services
{
    public class ClienteService : IClienteService
    {
        private readonly HttpClient _httpClient;

        public ClienteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Cliente> Add(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Cliente>> GetAll()
        {
            List<Cliente> list = new List<Cliente>();

            var URL = "https://localhost:7153/api/Cliente";

            var response = await _httpClient.GetAsync(URL);

            response.EnsureSuccessStatusCode();

            var jsonResult = await response.Content.ReadAsStringAsync();

            list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cliente>>(jsonResult);

            return list;
        }

        public async Task<Cliente> GetById(int id)
        {
            Cliente _cliente = new Cliente();

            var URL = "https://localhost:7153/api/Cliente/"+id;

            var response = await _httpClient.GetAsync(URL);

            response.EnsureSuccessStatusCode();

            var jsonResult = await response.Content.ReadAsStringAsync();

            _cliente = Newtonsoft.Json.JsonConvert.DeserializeObject<Cliente>(jsonResult);

            return _cliente;
        }

        public async Task<bool> Inativar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Cliente> Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
