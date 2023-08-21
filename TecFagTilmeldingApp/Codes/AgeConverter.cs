﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Codes;

internal struct AgeConverter
{
    public int Age { get; set; }

    public AgeConverter(DateTime birthDate)
    {
        Age = DateTime.Now.Year - birthDate.Year;
    }
}
