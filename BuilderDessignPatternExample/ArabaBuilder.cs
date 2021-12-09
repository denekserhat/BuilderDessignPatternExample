using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDessignPatternExample
{
    abstract class ArabaBuilder
    {
        protected Araba araba;
        public Araba Araba
        {
            get { return araba; }
        }

        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetVites();
    }
}
