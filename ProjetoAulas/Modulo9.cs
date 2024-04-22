namespace Capitulo9;

public class TrabalhandoComExceptions() {

  public static void AulaGerandoExceptions() {

    while(true) {
      Console.Write("Informe um número: ");
      var numero = Console.ReadLine() ?? "0";
      var resultado = 500 / int.Parse(numero);
      Console.WriteLine("Resultado: " + resultado);
    }
  }

  public static void AulaTratandoExceptions() {
    bool condicao = true;
    while(condicao) {
      try {
        Console.Write("Informe um número: ");
        var numero = Console.ReadLine() ?? "0";
        var resultado = 500 / int.Parse(numero);
        Console.WriteLine("Resultado: " + resultado);
      }
      catch(DivideByZeroException e) {
        Console.WriteLine("Ocorreu um erro de divisão: " + e.Message);
        Console.WriteLine("Stack: " + e.StackTrace);
      }
      catch (FormatException) {
        Console.WriteLine("Operação cancelada");
        condicao = false;
      }
      catch(Exception e) {
        Console.WriteLine("Ocorreu um erro de divisão: " + e.Message);
        Console.WriteLine("Stack: " + e.StackTrace);
      }
    }
  }
}