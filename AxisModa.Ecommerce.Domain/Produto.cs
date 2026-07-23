using System;

namespace AxisModa.Ecommerce.Domain;

public class Produto
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public string ImagemUrl { get; private set; } = string.Empty;
    public int Estoque { get; set; }
    public bool Ativo { get; set; } = true;
    public DateTime DataCriacao { get; private set ; } = DateTime.UtcNow;

    public void DefinirImagem(string url) => ImagemUrl = url;
}
