using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Generics
{
    internal sealed class Bil : Kørtøj
    {
        public double MotorStørrelse { get; set; }

        public Bil(string? mærke, string? model, double motorStørrelse) : base(mærke, model)
        {
            MotorStørrelse = motorStørrelse;
        }
    }
}
