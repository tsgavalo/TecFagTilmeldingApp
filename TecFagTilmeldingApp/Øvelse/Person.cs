using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Øvelse;

internal abstract class Person
{
    protected string SayHello(string param)
    {
        return $"Hej, jeg er en {param}.";
    }

    protected string SayHello(string param1, string param2) =>
        $"Hej, jeg er en {param1} og jeg hedder {param2}.";

    protected abstract string ShowMyIdentity();
}
