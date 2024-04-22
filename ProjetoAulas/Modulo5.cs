//namespace Capitulo5;

namespace Capitulo5
{
  public static class Calculos {
    public static int SomarNumeros(int a, int b) {
      return a+b;
    }
  }

  public class Produto
  {

    private int Id;
    public string Descricao { get; set; } = string.Empty;

    //public readonly int Estoque;
    public int Estoque { get; } //Propriedades readOnly só podem ser instanciadas pelo construtor.

    public Produto() {
      Estoque = 1;
    }

    public void ImprimirDescricao()
    {
      Console.WriteLine(GetId() + " - " + Descricao);
    }

    public void SetId(int id)
    {
      Id = id;
    }

    public int GetId()
    {
      return Id;
    }
  }

  public class Pessoa
  {
    public int Id {get;set;}

    public string Endereco {get;set;} = string.Empty;

    public string Cidade {get;set;} = string.Empty;

    public string Cep {get;set;} = string.Empty;

    public void ImprimirDados() {
      Console.WriteLine("Codigo: " + Id);
      Console.WriteLine("Endereço: " + Endereco);
      Console.WriteLine("Cidade: " + Cidade);
      Console.WriteLine("Cep: " + Cep);
    }
  }

  public class PessoaFisica : Pessoa
  {
    public string CPF {get;set;} = string.Empty;

    public void ImprmirCPF() 
    {
      Console.WriteLine("CPF: " + CPF);
    }
  }

  public class Funcionario : PessoaFisica
  {
    public string Matricula {get;set;} = string.Empty;
  }

  //sealed não permite que a classe seja herdada
  public sealed class Configuracao
  {
    public string Host {get;set;} = string.Empty;
  }

  public abstract class Animal
  {
    public string Nome {get;set;} = string.Empty;

    public abstract string GetInformacoes();

    public void ImprimirDados() {
      Console.WriteLine("Nome do animal: " + Nome);
      Console.WriteLine("Informações: " + GetInformacoes());
    }
  }

  public class Cachorro : Animal
  {
    public override string GetInformacoes()
    {
      return "Cachorro é um bom amigo";
    }
  }

  //  declarando dessa forma, record é uma propriedade readonly,
  //permitindo atribuição apenas no momento de declaração.
  public record Curso(int Id, string Descricao);

  public class CursoTeste {
    public int Id {get; set;}
    public string Descricao {get;set;} = string.Empty;
  }

  /*
  public record Curso
  {
    public int Id {get; set;}
    public string Descricao {get;set;} = string.Empty;

    /*
    public override bool Equals(object? obj)
    {
      if(obj == null) return false;

      if(obj is Curso curso)
      {
        return Id == curso.Id && Descricao == curso.Descricao;
      } 

      return base.Equals(obj);
    }

    public static bool operator == (Curso a, Curso b)
    {
      return a.Equals(b);
    }

    public static bool operator != (Curso a, Curso b)
    {
      return !(a == b);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
  */

  public interface INotificacao {
    String Descricao {get;set;}

    void Notificar();
  }

    public class NotificacaoCliente : INotificacao
    {
      public string Descricao { get; set; } = string.Empty;

      public void Notificar()
      {
        Console.WriteLine("Notificando Cliente");
      }

      public static void NotificarOutros()
      {
        Console.WriteLine("Notificando Outros");
      }
    }

    public class NotificacaoFuncionario : INotificacao
    {
      public string Descricao { get; set; } = string.Empty;

      public void Notificar()
      {
        Console.WriteLine("Notificando Funcionario");
      }

      public static void NotificarOutros()
      {
        Console.WriteLine("Notificando Outros");
      }
    }
}