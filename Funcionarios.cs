
namespace FuncionariosEmpresa;

internal  class Funcionarios
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string EstadoCivil { get; set; }
    public int Idade { get; set; }


    public virtual void ShowFuncionariosData()
    {
        Console.WriteLine($"Nome: {Nome} {Sobrenome}");
        Console.WriteLine($"Estado civil: {EstadoCivil}");
        Console.WriteLine($"Idade: {Idade}");
    }
}
