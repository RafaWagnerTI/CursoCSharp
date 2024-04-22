namespace Capitulo11;

public class TrabalhandoComLinq() {

  public static void AplicandoWhere() {
    /*
    string nomeCompleto = "ALFREDO ALVARES AGUIAR";

    Func<char, bool> funcFiltraA = c => c == 'A';

    //var resultado = nomeCompleto.Where(funcFiltraA);
    //var resultado = nomeCompleto.Where(p => p == 'A');

    var resultado = from c in nomeCompleto where c == 'A' select c;

    foreach(var letra in resultado) {
      Console.WriteLine(letra);
    }*/

    var numeros = new int[] {10, 6, 5, 50, 15, 2};
    var resultado = numeros.Where (p => p >= 10);
    foreach(var numero in resultado) {
      Console.WriteLine(numero);
    }
  }

  public static void AplicandoOrderBy() {
    //var numeros = new int[] {10, 6, 5, 50, 15, 2};

    //var resultado = numeros.OrderBy(p => p);
    //var resultado = numeros.OrderByDescending(p => p);

    var nomes = new string[] {"Karen", "Henry", "Rafael", "Gabriel"};

    //var resultado = nomes.OrderBy(p => p);
    var resultado = nomes.OrderByDescending(p => p);

    foreach(var numero in resultado) {
      Console.WriteLine(numero);
    }
  }

  public static void AplicandoTake() {
    var numeros = new int[] {10, 6, 5, 50, 15, 2};

    //var resultado = numeros.Take(3); // Pega os tres primeiros da coleção
    //var resultado = numeros.Take(^3..); // Pega os três últimos da coleção

    var resultado = numeros.Where(p => p > 10).OrderBy(p => p).Take(3); //Pega registros maiores que 10, ordena eles do menor pro maior e em seguida pega os três primeiros

    foreach(var numero in resultado) {
      Console.WriteLine(numero);
    }
  }

  public static void AplicandoCount() {

    var numeros = new int[] {10, 6, 5, 50, 15, 2};

    //pode ser usado sem parametor para contar todos
    var resultado = numeros.Count(p => p > 10);

    Console.WriteLine(resultado);
  }

  public static void AplicandoFirstEFirstOrDefault() {

    var numeros = new int[] {10, 6, 5, 50, 15, 2};

    //retorna o primeiro valor, mas gera exceção se a coleção estiver vazia
    //var resultado = numeros.First();
    //var resultado = numeros.First(p => p >= 100);

    //retorna o primeiro valor, mas retorna um valor padrão se a coleção estiver vazia
    var resultado = numeros.FirstOrDefault(p => p >= 100, -99);
    //var resultado = numeros.FirstOrDefault(-99);

    Console.WriteLine(resultado);
  }

  public static void AplicandoDistinct() {

    var numeros = new int[] {10, 6, 10, 5, 10, 50, 10, 15, 2};

    var resultado = numeros.Distinct();

    foreach(var numero in resultado) {
      Console.WriteLine(numero);
    }
  }

  public static void AplicandoMedia() {

    var numeros = new int[] {10, 6, 5, 50, 15, 2};

    //var resultado = numeros.Average();
    var resultado = numeros.Average(p => p + 5);

    Console.WriteLine(resultado);

  }
  
}