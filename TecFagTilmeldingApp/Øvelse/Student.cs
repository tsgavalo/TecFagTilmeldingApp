using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Øvelse
{
    internal sealed class Student : TecFagTilmeldingApp.Øvelse.Person
    {
        public void CallParentProtectedMethod()
        {
            SayHello("");
        }

        protected override string ShowMyIdentity() => "Jeg er en elev.";
    }
}
