namespace Capitulo2
{
  public static class Funcoes {

    public static void PrimeiraFuncao() {
      ExecutarProcessos();

      void ExecutarProcessos()
      {
        var resultNome = NomeCompleto();
        var resultSoma = "A soma dos valores é " + SomaValores();

        Console.WriteLine(resultNome);
        Console.WriteLine(resultSoma);
      }

      string NomeCompleto() 
      {
        string primeiroNome = "Rafael";
        string segundoNome = "Wagner";
        return "Oi! Meu nome completo é " + primeiroNome + " " + segundoNome;
      }

      int SomaValores()
      {
        int primeiroValor = 4;
        int segundoValor = 3;
        return primeiroValor + segundoValor;
      }
    }

    public static void FuncaoComParametros() {
      var resultSoma = SomaValores(3, 7);
      Console.WriteLine("O reusltado da soma é: " + resultSoma);

      var resultApresentacao =  Apresentacao("Rafael", 23);  
      Console.WriteLine(resultApresentacao);

      string Apresentacao(string nome, int idade)
      {
        return $"Oi meu nome é {nome} e tenho {idade} anos.";
      } 

      int SomaValores(int a, int b) {
        return a + b;
      }
    }

  }
}