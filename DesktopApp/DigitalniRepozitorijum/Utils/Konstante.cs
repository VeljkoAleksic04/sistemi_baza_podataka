using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Utils
{
    public static class Konstante
    {
        public static readonly List<string> StatusiPublikacije =
            new List<string>
               {
                    "u pripremi",
                    "poslat na recenziju",
                    "u reviziji",
                    "prihvacen",
                    "odbijen",
                    "objavljen",
                    "arhiviran"
               };
    }
}
