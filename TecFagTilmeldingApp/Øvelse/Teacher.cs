using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Øvelse
{
    internal class Teacher : TecFagTilmeldingApp.Øvelse.Person
    {
        protected override string ShowMyIdentity() => "Jeg er en lærer.";
    }
}
