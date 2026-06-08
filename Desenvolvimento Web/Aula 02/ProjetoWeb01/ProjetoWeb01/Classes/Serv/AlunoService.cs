using ProjetoWeb01.Dados;
using ProjetoWeb01.Classes.Entidades;

namespace ProjetoWeb01.Classes.Serv
{
    public class AlunoService
    {
        //Campo
        private readonly AlunoContext dbContext;

        //Construtor
        public AlunoService(AlunoContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Tarefa
        public async Task<ResultadoCadastro> CadastrarAluno(Aluno aluno)
        {
            try
            {
                //Validação básica de cadastro
                if (string.IsNullOrWhiteSpace(aluno.Nome))
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor, informe o nome válido de aluno"
                    };
                }

                if (aluno.RA <= 0)
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor, informe um RA válido"
                    };
                }

                if (aluno.CursoID <= 0)
                {
                    return new ResultadoCadastro
                    {
                        Sucesso = false,
                        Mensagem = "Por favor, selecione um curso"
                    };
                }

                //Definir os status padrão para novos cadastros
                aluno.StatusWIFI = "Inativo";
                aluno.StatusAction = "Aguardando aprovação";

                if (string.IsNullOrWhiteSpace(aluno.Email))
                {
                    aluno.Email = $"ra{aluno.RA}@aluno.local";
                }

                if (string.IsNullOrWhiteSpace(aluno.Senha))
                {
                    aluno.Senha = aluno.RA.ToString();
                }

                //Adicionar o aluno ao banco de dados
                dbContext.Alunos.Add(aluno);
                await dbContext.SaveChangesAsync();

                return new ResultadoCadastro
                {
                    Sucesso = true,
                    Mensagem = "Aluno cadastrado com sucesso!"
                };
            }

            catch (Exception ex)
            {
                var detalheErro = ex.InnerException?.Message ?? ex.Message;

                return new ResultadoCadastro
                {
                    Sucesso = false,
                    Mensagem = $"Erro ao cadastrar o aluno: {detalheErro}"
                };
            }
        }


    }
}
