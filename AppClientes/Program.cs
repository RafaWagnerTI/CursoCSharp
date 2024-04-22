using System.Globalization;
using RegrasCli;

namespace AppClientes;

class Program
{
    static RegrasCliente _regrasCli = new RegrasCliente();
    static void Main(string[] args)
    {
        //Define regionalismos para cadastro de data
        var cultura = new CultureInfo("pt-BR");
        Thread.CurrentThread.CurrentCulture = cultura;
        Thread.CurrentThread.CurrentUICulture = cultura;

        _regrasCli.LerDados();

        while(true) {
            Menu();

            EscolherOpcao();
        }
    }

    static void Menu() {
        Console.Clear();

        Console.WriteLine("Cadastro de Clientes");
        Console.WriteLine("--------------------");
        Console.WriteLine("1 - Cadastrar Cliente");
        Console.WriteLine("2 - Exibir Clientes");
        Console.WriteLine("3 - Editar Cliente");
        Console.WriteLine("4 - Excluir Cliente");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("--------------------");
    }

    static void EscolherOpcao() {
        Console.WriteLine("Escolha uma opção: ");

        var opcao = Console.ReadLine();

        switch(int.Parse(opcao)) {
            case 1: {
                _regrasCli.CadastrarCliente();
                Menu();
                break;
            }
            case 2: {
                _regrasCli.ExibirClientes();
                Menu();
                break;
            }
            case 3: {
                _regrasCli.EditarCliente();
                Menu();
                break;
            }
            case 4: {
                _regrasCli.ExcluirCliente();
                Menu();
                break;
            }
            case 5: {
                _regrasCli.GravarDadosCliente();
                Environment.Exit(0);
                break;
            }
            default: {
                Console.Clear();
                Console.WriteLine("Opção Inválida!");
                break;
            }

        }
    }
}
