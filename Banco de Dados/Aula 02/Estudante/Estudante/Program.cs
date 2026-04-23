using Estudante.Classes.Dados;
using Estudante.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

using var context = new AlunoContext();

context.Database.EnsureCreated();

Aluno pessoa1 = new Aluno("Cesar", 123456,"Python");
context.Alunos.Add(pessoa1);
context.SaveChanges();
