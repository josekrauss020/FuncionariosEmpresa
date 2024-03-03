
namespace FuncionariosEmpresa;

internal class Analista : Funcionarios
{

    public Analista(double anosDeExperiencia)
    {
        if (anosDeExperiencia > 1)
        {
            AnosDeExperiencia = anosDeExperiencia / 10;
        }
        else
        {
            AnosDeExperiencia = 1;
        }
    }

    public double AnosDeExperiencia { get; }
    int SalarioBase = 3500;
    public double SalarioFinal => SalarioBase * (1 + AnosDeExperiencia);
    List<string> Atribuicoes = new List<string> {"atribuição 1", "atribuição 2", "atribuição 3", "atribuição 4", "atribuição 5", "atribuição 6" };


    public override void ShowFuncionariosData()
    {
        base.ShowFuncionariosData();
        Console.WriteLine($"Salario: {SalarioFinal}");
        Console.WriteLine($"Experiência: {AnosDeExperiencia * 10} anos");
        Console.WriteLine("Atribuições:");
        foreach (var item in Atribuicoes) { Console.WriteLine("- " + item); }
        Console.WriteLine("\n");
    }
}
