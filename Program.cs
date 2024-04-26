using ExplorandoClasses.Models;

Pessoa pessoa1 = new Pessoa("Gabriel", "Santos");
Pessoa pessoa2 = new Pessoa("Livia", "Santos");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();

