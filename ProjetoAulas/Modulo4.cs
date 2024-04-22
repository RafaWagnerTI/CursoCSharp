namespace Capitulo4
{
  public static class EstruturaControle
  {
    public static void IfElse() {
      /*
      var diaDaSemana = 0;
      var diaDeTrabalho = false;

      if (diaDaSemana == 0 && diaDeTrabalho) 
      {
        Console.WriteLine("Hoje é domingo");
      } 
      else if(diaDaSemana == 0 && !diaDeTrabalho) {
        Console.WriteLine("Hoje é domingo mas não trabalho");
      }
      else 
      {
        Console.WriteLine("Hoje não é domingo!");
      }
      */

      var diaDaSemana = 10;

      if (diaDaSemana == 0) 
      {
        Console.WriteLine("Hoje é domingo");
      } 
      else if (diaDaSemana == 1) 
      {
        Console.WriteLine("Hoje é segunda");
      }
      else if (diaDaSemana == 2) 
      {
        Console.WriteLine("Hoje é terça");
      }
      else if (diaDaSemana == 3) 
      {
        Console.WriteLine("Hoje é quarta");
      }
      else if (diaDaSemana == 4) 
      {
        Console.WriteLine("Hoje é quinta");
      }
      else if (diaDaSemana == 5) 
      {
        Console.WriteLine("Hoje é sexta");
      }
      else if (diaDaSemana == 6) 
      {
        Console.WriteLine("Hoje é sábado");
      }
      else {
        Console.WriteLine("Dia da semana inválido");
      }
    }

    public static void Switch() {
      var diaDaSemana = 0;
      switch(diaDaSemana) {
        case 0: {
          Console.WriteLine("Hoje é domingo");
          break;
        }
        case 1:
          Console.WriteLine("Hoje é segunda");
          break;
        case 2:
          Console.WriteLine("Hoje é terça");
          break;
        case 3:
          Console.WriteLine("Hoje é quarta");
          break;
        case 4:
          Console.WriteLine("Hoje é quinta");
          break;
        case 5:
          Console.WriteLine("Hoje é sexta");
          break;
        case 6:
          Console.WriteLine("Hoje é sábado");
          break;
        default:
          Console.WriteLine("Dia da semana inválido");
        break;
      }
    }

    public static void For() {
      var lista = new List<string>() { "Rafael", "Curso", "CSharp"};
      var totalItensLista = lista.Count;

      for(var i = 0; i < totalItensLista; i++) {
        var nome = lista[i];
        Console.WriteLine(nome);
      }
    }

    public static void ForEach() {
      var lista = new List<string>() { "Rafael", "Curso", "CSharp"};

      foreach(string item in lista) {
        Console.WriteLine(item);
      }

      foreach(var letra in "Rafael") {
        Console.WriteLine(letra);
      }
    }

    public static void WhileDoWhile() {
      var i = 3;
      while (i < 2) 
      {
        Console.WriteLine($"var i = {i}");
        i++;
      }

      var j = 3;
      do {
        Console.WriteLine($"var j = {j}");
        j++;
      } while (j < 2);
    }
    
    public static void BreakContinue() {
      var i = 0;
      while (i < 5) 
      {

        if(i < 2) {
          Console.WriteLine("Continuando...");
          i++;
          continue;
        }

        Console.WriteLine($"var i = {i}");

        if(i == 2) 
        {
          Console.WriteLine("Valor de i é igual a 2");
          break;
        }

        i++;

      }
    }
  }
}