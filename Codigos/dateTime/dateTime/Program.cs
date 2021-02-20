using System;
using System.Globalization;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciação do date time
            //DateTime(ano, mes, dia)
            DateTime d1 = new DateTime(2000, 8, 15);

            //DateTime(ano, mes, dia, hora, minuto, segundo)[opcional: kind]
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            
            //DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo)[opcional: kind]
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

            //----------------------------------------------------------------------

            //Convertendo strings para dateTime passando em formatos diferentes
            DateTime e1 = DateTime.Parse("2000-08-15");
            DateTime e2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime e3 = DateTime.Parse("15/08/2000");
            DateTime e4 = DateTime.Parse("15/08/2000 13:05:58");

            //O parseExact utilizo para definir a formatação de um dia e horario
            DateTime f1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime f2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


        }
    }
}
