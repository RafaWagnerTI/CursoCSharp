using System.Collections;

namespace Capitulo3
{
  public static class EstruturaDados 
  {
    public static void ArrayListLivre() {

      var arrayList = new ArrayList();

      arrayList.Add(23);
      arrayList.Add("Rafael");
      arrayList.Add(false);
      arrayList.Add(2.74);

      Console.WriteLine(arrayList[0]);

      arrayList.RemoveAt(0);

      arrayList.Clear(); // ou arrayList = new ArrayList()

      foreach(var item in arrayList) 
      {
        Console.WriteLine(item);
      }
    }

    public static void ArrayListTipado() {
      //var arrayTipadoNumero = new int[3] {1, 2, 3};
      var arrayTipadoNumero = new int[3];

      arrayTipadoNumero[0] = 5;
      arrayTipadoNumero[1] = 5;
      arrayTipadoNumero[2] = 10;

      //Muda o tamanho do array referenciado para o tamanho informado
      Array.Resize(ref arrayTipadoNumero, 4);
      arrayTipadoNumero[3] = 20;

      foreach(var item in arrayTipadoNumero) 
      {
        Console.WriteLine(item);
      }

      //var arrayTipadoString = new string[2] {"Rafael", "Wagner"};
      var arrayTipadoString = new string[2];

      arrayTipadoString[0] = "Rafael";
      arrayTipadoString[1] = "Wagner";

      foreach(var item in arrayTipadoString) 
      {
        Console.WriteLine(item);
      }
    }

    public static void ListaGenerica() {
      //var lista = new List<string>() {
      //  "Rafael",
      //  "Trindade",
      //  "Aula"
      //};

      //var lista = new List<string>(10);
      var lista = new List<string>();
      lista.Add("Rafael");
      lista.Add("Trindade");
      lista.Add("Aula");

      var nome = lista[0];
      Console.WriteLine(nome);

      lista.RemoveAt(1);

      foreach(var item in lista) {
        Console.WriteLine(item);
      }
    }

    public static void Dicionario() {
      //var dicionario = new Dictionary<string, string>() 
      //{
      //  {"nome", "Rafael"},
      //  {"curso", "Curso"}
      //};

      var dicionario = new Dictionary<int, string>();
      dicionario.Add(1, "Rafael");

      dicionario[2] = "Curso";

      var nome = dicionario[1];
      //Console.WriteLine(nome);

      foreach(var item in dicionario) {
        Console.WriteLine("Chave: " + item.Key + " Valor: " + item.Value);
      }
    }

    public static void Fila() {
      var fila = new Queue<string>();

      fila.Enqueue("Rafael");
      fila.Enqueue("Wagner");

      //var nome = fila.Peek(); // Te informa qual será o próximo valor a sair da fila

      var nome = fila.Dequeue(); // Retorna o próximo valor a sair da fila, e retira dela.
      var nome1 = fila.Dequeue();

      Console.WriteLine(nome);
      Console.WriteLine(nome1);

      //foreach(var item in fila) {
      //  Console.WriteLine(fila); --Não retorna nada, porque todos os valores foram removidos da fila
      //}
    }

    public static void Pilha() {
      var pilha = new Stack<string>();

      pilha.Push("Rafael");
      pilha.Push("Wagner");

      //var nome = pilha.Peek();

      var nome = pilha.Pop();
      var nome1 = pilha.Pop();

      Console.WriteLine(nome);
      Console.WriteLine(nome1);

      //foreach(var item in pilha) {
      //  Console.WriteLine(item);
      //}
    }
  }
}