using entities;
using services;

AlunoService alunoService = AlunoService.GetInstance();

alunoService.Insert(new AlunoEntity
{
    Matricula = 10,
    Nome = "Maria"
});

alunoService.Insert(new AlunoEntity
{
    Matricula = 10,
    Nome = "Xablau"
});

alunoService.Update(new AlunoEntity
{
    Matricula = 10,
    Nome = "Xablau"
});

alunoService.Delete(20);

AlunoEntity? alunoEntity = alunoService.Select(10);

Console.WriteLine(alunoEntity?.Nome);

alunoService.Delete(10);

alunoEntity = alunoService.Select(10);

Console.WriteLine(alunoEntity);

Console.WriteLine("");