namespace Capitulo8;

public class TrabalhandoComDatas() {

  public static void AulaInstanciandoData() {
    var date1 = new DateTime(2022, 12, 22, 19, 22, 23);
    var date2 = DateTime.Parse("2022/12/22 19:22:23");
    var date3 = DateTime.Now; //Data e hora atual
    var date4 = DateTime.Today; //Data atual

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);
    Console.WriteLine(date4);

    Console.WriteLine(date1.ToString("dd/MM/yyyy HH:mm:ss"));

    var dateOffSet1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0)); //TimeSpnan define horas minutos e segundo do fuso horário
    Console.WriteLine(dateOffSet1.LocalDateTime); //Data e hora local
    Console.WriteLine(dateOffSet1.UtcDateTime); //Data e hora sem fuso horário

    //Console.WriteLine(DateTimeOffset.Now);
    //Console.WriteLine(DateTimeOffset.UtcNow);
  }

  public static void AulaSubtraindoDatas()
  {
    var date1 = DateTime.Now;
    var date2 = DateTime.Parse("2022-01-01");

    //var diff = date1 - date2;
    var diff = date1.Subtract(date2);

    Console.WriteLine((int)diff.TotalDays);
    Console.WriteLine((int)diff.TotalHours);
  }

  public static void AulaAdicionandoDiasMesAnos() {
    var date1 = DateTime.Now;

    Console.WriteLine(date1.AddDays(3).ToString("dd-MM-yyyy"));
    Console.WriteLine(date1.AddMonths(3).ToString("dd-MM-yyyy"));
    Console.WriteLine(date1.AddYears(3).ToString("dd-MM-yyyy"));
  }

  public static void AulaAdicionandoHorasMinutosSegundos() {
    var date1 = DateTime.Now;

    Console.WriteLine(date1.ToString("HH:mm:ss"));
    Console.WriteLine(date1.AddHours(3).ToString("HH:mm:ss"));
    Console.WriteLine(date1.AddMinutes(3).ToString("HH:mm:ss"));
    Console.WriteLine(date1.AddSeconds(3).ToString("HH:mm:ss"));
  }

  public static void AulaDiaDaSemana() {
    var date1 = DateTime.Now;
    Console.WriteLine(date1.DayOfWeek);
  }

  public static void AulaDateOnly() {
    var somenteData = new DateOnly(2022,12,2);
    var somenteDataString = DateOnly.Parse("2022-12-02");

    Console.WriteLine(somenteData.ToString("dd/MM/yyyy"));
    Console.WriteLine(somenteDataString.ToString("dd/MM/yyyy"));
  }

  public static void AulaTimeOnly() {
    var somenteHora = new TimeOnly(12,23,35,0);
    var somenteHoraString = TimeOnly.Parse("12:23:35");

    Console.WriteLine(somenteHora.ToString("HH:mm:ss"));
    Console.WriteLine(somenteHoraString.ToString("HH:mm:ss"));
  }
}