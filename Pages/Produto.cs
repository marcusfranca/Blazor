using System.ComponentModel.DataAnnotations;

public class Produto
{
    public int Id { get; set; }
    [Required]
    [Range(4, 70, ErrorMessage = "Verificar Campo Nome")]
    public string Nome { get; set; } = String.Empty;
    [Required]
    [Range(10, 300, ErrorMessage = "Verificar Campo Descricao")]
    public string Descricao { get; set; } = String.Empty;
    [Required]
    [Range(1, 1000000, ErrorMessage = "Verificar Campo Preco")]
    public decimal Preco { get; set; } = decimal.Zero;
    [Required(ErrorMessage = "Verificar Campo Foto")]
    public string Foto { get; set; } = String.Empty;
    public string DataCadastro { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
    public List<ProdutoEstoque> Estoque { get; set; } = new List<ProdutoEstoque>();

}