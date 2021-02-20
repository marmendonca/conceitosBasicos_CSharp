using System;

namespace propDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);

            //Pega a data sem o horario
            Console.WriteLine("1) Date: " + d.Date);

            //pega somente o dia
            Console.WriteLine("2) Day: " + d.Day);

            //pega o dia da semana
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);

            //pega o dia do ano
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);

            //pega somente a hora
            Console.WriteLine("5) Hour: " + d.Hour);

            //Informa o tipo, se é universal ou local
            Console.WriteLine("6) Kind: " + d.Kind);

            //informa só os millisecond
            Console.WriteLine("7) Millisecond: " + d.Millisecond);

            //só os minutos
            Console.WriteLine("8) Minute: " + d.Minute);

            //só o mes
            Console.WriteLine("9) Month: " + d.Month);

            //só os segundos
            Console.WriteLine("10) Second: " + d.Second);

            //só os ticks
            Console.WriteLine("11) Ticks: " + d.Ticks);

            //só o horario que é o time span
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);

            //só o ano
            Console.WriteLine("13) Year: " + d.Year);

            //Formatação (DateTime -> string) ----------------------------------

            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);

            //mostra esse formato: quarta-feira, 15 de agosto de 2001
            string s1 = d.ToLongDateString();

            //mostra esse formato: 13:45:58
            string s2 = d.ToLongTimeString();

            //mostra esse formato: 15/08/2001
            string s3 = d.ToShortDateString();

            //mostra esse formato: 13:45
            string s4 = d.ToShortTimeString();

            //mostra esse formato: 15/08/2001 13:45:58
            string s5 = d.ToString();

            //mostra esse formato: 2001-08-15 13:45:58  
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");

            //mostra esse formato: 2001-08-15 13:45:58.275
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            //Operações com Datetime ------------------------

            DateTime x = new DateTime(30, 01, 2021, 18, 46, 50);

            DateTime y = x.Add();
            DateTime y = x.AddDays(1);
            DateTime y = x.AddHours(1.6);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);
            DateTime y = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);
        }
    }
}
