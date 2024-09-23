namespace ConsoleAppJsonSchemaExporter.Models;

public class TorneioEsportivo
{
    public string? Nome { get; set; }
    public Edicao[] UltimasEdicoes { get; set; } = new Edicao[6];
}

public class Edicao
{
    public int Ano { get; set; }
    public string[]? PaisSede { get; set; }
    public string? EquipeVencedora { get; set; }
}