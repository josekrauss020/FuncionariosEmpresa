/*
Crie uma hierarquia de classes representando funcionários de uma empresa.
Utilize herança para criar classes como Gerente, Programador e Analista.
Cada classe deve ter propriedades específicas, além das propriedades comuns a 
todos os funcionários, como Nome e Salário.
 */
using FuncionariosEmpresa;
Funcionarios pessoa1 = new Analista(2);
pessoa1.Nome = "Osvaldo";
pessoa1.Sobrenome = "Cruz";
pessoa1.EstadoCivil = "Solteiro";
pessoa1.Idade = 29;

pessoa1.ShowFuncionariosData();

Funcionarios pessoa2 = new Engenheiro(3);
pessoa2.Nome = "Francisco";
pessoa2.Sobrenome = "Da Costa";
pessoa2.EstadoCivil = "Casado";
pessoa2.Idade = 32;

pessoa2.ShowFuncionariosData();