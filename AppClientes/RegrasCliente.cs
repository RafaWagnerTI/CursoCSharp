using Cadastro;

namespace RegrasCli;

public class RegrasCliente {

  public List<Cliente> clientes = new List<Cliente>();

  public void GravarDadosCliente() {
    var json = System.Text.Json.JsonSerializer.Serialize(clientes);

    File.WriteAllText("clientes.txt", json);
  }

  public void LerDados() {
    if(File.Exists("clientes.txt")) {
      var dados = File.ReadAllText("clientes.txt");
    
      var clientesArquivo = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(dados);

      clientes.AddRange(clientesArquivo);
    }
  }

  public void ExcluirCliente() {
    Console.Clear();
    Console.Write("Informe o código do cliente: ");
    var codigo = Console.ReadLine();

    var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo ?? string.Empty));

    if(cliente == null) {
      Console.WriteLine("Cliente não encontrado! [Enter]");
      Console.ReadKey();
      return;
    }

    ImprimirCliente(cliente);

    clientes.Remove(cliente);
    Console.WriteLine("Cliente Removido com sucesso! [Enter]");
    Console.ReadKey();
  }

  public void EditarCliente() {
    Console.Clear();
    Console.Write("Informe o código do cliente: ");
    var codigo = Console.ReadLine();

    var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo ?? string.Empty));

    if(cliente == null) {
      Console.WriteLine("Cliente não encontrado! [Enter]");
      Console.ReadKey();
      return;
    }

    ImprimirCliente(cliente);

    Console.Write("Nome do Cliente: ");
    var nome = Console.ReadLine();
    Console.Write(Environment.NewLine);

    Console.Write("Data de Nascimento: ");
    var dataNascimento = DateOnly.Parse(Console.ReadLine() ?? "01/01/2000");
    Console.Write(Environment.NewLine);

    Console.Write("Desconto: ");
    var desconto = decimal.Parse(Console.ReadLine() ?? "0");
    Console.Write(Environment.NewLine);

    cliente.Nome = nome;
    cliente.DataNascimento = dataNascimento;
    cliente.Desconto = desconto;
    cliente.CadastradoEm = DateTime.Now;

    Console.WriteLine("Cliente Alterado com sucesso! [Enter]");
    ImprimirCliente(cliente);
    Console.ReadKey();
  }

  public void CadastrarCliente() {
    Console.Clear();

    Console.Write("Nome do Cliente: ");
    var nome = Console.ReadLine();
    Console.Write(Environment.NewLine);

    Console.Write("Data de Nascimento: ");
    var dataNascimento = DateOnly.Parse(Console.ReadLine() ?? "01/01/2000");
    Console.Write(Environment.NewLine);

    Console.Write("Desconto: ");
    var desconto = decimal.Parse(Console.ReadLine() ?? "0");
    Console.Write(Environment.NewLine);

    var cliente = new Cliente();
    cliente.Id = definirNovoId();
    cliente.Nome = nome;
    cliente.DataNascimento = dataNascimento;
    cliente.Desconto = desconto;
    cliente.CadastradoEm = DateTime.Now;

    clientes.Add(cliente);

    Console.WriteLine("Cliente Cadastrado com sucesso! [Enter]");
    ImprimirCliente(cliente);
    Console.ReadKey();
  }

  public void ImprimirCliente(Cliente cliente) {
    Console.WriteLine("ID.............:" + cliente.Id);
    Console.WriteLine("Nome...........:" + cliente.Nome);
    Console.WriteLine("Desconto.......:" + cliente.Desconto);
    Console.WriteLine("Data Nascimento:" + cliente.DataNascimento);
    Console.WriteLine("Data Cadastro..:" + cliente.CadastradoEm);
    Console.WriteLine("-----------------------------------");
  }

  public void ExibirClientes() {
    Console.Clear();
    foreach(var cliente in clientes) {
      ImprimirCliente(cliente);
    }

    Console.ReadKey();
  }

  private int definirNovoId() {
    int novoId = 0;
    if(clientes.Count > 0)
      novoId = clientes.Select(c => c.Id).Max();
    return novoId + 1;
  }
}