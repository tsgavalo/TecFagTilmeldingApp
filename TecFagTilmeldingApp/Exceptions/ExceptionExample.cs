using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Exceptions;

internal class ExceptionExample
{
    public static int GetAgeAccessCount { get; set; }

    public static string GetAge(string fødselsdato)
    {
        int age = 0;

        try
        {
            //GetAgeAccessCount++;
            age = DateTime.Now.Year - Convert.ToDateTime(fødselsdato).Year;
            return $"Din alder er {age}";
        }
        catch (Exception exc)
        {
            //GetAgeAccessCount++;
            return exc.Message;
        }

        GetAgeAccessCount++;
    }
}
