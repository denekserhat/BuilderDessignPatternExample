using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDessignPatternExample
{
    class ArabaUret
    {
        public void Uret(ArabaBuilder Araba)
        {
            Araba.SetKM();
            Araba.SetMarka();
            Araba.SetModel();
            Araba.SetVites();
        }
    }
}
