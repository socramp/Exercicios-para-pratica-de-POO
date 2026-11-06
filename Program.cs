using Exercício;

// EX 1 -----------------------------------------------------------------------------
Pessoas pessoa1 = new Pessoas();
pessoa1.Nome = "Marcos";
pessoa1.Idade = 17;
pessoa1.Cidade = "São Paulo";

Pessoas pessoa2 = new Pessoas();
pessoa2.Nome = "Clara";
pessoa2.Idade = 16;
pessoa2.Cidade = "São Paulo";

pessoa1.Apresentar();
pessoa2.Apresentar();

// EX 2 -----------------------------------------------------------------------------
Calculadora c = new Calculadora();

Console.WriteLine(c.Somar(5, 5));
Console.WriteLine(c.Subtrair(5, 5));
Console.WriteLine(c.Multiplicar(5, 5));

Console.WriteLine(Calculadora.Dividir(5, 5));

// EX 3 -----------------------------------------------------------------------------
Veiculo carro = new Veiculo();

carro.alterarVelocidade(100);
Console.WriteLine($"A velicidade do seu carro é de {carro.velocidade}km/h");

carro.alterarVelocidade(250);
Console.WriteLine($"A velicidade do seu carro é de {carro.velocidade}km/h");

carro.alterarVelocidade(120);
Console.WriteLine($"A velicidade do seu carro é de {carro.velocidade}km/h");

carro.alterarVelocidade(-50);
Console.WriteLine($"A velicidade do seu carro é de {carro.velocidade}km/h");

// EX 4 -----------------------------------------------------------------------------
Funcionario func = new Funcionario();

func.Nome = "Uchoa";
func.Cargo = "Chefe";

Console.WriteLine($"Seu nome é {func.Nome} e o seu cargo é {func.Cargo}");
func.ConsultarSalario();

func.AumentarSalario(20);

// func.Salario = 2000.00m;
// ele da erro e diz que o set é inacessivel alem de uma linha que puxa a linha de criação do atributo, mostando o private set;

// EX 5 -----------------------------------------------------------------------------

Livro l1 = new Livro();
Livro l2 = new Livro("Fortaleza Digital");
Livro l3 = new Livro("Anjos e Demônios", "Dan Brown");
Livro l4 = new Livro("O Código de DaVinci", "Dan Brown", 432);

Console.WriteLine($"O título do livro é {l1.Titulo}, o autor é {l1.Autor} e ele tem {l1.NumPaginas} páginas");
Console.WriteLine($"O título do livro é {l2.Titulo}, o autor é {l2.Autor} e ele tem {l2.NumPaginas} páginas");
Console.WriteLine($"O título do livro é {l3.Titulo}, o autor é {l3.Autor} e ele tem {l3.NumPaginas} páginas");
Console.WriteLine($"O título do livro é {l4.Titulo}, o autor é {l4.Autor} e ele tem {l4.NumPaginas} páginas");
