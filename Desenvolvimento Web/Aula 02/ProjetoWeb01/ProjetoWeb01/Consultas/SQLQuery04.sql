-- 7) Consultas úteis
-- Lista todos os usuarios + tipo
SELECT
    U.Id,
    U.Nome,
    U.Email,
    U.Regra,
    CASE WHEN A.Id IS NOT NULL THEN 'Aluno'
         WHEN AD.Id IS NOT NULL THEN 'Admin'
         ELSE 'Sem perfil' END AS TipoPerfil
FROM dbo.Usuario U
LEFT JOIN dbo.Alunos A ON A.Id = U.Id
LEFT JOIN dbo.Admin  AD ON AD.Id = U.Id
ORDER BY U.Id;

-- Só alunos
SELECT U.Id, U.Nome, U.Email, A.RA, A.StatusWIFI, A.StatusAction, A.CursoID
FROM dbo.Usuario U
INNER JOIN dbo.Alunos A ON A.Id = U.Id;

-- Só admins
SELECT U.Id, U.Nome, U.Email
FROM dbo.Usuario U
INNER JOIN dbo.Admin AD ON AD.Id = U.Id;
GO