//Console.WriteLine("Primeiro programa");
using Capitulo5;

namespace Application
{
  public class Program
  {
    static void Main(string[] args)
    {
      //Cap1();
      //Cap2();
      //Cap3();
      //Cap4();
      //Cap5();
      //Cap6();
      //Cap7();
      //Cap8();
      //Cap9();
      //Cap10();
      Cap11();
    }

    private static void Cap1() {
      Console.WriteLine("===VARIÁVEIS===");
      Capitulo1.HandsOnCode.Variaveis();
      Console.WriteLine("\n");
      Console.WriteLine("===OPERADORES ARITMÉTICOS===");
      Capitulo1.HandsOnCode.OperadoresA();
      Console.WriteLine("\n");
      Console.WriteLine("===OPERADORES RELACIONAIS===");
      Capitulo1.HandsOnCode.OperadoresR();
      Console.WriteLine("\n");
      Console.WriteLine("===OPERADORES LOGICOS===");
      Capitulo1.HandsOnCode.OperadoresL();
      Console.WriteLine("\n");
      Console.WriteLine("===OPERADOR TERNARIO===");
      Capitulo1.HandsOnCode.OperadoresT();
      Console.WriteLine("\n");
    }

    private static void Cap2() {
      Console.WriteLine("===PRIMEIRA FUNÇÃO===");
      Capitulo2.Funcoes.PrimeiraFuncao();
      Console.WriteLine("\n");
      Console.WriteLine("===FUNÇÃO COM PARAMETROS===");
      Capitulo2.Funcoes.FuncaoComParametros();
      Console.WriteLine("\n");
    }

    private static void Cap3() {
      Console.WriteLine("===ARRAY LIST LIVRE===");
      Capitulo3.EstruturaDados.ArrayListLivre();
      Console.WriteLine("\n");
      Console.WriteLine("===ARRAY LIST TIPADO===");
      Capitulo3.EstruturaDados.ArrayListTipado();
      Console.WriteLine("\n");
      Console.WriteLine("===LISTA GENERICA===");
      Capitulo3.EstruturaDados.ListaGenerica();
      Console.WriteLine("\n");
      Console.WriteLine("===DICIONARIO===");
      Capitulo3.EstruturaDados.Dicionario();
      Console.WriteLine("\n");
      Console.WriteLine("===FILA===");
      Capitulo3.EstruturaDados.Fila();
      Console.WriteLine("\n");
      Console.WriteLine("===PILHA===");
      Capitulo3.EstruturaDados.Pilha();
      Console.WriteLine("\n");
    }

    private static void Cap4() {
      Console.WriteLine("===IF ELSE===");
      Capitulo4.EstruturaControle.IfElse();
      Console.WriteLine("\n");
      Console.WriteLine("===SWITCH===");
      Capitulo4.EstruturaControle.Switch();
      Console.WriteLine("\n");
      Console.WriteLine("===FOR===");
      Capitulo4.EstruturaControle.For();
      Console.WriteLine("\n");
      Console.WriteLine("===FOREACH===");
      Capitulo4.EstruturaControle.ForEach();
      Console.WriteLine("\n");
      Console.WriteLine("===WHILE/DO WHILE===");
      Capitulo4.EstruturaControle.WhileDoWhile();
      Console.WriteLine("\n");
      Console.WriteLine("===BREAK/CONTINUE===");
      Capitulo4.EstruturaControle.BreakContinue();
      Console.WriteLine("\n");
    }

    private static void Cap5() {
      Console.WriteLine("===CLASSES===");
      AulaClasses();
      Console.WriteLine("\n");
      Console.WriteLine("===ATRIBUTOS SOMENTE LEITURA===");
      AulaPropriedadeSomenteLeitura();
      Console.WriteLine("\n");
      Console.WriteLine("===HERDANDO CLASSES===");
      AulaHeranca();
      Console.WriteLine("\n");
      Console.WriteLine("===CLASSES SELADAS===");
      AulaClasseSelada();
      Console.WriteLine("\n");
      Console.WriteLine("===CLASSES ABSTRATAS===");
      AulaClasseAbstrata();
      Console.WriteLine("\n");
      Console.WriteLine("===RECORD===");
      AulaRecord();
      Console.WriteLine("\n");
      Console.WriteLine("===INTERFACE===");
      AulaInterface();
      Console.WriteLine("\n");
    }

    private static void Cap6() {
      Console.WriteLine("===CONVERT/PARSE===");
      AulaConvertParse();
      Console.WriteLine("\n");
      Console.WriteLine("===TRY/PARSE===");
      AulaTryParse();
      Console.WriteLine("\n");
    }

    private static void Cap7() {
      Console.WriteLine("==LETRAS MINUSCULAS===");
      AulaLetrasMinusculas();
      Console.WriteLine("\n");
      Console.WriteLine("==LETRAS MAIUSCULAS===");
      AulaLetrasMaiusculas();
      Console.WriteLine("\n");
      Console.WriteLine("===SUBSTRING===");
      AulaSubstring();
      Console.WriteLine("\n");
      Console.WriteLine("===RANGE===");
      AulaRange();
      Console.WriteLine("\n");
      Console.WriteLine("===CONTAINS===");
      AulaContains();
      Console.WriteLine("\n");
      Console.WriteLine("===TRIM===");
      AulaTrim();
      Console.WriteLine("\n");
      Console.WriteLine("===START WITH / ENDS WITH===");
      AulaStartWithEndsWith();
      Console.WriteLine("\n");
      Console.WriteLine("===REPLACE===");
      AulaReplace();
      Console.WriteLine("\n");
      Console.WriteLine("===LENGTH===");
      AulaLength();
      Console.WriteLine("\n");
    }

    private static void Cap8() {
      Console.WriteLine("===INSTANCIANDO DATAS===");
      AulaInstanciandoData();
      Console.WriteLine("\n");
      Console.WriteLine("===SUBTRAINDO DATAS===");
      AulaSubtraindoDatas();
      Console.WriteLine("\n");
      Console.WriteLine("===ADICIONANDO DIAS/MES/ANO===");
      AulaAdicionandoDiasMesAnos();
      Console.WriteLine("\n");
      Console.WriteLine("===ADICIONANDO HORAS/MINUTOS/SEGUNDOS===");
      AulaAdicionandoHorasMinutosSegundos();
      Console.WriteLine("\n");
      Console.WriteLine("===DIA DA SEMANA===");
      AulaDiaDaSemana();
      Console.WriteLine("\n");
      Console.WriteLine("===SOMENTE DATA===");
      AulaDateOnly();
      Console.WriteLine("\n");
      Console.WriteLine("===SOMENTE HORA===");
      AulaTimeOnly();
      Console.WriteLine("\n");
    }

    private static void Cap9() {
      /*Console.WriteLine("===GERANDO EXCEÇÃO===");
      AulaGerandoExcecao();
      Console.WriteLine("\n");*/
      Console.WriteLine("===TRATANDO EXCEÇÃO===");
      AulaTratandoExcecao();
      Console.WriteLine("\n");
    }

    private static void Cap10() {
      Console.WriteLine("===GERANDO ARQUIVOS===");
      AulaGerandoArquivo();
      Console.WriteLine("\n");
      Console.WriteLine("===LENDO ARQUIVOS===");
      AulaLendoArquivo();
      Console.WriteLine("\n");
      Console.WriteLine("===EXCLUINDO ARQUIVOS===");
      AulaExcluindoArquivo();
      Console.WriteLine("\n");
    }

    private static void Cap11() {
      Console.WriteLine("===WHERE===");
      AulaWhere();
      Console.WriteLine("\n");
      Console.WriteLine("===ORDER BY===");
      AulaOrdenacao();
      Console.WriteLine("\n");
      Console.WriteLine("===TAKE===");
      AulaTake();
      Console.WriteLine("\n");
      Console.WriteLine("===COUNT===");
      AulaCount();
      Console.WriteLine("\n");
      Console.WriteLine("===FIRST/FIRST OU DEFAULT===");
      AulaFirstEFirstOuDefault();
      Console.WriteLine("\n");
      Console.WriteLine("===DISTINCT===");
      AulaDistinct();
      Console.WriteLine("\n");
      Console.WriteLine("===AVERAGE===");
      AulaAverage();
      Console.WriteLine("\n");
    }

    public static void AulaWhere() {
      Capitulo11.TrabalhandoComLinq.AplicandoWhere();
    }

    public static void AulaOrdenacao() {
      Capitulo11.TrabalhandoComLinq.AplicandoOrderBy();
    }

    public static void AulaTake() {
      Capitulo11.TrabalhandoComLinq.AplicandoTake();
    }

    
    public static void AulaCount() {
      Capitulo11.TrabalhandoComLinq.AplicandoCount();
    }
    
    public static void AulaFirstEFirstOuDefault() {
      Capitulo11.TrabalhandoComLinq.AplicandoFirstEFirstOrDefault();
    }

    public static void AulaDistinct() {
      Capitulo11.TrabalhandoComLinq.AplicandoDistinct();
    }

    public static void AulaAverage() {
      Capitulo11.TrabalhandoComLinq.AplicandoMedia();
    }

    private static void AulaGerandoArquivo() {
      Capitulo10.TrabalhandoComArquivos.GerandoArquivo();
    }

    private static void AulaLendoArquivo() {
      Capitulo10.TrabalhandoComArquivos.LendoArquivo();
    }

    private static void AulaExcluindoArquivo() {
      Capitulo10.TrabalhandoComArquivos.ExcluindoArquivo();
    }
    private static void AulaGerandoExcecao() {
      Capitulo9.TrabalhandoComExceptions.AulaGerandoExceptions();
    }

    private static void AulaTratandoExcecao() {
      Capitulo9.TrabalhandoComExceptions.AulaTratandoExceptions();
    }

    private static void AulaInstanciandoData() {
      Capitulo8.TrabalhandoComDatas.AulaInstanciandoData();
    }

    public static void AulaSubtraindoDatas() {
      Capitulo8.TrabalhandoComDatas.AulaSubtraindoDatas();
    }

    public static void AulaAdicionandoDiasMesAnos() {
      Capitulo8.TrabalhandoComDatas.AulaAdicionandoDiasMesAnos();
    }

    public static void AulaAdicionandoHorasMinutosSegundos() {
      Capitulo8.TrabalhandoComDatas.AulaAdicionandoHorasMinutosSegundos();
    }

    public static void AulaDiaDaSemana() {
      Capitulo8.TrabalhandoComDatas.AulaDiaDaSemana();
    }

    public static void AulaDateOnly() {
      Capitulo8.TrabalhandoComDatas.AulaDateOnly();
    }

    public static void AulaTimeOnly() {
      Capitulo8.TrabalhandoComDatas.AulaTimeOnly();
    }

    private static void AulaLetrasMinusculas() {
      Capitulo7.TrabalhandoComStrings.ConverterParaLetrasMinusculas();
    }

    private static void AulaLetrasMaiusculas() {
      Capitulo7.TrabalhandoComStrings.ConverterParaLetrasMaiusculas();
    }

    private static void AulaSubstring() {
      Capitulo7.TrabalhandoComStrings.AulaSubstring();
    }

    private static void AulaRange() {
      Capitulo7.TrabalhandoComStrings.AulaRange();
    }

    private static void AulaContains() {
      Capitulo7.TrabalhandoComStrings.AulaContains();
    }

    private static void AulaTrim() {
      Capitulo7.TrabalhandoComStrings.AulaTrim();
    }

    private static void AulaStartWithEndsWith() {
      Capitulo7.TrabalhandoComStrings.AulaStartWithEndsWith();
    }

    private static void AulaReplace() {
      Capitulo7.TrabalhandoComStrings.AulaReplace();
    }

    private static void AulaLength() {
      Capitulo7.TrabalhandoComStrings.AulaLength();
    }

    private static void AulaConvertParse() {
      Capitulo6.Conversor.ConvertAndParse();
    }

    private static void AulaTryParse() {
      Capitulo6.Conversor.ConvTryParse();
    }

    private static void AulaClasses() {
      var resultado = Capitulo5.Calculos.SomarNumeros(5, 6);
      Console.WriteLine(resultado);

      /*
      var produto = new Cadastro.Produto();

      produto.SetId(1);
      produto.Descricao = "Churrasqueira Controle Remoto";

      produto.ImprimirDescricao();
      Console.WriteLine(produto.GetId());
      */
    }

    private static void AulaPropriedadeSomenteLeitura() {
      var produto = new Capitulo5.Produto();
      //produto.Estoque = 1; Não é possível pois é uma propriedade read only

      Console.WriteLine(produto.Estoque);
    }

    private static void AulaHeranca() {
      /*
      var pessoaFisica = new Capitulo5.PessoaFisica();
      pessoaFisica.Id = 1;
      pessoaFisica.Endereco = "Rua Teste";
      pessoaFisica.Cidade = "Cidade Teste";
      pessoaFisica.Cep = "123456-78";
      pessoaFisica.CPF = "123.456.789-12";

      pessoaFisica.ImprimirDados();
      pessoaFisica.ImprmirCPF();
      */
      var funcionario = new Capitulo5.Funcionario
      {
        Id = 2,
        Endereco = "Rua Teste",
        Cidade = "Cidade Teste",
        Cep = "123456-78",
        CPF = "123.456.789-12"
      };

      funcionario.ImprimirDados();
      funcionario.ImprmirCPF();
    }

    private static void AulaClasseSelada() {
      //var configuracao = new Capitulo5.Configuracao();
      //configuracao.Host = "localhost";

      var configuracao = new Capitulo5.Configuracao 
      {
        Host = "localhost"
      };
      Console.WriteLine(configuracao.Host);
    }

    private static void AulaClasseAbstrata() {
      var cachorro = new Capitulo5.Cachorro
      {
        Nome = "Cachorro"
      };
      cachorro.ImprimirDados();
    }

    private static void AulaRecord() {
      //var curso1 = new Capitulo5.Curso { Id = 1, Descricao = "Curso" };
      //var curso2 = new Capitulo5.Curso { Id = 1, Descricao = "Curso" };
      
      var curso1 = new Capitulo5.Curso(1,"Curso");
      var curso2 = curso1 with { Descricao = "Teste Novo" };

      //var curso1 = new Capitulo5.CursoTeste { Id = 1, Descricao = "Curso" };
      //var curso2 = curso1;
      //curso2.Descricao = "TESTE TESTE";
      //var curso2 = new Capitulo5.CursoTeste();
      //curso2.Id = curso1.Id;
      //curso2.Descricao = "Nova descricao";

      Console.WriteLine(curso1.Id + " - " + curso1.Descricao);
      Console.WriteLine(curso2.Id + " - " + curso2.Descricao);
      //Console.WriteLine(curso1.Equals(curso2));
      //Console.WriteLine(curso1 == curso2);

    }

    private static void AulaInterface() {
      var notificacaoCliente = new Capitulo5.NotificacaoCliente();
      notificacaoCliente.Notificar();
      NotificacaoCliente.NotificarOutros();

      Capitulo5.INotificacao notificacao = new Capitulo5.NotificacaoFuncionario();
      notificacao.Notificar();
      //notificacao.NotificarOutros(); Não é possível chamar o NotificarOutros pois o objeto instanciado é a Interface, e nela essa função não existe.
    }
  }
}