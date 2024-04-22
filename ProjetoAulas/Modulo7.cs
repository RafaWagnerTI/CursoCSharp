using System.Text;

namespace Capitulo7;

public class TrabalhandoComStrings() {
  public static void ConverterParaLetrasMinusculas() {
    Console.InputEncoding = Encoding.Unicode;
    Console.OutputEncoding = Encoding.Unicode;
    Console.WriteLine("Favor digitar alguma informação: ");
    Console.WriteLine((Console.ReadLine() ?? string.Empty).ToLower());
  }

    public static void ConverterParaLetrasMaiusculas() {
    Console.InputEncoding = Encoding.Unicode;
    Console.OutputEncoding = Encoding.Unicode;
    Console.WriteLine("Favor digitar alguma informação: ");
    Console.WriteLine((Console.ReadLine() ?? string.Empty).ToUpper());
  }

  public static void AulaSubstring() {
    Console.InputEncoding = Encoding.Unicode;
    Console.OutputEncoding = Encoding.Unicode;
    Console.WriteLine("Favor digitar alguma informação: ");
    Console.WriteLine((Console.ReadLine() ?? string.Empty).Substring(6));
  }

  public static void AulaRange() {
    //Range manipula Collections
    //Uma string é uma collection de Char
    string nomeArquivo = "2024_04_20_backup.bak";
    string ano = nomeArquivo[..4];
    Console.WriteLine(ano);

    string extensao = nomeArquivo[^3..]; //Ultimas três letras da String
    Console.WriteLine(extensao);

    string nome = nomeArquivo[11..^4]; //Todos caractéres entre o 11º até a quarta última letra
    Console.WriteLine(nome);

    string apenasNome = nomeArquivo[..^4]; //Todos os caractéres menos os quatro últimos
    Console.WriteLine(apenasNome);
  }

  public static void AulaContains() {
    string nomeArquivo = "2024_04_20_backup.bak";
    if(nomeArquivo.Contains("backup_teste")) {
      Console.WriteLine("Palavra encontrada");
    }
    else Console.WriteLine("Palavra não encontrada");
  }

  public static void AulaTrim() {
    string teste = "***RAFAEL WAGNER***";
    Console.WriteLine("TOTAL: " + teste.Trim('*'));
    Console.WriteLine("INICIO: " + teste.TrimStart('*'));
    Console.WriteLine("FINAL: " + teste.TrimEnd('*'));
  }

  public static void AulaStartWithEndsWith() {
    string teste = "Curso CSharp";

    Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));
    Console.WriteLine("FINAL: " + teste.EndsWith("CSharp"));
  }
  public static void AulaReplace() {
    string teste = "Curso CSharp";
    Console.WriteLine(teste);
    Console.WriteLine(teste.Replace("CSharp", "C#"));
  }

  public static void AulaLength() {
    Console.InputEncoding = Encoding.Unicode;
    Console.OutputEncoding = Encoding.Unicode;
    Console.WriteLine("Favor digitar alguma informação: ");
    string teste = Console.ReadLine() ?? string.Empty;
    Console.WriteLine(teste);
    Console.WriteLine(teste.Length);
  }
}