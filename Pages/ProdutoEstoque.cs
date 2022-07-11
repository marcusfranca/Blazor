using System.ComponentModel.DataAnnotations;
public class ProdutoEstoque
{
    [Required]
    [Range(1, 1000000, ErrorMessage = "Verificar Campo Quantidade")]
    public int Quantidade { get; set; }
    [Required]
    [Range(3, 50, ErrorMessage = "Verificar Campo Cor")]
    public string Cor { get; set; } = String.Empty;

    [Required]
    [Range(0, 20, ErrorMessage = "Verificar Campo Tamanho")]
    public string Tamanho { get; set; } = String.Empty;
}
