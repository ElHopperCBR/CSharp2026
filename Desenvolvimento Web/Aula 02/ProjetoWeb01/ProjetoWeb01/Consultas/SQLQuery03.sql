-- 6) Inserts de exemplo
DECLARE @IdAluno INT, @IdAdmin INT;

-- 6.1) Usuario do tipo Aluno
INSERT INTO dbo.Usuario (Nome, Email, Senha, Regra)
VALUES ('Joao Silva', 'joao@exemplo.com', '123456', 0);

SET @IdAluno = SCOPE_IDENTITY();

INSERT INTO dbo.Alunos (Id, RA, StatusWIFI, StatusAction, CursoID)
VALUES (@IdAluno, 2026001, DEFAULT, DEFAULT, 10);

-- 6.2) Usuario do tipo Admin
INSERT INTO dbo.Usuario (Nome, Email, Senha, Regra)
VALUES ('Maria Admin', 'maria@exemplo.com', 'admin123', 1);

SET @IdAdmin = SCOPE_IDENTITY();

INSERT INTO dbo.Admin (Id)
VALUES (@IdAdmin);
GO