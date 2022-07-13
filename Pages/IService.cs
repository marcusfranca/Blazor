namespace BlazorProva1.Service
{
    public interface IService
    {
        Task<List<Produto>> GetProdutos();

        Task saveProdutos(List<Produto> produtos);
    }
}