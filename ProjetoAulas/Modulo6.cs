namespace Capitulo6;

public class Conversor {

  public static void ConvertAndParse() {
    //int numero = int.Parse("1"); //Recomendad usar int.Parse ao invés do Convert.
    //int numero = Convert.ToInt32(null); // Convert, converte null para 0, oque não é ideal
    bool verdadeiro = bool.Parse("true");
    Console.WriteLine(verdadeiro);
  }

  public static void ConvTryParse() {
    var numero = "acb";
    int numeroConvertido;

    //Quando não consegue converter, atribui um valor default pra variável
    if(int.TryParse(numero, out numeroConvertido)) {
      Console.WriteLine("Numero foi convertido com sucesso!");
    }
    Console.WriteLine(numeroConvertido);
  }

}