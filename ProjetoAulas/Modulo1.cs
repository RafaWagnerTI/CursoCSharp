namespace Capitulo1
{
  public static class HandsOnCode {
    public static void Variaveis() {
      Console.WriteLine("Primeiro programa");

      int idade = 23;
      string nomePessoa = "Rafael Wagner";

      Console.WriteLine("Oi eu sou " + nomePessoa + ", eu tenho " + idade + " anos.");

      decimal saldoAtualDecimal = 2.50M; //M no final força o double a ser convertido pra decimal
      float saldoAtualFloat = 2.51F; //F no final força o double a ser convertido para float
      double saldoAtualDbl = 2.52; //double por padrão

      Console.WriteLine("Meu saldo decimal é de " + saldoAtualDecimal +" R$\n"+
                        "Meu saldo float é de " + saldoAtualFloat + " R$\n" +
                        "Meu saldo double é de " + saldoAtualDbl + " R$"); 

      var idadeNova = 24; //var é uma variável que só tem seu tipo definido quando recebe o primeiro valor.

      Console.WriteLine("Eu tenho " + idadeNova + " fabulosos anos. ");

      char flag = 'Y';
      bool ePermitido = true;
      ePermitido = false;

      Console.WriteLine("Permissão definida: " + flag + "\n"+
                        "Acesso autorizado? " + ePermitido);

      const string descricao = "Curso CSharp"; //valor constante não pode ser alterado
      //descricao = "Curso";

      Console.Write(descricao);
    }

    public static void OperadoresA() {
      int num1 = 1;
      var num2 = 2;

      var soma = num1 + num2;
      Console.WriteLine("O resultado da soma é: " + soma);

      var subtracao = num2 - num1;
      Console.WriteLine("O resultado da subtração é: " + subtracao);

      var multiplicacao = (num2 * num1) * 10;
      Console.WriteLine("O resultado da multiplicação é: " + multiplicacao);

      var divisao = num2 / num1;
      Console.WriteLine("O resultado da multiplicação é: " + divisao);
    }

    public static void OperadoresR() {
      int num1 = 1;
      var num2 = 2;

      var igual = num1 == num2;
      var maior = num2 > num1;
      var menor = num2 < num1;
      var menorOuIgual = num2 <= num1;
      var maiorOuIgual = num2 >= num1;
      var diferente = num1 != num2;

      Console.WriteLine(num1 + " é igual a " + num2 + "?\nR: " + igual + "\n");

      Console.WriteLine(num2 + " é maior que " + num1 + "?\nR: " + maior + "\n");

      Console.WriteLine(num2 + " é menor que " + num1 + "?\nR: " + menor + "\n");

      Console.WriteLine(num2 + " é menor ou igual a " + num1 + "?\nR: " + menorOuIgual + "\n");

      Console.WriteLine(num2 + " é maior ou igual a " + num1 + "?\nR: " + maiorOuIgual + "\n");

      Console.WriteLine(num2 + " é diferente de " + num1 + "?\nR: " + diferente);
    }

    public static void OperadoresL() {
      int num1 = 1;
      var num2 = 2;

      bool validacaoE = num1 > num2 && 8 > 7;
      bool validacaoOU = num1 > num2 || 8 > 7;
      bool validacaoNegacao = !(num2 > num1);

      Console.WriteLine(num1 + " é maior que " + num2 + " E 8 é maior que 7?\nR: " + validacaoE + "\n");
      Console.WriteLine(num1 + " é maior que " + num2 + " OU 8 é maior que 7?\nR: " + validacaoOU + "\n");
      Console.WriteLine(num2 + " NÃO é maior que " + num1 + "?\nR: " + validacaoNegacao);
    }

    public static void OperadoresT() {
      bool ativo = false;
      string status = ativo ? "Cadastro Ativo" : "Cadastro Inativo";

      Console.WriteLine(status);
    }
  }
}

/*

*/