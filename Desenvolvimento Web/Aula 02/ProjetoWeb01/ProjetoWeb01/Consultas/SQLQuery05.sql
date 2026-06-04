BEGIN TRANSACTION; -- Isso garante que todas as inserções sejam atômicas, ou seja, todas serão aplicadas ou nenhuma será aplicada

DECLARE @IdUsuario INT; -- Variável para armazenar o ID do usuário recém-inserido

-- Elma
INSERT INTO Usuario (Nome, Email, Senha, Regra)
VALUES ('Elma', 'elma@aluno.senaisp.br', 'F1c', 0);
SET @IdUsuario = SCOPE_IDENTITY(); --Scope_Identity() retorna o último ID gerado na sessão atual, garantindo que obtenhamos o ID correto do usuário recém-inserido

INSERT INTO Alunos (Id, RA, StatusWIFI, StatusAction, CursoID)
VALUES (@IdUsuario, 123456, 'Inativo', 'Aguardando aprovação', 1);

-- Flavio
INSERT INTO Usuario (Nome, Email, Senha, Regra)
VALUES ('Flavio', 'flavio@aluno.senaisp.br', 'F1c', 0);
SET @IdUsuario = SCOPE_IDENTITY();

INSERT INTO Alunos (Id, RA, StatusWIFI, StatusAction, CursoID)
VALUES (@IdUsuario, 123457, 'Inativo', 'Aguardando aprovação', 2);

-- Naruto
INSERT INTO Usuario (Nome, Email, Senha, Regra)
VALUES ('Naruto', 'naruto@aluno.senaisp.br', 'F1c', 0);
SET @IdUsuario = SCOPE_IDENTITY();

INSERT INTO Alunos (Id, RA, StatusWIFI, StatusAction, CursoID)
VALUES (@IdUsuario, 123458, 'Inativo', 'Aguardando aprovação', 1);

-- Zorro
INSERT INTO Usuario (Nome, Email, Senha, Regra)
VALUES ('Zorro', 'zorro@aluno.senaisp.br', 'F1c', 0);
SET @IdUsuario = SCOPE_IDENTITY();

INSERT INTO Alunos (Id, RA, StatusWIFI, StatusAction, CursoID)
VALUES (@IdUsuario, 123459, 'Inativo', 'Aguardando aprovação', 2);

COMMIT TRANSACTION; --Commi transaction para finalizar a transação, garantindo que todas as inserções sejam aplicadas ao banco de dados de forma consistente
GO