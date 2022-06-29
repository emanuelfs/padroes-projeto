using entities;
using repositories;

namespace services;

public class AlunoService
{
    private static AlunoService? _instance = null;

    private AlunoRepository alunoRepository;

    private AlunoService()
    {
        this.alunoRepository = AlunoRepository.GetInstance();
    }

    public static AlunoService GetInstance()
    {
        if (_instance == null)
        {
            _instance = new AlunoService();
        }

        return _instance;
    }

    public bool Insert(AlunoEntity alunoEntity)
    {
        if (this.alunoRepository.Select(alunoEntity.Matricula) != null)
        {
            return false;
        }

        this.alunoRepository.Insert(alunoEntity);

        return true;
    }

    public bool Update(AlunoEntity alunoEntity)
    {
        if (this.alunoRepository.Select(alunoEntity.Matricula) != null)
        {
            this.alunoRepository.Update(alunoEntity);

            return true;
        }

        return false;
    }

    public bool Delete(Int32 matricula)
    {
        if (this.alunoRepository.Select(matricula) != null)
        {
            this.alunoRepository.Delete(matricula);

            return true;
        }

        return false;
    }

    public AlunoEntity? Select(Int32 matricula)
    {
        return this.alunoRepository.Select(matricula);
    }
}