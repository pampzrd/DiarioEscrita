namespace DiarioEscrita.Models;

public class DiarioDados
{
    public Guid Id { get; set; }
    public DateOnly DataEntrada { get; set; }
    public string? PeriodoEscrita { get; set; }
    public string? TodoItem { get; set; }
    public string? CenaItem { get; set; }
    public string? PalavrasNovas { get; set; }
    public string? EstouGostando { get; set; }
    public string? Anotacoes { get; set; }
    public UInt16 MetaPalavras { get; set; }
    public UInt16? TotalPalavras { get; set; }
    
}