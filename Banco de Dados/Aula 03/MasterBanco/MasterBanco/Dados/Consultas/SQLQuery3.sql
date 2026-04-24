-- OP READ - LER

SELECT * FROM Contas;
GO

SELECT Titular,Numero_da_conta,Saldo FROM Contas
WHERE Saldo > 1000;
GO

SELECT * FROM Contas
WHERE Titular LIKE '%Maria%';
GO