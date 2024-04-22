using System.Text;

namespace Capitulo10;

public class TrabalhandoComArquivos() {

  public static void GerandoArquivo() {
    var escrever = new StreamWriter("Cadastro.txt", true);
    //o segundo parametro permite que informação seja adicionada ao arquivo após criado
    Console.InputEncoding = Encoding.Unicode;
    Console.Write("Informe um nome: ");
    var nome = Console.ReadLine() ?? string.Empty;
    escrever.WriteLine("ID...:" + Random.Shared.Next(1, 100)); /*Numero aleatório entre 1 e 100*/
    escrever.WriteLine("Nome.:" + nome);
    escrever.WriteLine("-----------------------");
    escrever.Close();
  }

  public static void LendoArquivo() {
    //var conteudo = File.ReadAllText("Cadastro.txt");

    Console.OutputEncoding = Encoding.Unicode;

    //Console.WriteLine(conteudo);

    var ler = new StreamReader("Cadastro.txt");
    while(!ler.EndOfStream) {
      var linha = ler.ReadLine();
      Console.WriteLine(linha);
    }
    ler.Close();
  }

  public static void ExcluindoArquivo() {
    if(File.Exists("Cadastro.txt")) {
      File.Delete("Cadastro.txt");
      Console.WriteLine("Arquivo excluído com sucesso!");
    }
  }
}