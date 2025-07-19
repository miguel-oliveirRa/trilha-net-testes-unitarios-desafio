using TestesUnitarios.Desafio.Console.Services;

var validacoes = new ValidacoesString();

var textTeste = "Matrix é um filme de ficção científica";

Console.WriteLine($"Quantidade de caracteres: {validacoes.RetornarQuantidadeCaracteres(textTeste)}");

Console.WriteLine($"\n Contém a palavra 'Matrix'? {validacoes.ContemCaractere(textTeste, "n")}");

Console.WriteLine($"\n O texto termina com 'científica'? {validacoes.TextoTerminaCom(textTeste, "c")}");