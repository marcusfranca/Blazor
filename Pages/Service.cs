using Blazored.LocalStorage;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorProva1.Service
{

    public class Service : IService
    {
        private readonly ILocalStorageService localStorageService;

        public Service(ILocalStorageService localStorageService)
        {
            this.localStorageService = localStorageService;
        }
        private string key = "key";
        public async Task<List<Produto>> GetProdutos()
        {
            var Json = await localStorageService.GetItemAsync<string>(key);
            if (string.IsNullOrEmpty(Json))
            {
                return new List<Produto>();
            }

            return JsonSerializer.Deserialize<List<Produto>>(Json);
        }
        public async Task saveProdutos(List<Produto> produtos)
        {
            var JSON2 = JsonSerializer.Serialize(produtos);
            await localStorageService.SetItemAsync(key, JSON2);
        }
    }
}